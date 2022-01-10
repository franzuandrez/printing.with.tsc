namespace TSCLIB_DLL_IN_C_Sharp
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該公開 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1098, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verOrdenToolStripMenuItem,
            this.ingresoInventarioToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.archivoToolStripMenuItem.Text = "Inicio";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // verOrdenToolStripMenuItem
            // 
            this.verOrdenToolStripMenuItem.Name = "verOrdenToolStripMenuItem";
            this.verOrdenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verOrdenToolStripMenuItem.Text = "Ordenes de compra";
            this.verOrdenToolStripMenuItem.Click += new System.EventHandler(this.verOrdenToolStripMenuItem_Click);
            // 
            // ingresoInventarioToolStripMenuItem
            // 
            this.ingresoInventarioToolStripMenuItem.Name = "ingresoInventarioToolStripMenuItem";
            this.ingresoInventarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresoInventarioToolStripMenuItem.Text = "Ingreso Inventario";
            this.ingresoInventarioToolStripMenuItem.Click += new System.EventHandler(this.ingresoInventarioToolStripMenuItem_Click);
            // 
            // pnMain
            // 
            this.pnMain.AutoSize = true;
            this.pnMain.Location = new System.Drawing.Point(12, 27);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1074, 569);
            this.pnMain.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 608);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verOrdenToolStripMenuItem;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.ToolStripMenuItem ingresoInventarioToolStripMenuItem;
    }
}

