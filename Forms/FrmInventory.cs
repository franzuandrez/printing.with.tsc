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
    }
}
