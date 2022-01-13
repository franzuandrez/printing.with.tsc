using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSCLIB_DLL_IN_C_Sharp.App;
using TSCLIB_DLL_IN_C_Sharp.DataSource;
using TSCLIB_DLL_IN_C_Sharp.Models;

namespace TSCLIB_DLL_IN_C_Sharp.Forms
{
    public partial class FrmInventory : Form
    {
        DataGridViewRow rowToPrint;
        private List<LabelTypeModel> labelsTypes;
        public FrmInventory()
        {
            InitializeComponent();
        }
        private void showProgressBar(ProgressBar progressBar)
        {
            progressBar.Visible = true;
            var rand = new Random();
            int max = rand.Next(50, 80);

            for (int i = 0; i < max; i++)
            {
                progressBar.Value = i;
            }

        }

        private void hideProgressBar(ProgressBar progressBar)
        {


            for (int i = 80; i <= 100; i++)
            {
                progressBar.Value = i;
            }

            progressBar.Visible = false;

        }
        private async void loadLabelsType()
        {

            labelsTypes = await LabelTypeProcesor.loadLabels(); ;
            this.cmbxLabelsType.DataSource = labelsTypes;
            this.cmbxLabelsType.DisplayMember = "Name";
            this.cmbxLabelsType.ValueMember = "Id";
            this.cmbxLabelsType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void loadInventoryPrintouts()
        {
            showProgressBar(pgBarPrintouts);
            var orders = await InventoryPrintoutsProcessor.loadInventoryPrintous();
            dataGridInventoryPrintouts.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridInventoryPrintouts.DataSource = orders;
            dataGridInventoryPrintouts.ClearSelection();
            dataGridInventoryPrintouts.Columns["Id"].HeaderText = "Id";
            dataGridInventoryPrintouts.Columns["Product_id"].Visible = false;
            dataGridInventoryPrintouts.Columns["Name"].HeaderText = "Nombre";
            dataGridInventoryPrintouts.Columns["Description"].HeaderText = "Descripción";
            dataGridInventoryPrintouts.Columns["Sku"].HeaderText = "SKU";
            dataGridInventoryPrintouts.Columns["Quantity"].HeaderText = "Cantidad Impresiones";
            dataGridInventoryPrintouts.Columns["Quantity_Printed"].HeaderText = "Cantidad Impresa";
            dataGridInventoryPrintouts.Columns["Printed_By"].HeaderText = "Impreso Por";
            dataGridInventoryPrintouts.Columns["Is_Printed"].HeaderText = "Impresion Completa";
            loadLabelsType();
            hideProgressBar(pgBarPrintouts);
        }
        private  void FrmInventory_Load(object sender, EventArgs e)
        {
            APIHelper.InitializeCliente();
            loadInventoryPrintouts();


        }

        private void dataGridInventoryPrintouts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowToPrint = this.dataGridInventoryPrintouts.Rows[e.RowIndex];
                setValuesPrintSelected();


            }
        }

        private void setValuesPrintSelected()
        {

            String quantity = (Int32.Parse(rowToPrint.Cells["Quantity"].Value.ToString()) - Int32.Parse(rowToPrint.Cells["Quantity_Printed"].Value.ToString())).ToString();

            lblSKU.Text = rowToPrint.Cells["Sku"].Value.ToString();
            lblID.Text = rowToPrint.Cells["Id"].Value.ToString();
            txtQuantity.Text = quantity;
            rtxtDescription.Text = rowToPrint.Cells["Description"].Value.ToString();
            lblName.Text = rowToPrint.Cells["Name"].Value.ToString();
        }

        private async void btnImprimir_Click(object sender, EventArgs e)
        {
            var labelSelected = labelsTypes.Find(label => label.id == Int32.Parse(cmbxLabelsType.SelectedValue.ToString()));
            bool isPrintoutSelected = int.TryParse(lblID.Text, out _);

            if (!isPrintoutSelected)
            {
                MessageBox.Show("Seleccione un producto",
                 "Producto no seleccionado",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning
                );

                return;
            }

            PrintoutModel print = new PrintoutModel
            {
                Id = Int32.Parse(lblID.Text),
                Quantity_Printed = Int32.Parse(txtQuantity.Text),
                Printed_By = 1//TODO get id user loged

            };

            List<PrintoutModel> printoutModels = new List<PrintoutModel>();
            printoutModels.Add(print);
            await PrintoutsProcessor.storePrintouts(printoutModels);
            PrintoutsProcessor.print(lblSKU.Text, lblName.Text, Int32.Parse(txtQuantity.Text), labelSelected);
            loadInventoryPrintouts();


        }
    }
}
