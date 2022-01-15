using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using TSCLIB_DLL_IN_C_Sharp.Forms;

namespace TSCLIB_DLL_IN_C_Sharp
{
    public partial class Form1 : Form
    {

        //Fields
        private Button currentButton;
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
            pnMain.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
            //pnMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text = String.Empty;
            this.ControlBox = false;
            btnClose.Visible = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#2196f3");
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnTitle.BackColor = color;
                    pnLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnClose.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pnSideBar.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
             this.pnMain.Controls.Add(childForm);
            this.pnMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

       

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {


            clearMainPanel();
            FrmPendingOrders frmPendingOrders = new FrmPendingOrders();
            loadFormToPanel(frmPendingOrders);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ingresoInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearMainPanel();
            FrmInventory frmInventoryPrintouts = new FrmInventory();
            loadFormToPanel(frmInventoryPrintouts);
        }

        private void loadFormToPanel(Form frm)
        {
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.pnMain.Controls.Add(frm);
            this.pnMain.Tag = frm;
            this.pnMain.Size = frm.Size;
            this.Location = frm.Location;
            frm.Show();
        }
        private void clearMainPanel()
        {
            if (this.pnMain.Controls.Count > 0)
            {
                this.pnMain.Controls.RemoveAt(0);
            }
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FrmPendingOrders(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmInventory(), sender);
        }

        private void pnMain_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {


            if (activeForm != null)
                activeForm.Close();

            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "INICIO";
            currentButton = null;
            btnClose.Visible = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void pnTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}