using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSCLIB_DLL_IN_C_Sharp.App;
using TSCLIB_DLL_IN_C_Sharp.Models;

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
            var dataSource = new List<LabelType>();
            dataSource.Add(new LabelType() { Id=1, Dimension="1 x 0.5", Unit="Pulgadas"});
            dataSource.Add(new LabelType() { Id=2, Dimension = "1.5 x 1", Unit="Pulgadas"});
            this.cmbxLabelsType.DataSource = dataSource;
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
            hideProgressBar(pbPrintouts);
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


        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private  void dataGridOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                 orderSelected = this.dataGridOrders.Rows[e.RowIndex];

                loadPrintingList();
                clearPrintoutSelected();
            }
        }

        private void dataGridOrders_ReadOnlyChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimirTodo_Click(object sender, EventArgs e)
        {
            foreach (PrintoutModel print in printouts)
            {
                int qty = print.Quantity - print.Quantity_Printed;
                PrintoutsProcessor.print(print.Sku, print.Name, qty);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {


        }

        private void pcLoader_Click(object sender, EventArgs e)
        {

        }

        private async void  btnImprimir_Click(object sender, EventArgs e)
        {

           
            PrintoutModel print = new PrintoutModel
             {
                Id = Int32.Parse(lblID.Text),
                Quantity_Printed = Int32.Parse(txtQuantity.Text),
                Printed_By= 1//TODO get id user loged
               
            };

            List<PrintoutModel> printoutModels =  new List<PrintoutModel>();
            printoutModels.Add(print);
            await PrintoutsProcessor.storePrintouts(printoutModels);
            PrintoutsProcessor.print(lblSKU.Text, lblName.Text, Int32.Parse(txtQuantity.Text));
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }
    }
}
