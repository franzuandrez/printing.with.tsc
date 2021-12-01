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

namespace TSCLIB_DLL_IN_C_Sharp
{
    public partial class FrmPendingOrders : Form
    {
        public FrmPendingOrders()
        {
            InitializeComponent();
        }

        private async void FrmPendingOrders_Load(object sender, EventArgs e)
        {
            APIHelper.InitializeCliente();
            var orders = await PendingOrdersProcessor.LoadPendingOrders();
            dataGridOrders.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridOrders.DataSource = orders;    
        }

      

        private  void button1_Click(object sender, EventArgs e)
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
                Console.WriteLine(row.Cells[0].Value.ToString());

                var printouts = await PrintoutsProcessor.LoadPrintouts(Int32.Parse(row.Cells[0].Value.ToString()));
                dataGridPrintouts.EditMode = DataGridViewEditMode.EditProgrammatically;
                dataGridPrintouts.DataSource = printouts;
            }
        }

        private void dataGridOrders_ReadOnlyChanged(object sender, EventArgs e)
        {

        }
    }
}
