using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TSCLIB_DLL_IN_C_Sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // string WT1 = "Franzua Andrez";
            string B1 = "1234567890";
            byte[] result_unicode = System.Text.Encoding.GetEncoding("utf-16").GetBytes("Franzua Andrez");
            //byte[] result_utf8 = System.Text.Encoding.UTF8.GetBytes("TEXT 10,10,\"ARIAL.TTF\",0,10,10,\"utf8 Franzua Andrez\"");

            //TSCLIB_DLL.about();
            byte status = TSCLIB_DLL.usbportqueryprinter();//0 = idle, 1 = head open, 16 = pause, following <ESC>!? command of TSPL manual
            TSCLIB_DLL.openport("TSC TE200");
            TSCLIB_DLL.sendcommand("SIZE 29 mm, 13 mm");
            TSCLIB_DLL.sendcommand("SPEED 4");
            TSCLIB_DLL.sendcommand("DENSITY 12");
            TSCLIB_DLL.sendcommand("DIRECTION 1");
            TSCLIB_DLL.sendcommand("SET TEAR ON");
            TSCLIB_DLL.sendcommand("CODEPAGE UTF-8");
            TSCLIB_DLL.clearbuffer();
            //TSCLIB_DLL.downloadpcx("UL.PCX", "UL.PCX");
            //TSCLIB_DLL.windowsfont(0, 0, 12, 0, 0, 0, "Arial", "Windows Font Test");
            TSCLIB_DLL.windowsfontUnicode(20, 3, 18, 0, 0, 0, "Arial", result_unicode);
           // TSCLIB_DLL.sendcommand("PUTPCX 1,1,\"UL.PCX\"");
           // TSCLIB_DLL.sendBinaryData(result_utf8, result_utf8.Length);
            //TSCLIB_DLL.barcode("20", "20", "128", "28", "1", "0", "2", "2", B1);
            TSCLIB_DLL.barcode("20", "20", "128", "48", "1", "0", "2", "2", B1);
           // TSCLIB_DLL.printerfont("20", "10", "0", "0", "15", "15", WT1);
            TSCLIB_DLL.printlabel("1", "1");
            TSCLIB_DLL.closeport();

            
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmPendingOrders frmPendingOrders = new FrmPendingOrders();
            frmPendingOrders.Show();

        }
    }
}