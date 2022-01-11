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
namespace TSCLIB_DLL_IN_C_Sharp.Forms
{
    public partial class FrmInventory : Form
    {
        DataGridViewRow rowToPrint;

        public FrmInventory()
        {
            InitializeComponent();
        }

        private async void FrmInventory_Load(object sender, EventArgs e)
        {
            APIHelper.InitializeCliente();
          
            var orders = await InventoryPrintoutsProcessor.loadInventoryPrintous();

            dataGridInventoryPrintouts.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridInventoryPrintouts.DataSource = orders;
            dataGridInventoryPrintouts.ClearSelection();
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
