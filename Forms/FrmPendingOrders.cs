using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSCLIB_DLL_IN_C_Sharp.App;
using TSCLIB_DLL_IN_C_Sharp.Models;
using System.Linq;
using TSCLIB_DLL_IN_C_Sharp.DataSource;

namespace TSCLIB_DLL_IN_C_Sharp
{
    public partial class FrmPendingOrders : Form
    {


        public FrmPendingOrders()
        {
            InitializeComponent();
        }

        private List<PrintoutModel> printouts;
        DataGridViewRow orderSelected;
        DataGridViewRow rowToPrint;
        private List<LabelTypeModel> labelsTypes;

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

        private void loadLabelsType()
        {

            labelsTypes = LabelTypes.labels();
            this.cmbxLabelsType.DataSource = labelsTypes ;
            this.cmbxLabelsType.DisplayMember = "Name";
            this.cmbxLabelsType.ValueMember = "Id";
            this.cmbxLabelsType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void loadPrintingList()
        {
           
            showProgressBar(pbPrintouts);
            var printouts = await PrintoutsProcessor.LoadPrintouts(Int32.Parse(orderSelected.Cells[0].Value.ToString()));
            dataGridPrintouts.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridPrintouts.DataSource = printouts;
            this.printouts = printouts;
            lblTotalPendingPrintouts.Text = printouts.Sum( print => print.Quantity - print.Quantity_Printed ).ToString();
            hideProgressBar(pbPrintouts);
            dataGridPrintouts.Columns["Id"].HeaderText = "Id";
            dataGridPrintouts.Columns["Product_id"].Visible = false;
            dataGridPrintouts.Columns["Name"].HeaderText = "Nombre";
            dataGridPrintouts.Columns["Description"].HeaderText = "Descripción";
            dataGridPrintouts.Columns["Sku"].HeaderText = "SKU";
            dataGridPrintouts.Columns["Quantity"].HeaderText = "Cantidad Impresiones";
            dataGridPrintouts.Columns["Quantity_Printed"].HeaderText = "Cantidad Impresa";
            dataGridPrintouts.Columns["Printed_By"].HeaderText = "Impreso Por";
            dataGridPrintouts.Columns["Is_Printed"].HeaderText = "Impresion Completa";
            dataGridPrintouts.ClearSelection();

        }
        private async void FrmPendingOrders_Load(object sender, EventArgs e)
        {

            APIHelper.InitializeCliente();
            showProgressBar(pbOrders);
            var orders = await PendingOrdersProcessor.LoadPendingOrders();
            hideProgressBar(pbOrders);
           
            dataGridOrders.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridOrders.DataSource = orders;
            dataGridOrders.Columns["Purchase_order_id"].HeaderText = "No. Orden";
            dataGridOrders.Columns["Vendor"].HeaderText = "Proveedor";
            dataGridOrders.Columns["Ship_method"].HeaderText = "Método de envio";
            dataGridOrders.Columns["Order_date"].HeaderText = "Fecha";
            dataGridOrders.ClearSelection();
            loadLabelsType();

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

        private void setValuesOrderSelected()
        {

            lblVendor.Text = orderSelected.Cells["Vendor"].Value.ToString();
            lblOrderDate.Text = orderSelected.Cells["Order_Date"].Value.ToString();
            lblTotalPendingPrintouts.Text = "0";
        }





        private  void dataGridOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                 orderSelected = this.dataGridOrders.Rows[e.RowIndex];

                loadPrintingList();
                setValuesOrderSelected();
                clearPrintoutSelected();
            }
        }


        private void btnImprimirTodo_Click(object sender, EventArgs e)
        {
            var labelSelected = labelsTypes.Find(label => label.Id == Int32.Parse(cmbxLabelsType.SelectedValue.ToString()));
            foreach (PrintoutModel print in printouts)
            {
                int qty = print.Quantity - print.Quantity_Printed;
                PrintoutsProcessor.print(print.Sku, print.Name, qty, labelSelected);
            }
        }


        private async void  btnImprimir_Click(object sender, EventArgs e)
        {

            var labelSelected = labelsTypes.Find(label => label.Id == Int32.Parse(cmbxLabelsType.SelectedValue.ToString()));
            bool isSelected = int.TryParse(lblID.Text, out _);

            if (!isSelected)
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
                Printed_By= 1//TODO get id user loged
               
            };

            List<PrintoutModel> printoutModels =  new List<PrintoutModel>();
            printoutModels.Add(print);
            await PrintoutsProcessor.storePrintouts(printoutModels);
            PrintoutsProcessor.print(lblSKU.Text, lblName.Text, Int32.Parse(txtQuantity.Text), labelSelected);
            if (orderSelected != null)
            {
                loadPrintingList();
                
            }
            

        }

        private void dataGridPrintouts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowToPrint = this.dataGridPrintouts.Rows[e.RowIndex];
                setValuesPrintSelected();


            }
        }

        private void clearPrintoutSelected()
        {
            lblSKU.Text = "";
            rtxtDescription.Text = "";
            txtQuantity.Text = "";
            lblName.Text = "";

        }

    }
}
