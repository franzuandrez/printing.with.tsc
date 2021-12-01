using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
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
        private async void FrmPendingOrders_Load(object sender, EventArgs e)
        {

            APIHelper.InitializeCliente();
            showProgressBar(pbOrders);
            var orders = await PendingOrdersProcessor.LoadPendingOrders();
            hideProgressBar(pbOrders);
            dataGridOrders.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridOrders.DataSource = orders;

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

        private async void dataGridOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridOrders.Rows[e.RowIndex];

                showProgressBar(pbPrintouts);
                var printouts = await PrintoutsProcessor.LoadPrintouts(Int32.Parse(row.Cells[0].Value.ToString()));
                dataGridPrintouts.EditMode = DataGridViewEditMode.EditProgrammatically;
                dataGridPrintouts.DataSource = printouts;
                this.printouts = printouts;
                hideProgressBar(pbPrintouts);
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
                PrintoutsProcessor.print(print.Sku, print.Name, print.Quantity);
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {


            PrintoutsProcessor.print(lblSKU.Text, rtxtDescription.Text, Int32.Parse(txtQuantity.Text));
        }

        private void dataGridPrintouts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridPrintouts.Rows[e.RowIndex];
                lblSKU.Text = row.Cells["Sku"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                rtxtDescription.Text = row.Cells["Description"].Value.ToString();
              
            }
        }

        private void clearPrintoutSelected()
        {
            lblSKU.Text = "";
            rtxtDescription.Text = "";
            txtQuantity.Text = "";

        }
    }
}
