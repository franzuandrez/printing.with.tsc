namespace TSCLIB_DLL_IN_C_Sharp.Forms
{
    partial class FrmInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblImpresionTitle = new System.Windows.Forms.Label();
            this.lblLabelTitle = new System.Windows.Forms.Label();
            this.cmbxLabelsType = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescriptionTitle = new System.Windows.Forms.Label();
            this.lblQuantityTitle = new System.Windows.Forms.Label();
            this.lblSKU = new System.Windows.Forms.Label();
            this.lblSkuTitle = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnImprimirTodo = new System.Windows.Forms.Button();
            this.pgBarPrintouts = new System.Windows.Forms.ProgressBar();
            this.dataGridInventoryPrintouts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventoryPrintouts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImpresionTitle
            // 
            this.lblImpresionTitle.AutoSize = true;
            this.lblImpresionTitle.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpresionTitle.Location = new System.Drawing.Point(12, 13);
            this.lblImpresionTitle.Name = "lblImpresionTitle";
            this.lblImpresionTitle.Size = new System.Drawing.Size(136, 30);
            this.lblImpresionTitle.TabIndex = 5;
            this.lblImpresionTitle.Text = "Impresiones";
            // 
            // lblLabelTitle
            // 
            this.lblLabelTitle.AutoSize = true;
            this.lblLabelTitle.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelTitle.Location = new System.Drawing.Point(919, 45);
            this.lblLabelTitle.Name = "lblLabelTitle";
            this.lblLabelTitle.Size = new System.Drawing.Size(62, 15);
            this.lblLabelTitle.TabIndex = 36;
            this.lblLabelTitle.Text = "Etiqueta:";
            // 
            // cmbxLabelsType
            // 
            this.cmbxLabelsType.FormattingEnabled = true;
            this.cmbxLabelsType.Location = new System.Drawing.Point(922, 63);
            this.cmbxLabelsType.Name = "cmbxLabelsType";
            this.cmbxLabelsType.Size = new System.Drawing.Size(200, 21);
            this.cmbxLabelsType.TabIndex = 35;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(916, 17);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(58, 13);
            this.lblID.TabIndex = 34;
            this.lblID.Text = "-----------------";
            this.lblID.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(922, 157);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 15);
            this.lblName.TabIndex = 33;
            this.lblName.Text = "-----------------";
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTitle.Location = new System.Drawing.Point(919, 144);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(61, 15);
            this.lblNameTitle.TabIndex = 32;
            this.lblNameTitle.Text = "Nombre:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(922, 396);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(200, 22);
            this.txtQuantity.TabIndex = 31;
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Enabled = false;
            this.rtxtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescription.Location = new System.Drawing.Point(922, 198);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(200, 168);
            this.rtxtDescription.TabIndex = 30;
            this.rtxtDescription.Text = "";
            // 
            // lblDescriptionTitle
            // 
            this.lblDescriptionTitle.AutoSize = true;
            this.lblDescriptionTitle.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionTitle.Location = new System.Drawing.Point(919, 182);
            this.lblDescriptionTitle.Name = "lblDescriptionTitle";
            this.lblDescriptionTitle.Size = new System.Drawing.Size(84, 15);
            this.lblDescriptionTitle.TabIndex = 29;
            this.lblDescriptionTitle.Text = "Descripción:";
            // 
            // lblQuantityTitle
            // 
            this.lblQuantityTitle.AutoSize = true;
            this.lblQuantityTitle.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityTitle.Location = new System.Drawing.Point(922, 379);
            this.lblQuantityTitle.Name = "lblQuantityTitle";
            this.lblQuantityTitle.Size = new System.Drawing.Size(67, 15);
            this.lblQuantityTitle.TabIndex = 28;
            this.lblQuantityTitle.Text = "Cantidad:";
            // 
            // lblSKU
            // 
            this.lblSKU.AutoSize = true;
            this.lblSKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSKU.Location = new System.Drawing.Point(919, 121);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Size = new System.Drawing.Size(75, 15);
            this.lblSKU.TabIndex = 27;
            this.lblSKU.Text = "-----------------";
            // 
            // lblSkuTitle
            // 
            this.lblSkuTitle.AutoSize = true;
            this.lblSkuTitle.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkuTitle.Location = new System.Drawing.Point(919, 96);
            this.lblSkuTitle.Name = "lblSkuTitle";
            this.lblSkuTitle.Size = new System.Drawing.Size(35, 15);
            this.lblSkuTitle.TabIndex = 26;
            this.lblSkuTitle.Text = "SKU:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(922, 422);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(200, 36);
            this.btnImprimir.TabIndex = 25;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnImprimirTodo
            // 
            this.btnImprimirTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirTodo.Location = new System.Drawing.Point(922, 463);
            this.btnImprimirTodo.Name = "btnImprimirTodo";
            this.btnImprimirTodo.Size = new System.Drawing.Size(200, 47);
            this.btnImprimirTodo.TabIndex = 24;
            this.btnImprimirTodo.Text = "Imprimir todos los pendientes";
            this.btnImprimirTodo.UseVisualStyleBackColor = true;
            // 
            // pgBarPrintouts
            // 
            this.pgBarPrintouts.Location = new System.Drawing.Point(12, 211);
            this.pgBarPrintouts.Name = "pgBarPrintouts";
            this.pgBarPrintouts.Size = new System.Drawing.Size(904, 23);
            this.pgBarPrintouts.TabIndex = 37;
            // 
            // dataGridInventoryPrintouts
            // 
            this.dataGridInventoryPrintouts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInventoryPrintouts.Location = new System.Drawing.Point(12, 46);
            this.dataGridInventoryPrintouts.Name = "dataGridInventoryPrintouts";
            this.dataGridInventoryPrintouts.Size = new System.Drawing.Size(904, 464);
            this.dataGridInventoryPrintouts.TabIndex = 0;
            this.dataGridInventoryPrintouts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridInventoryPrintouts_CellClick);
            // 
            // FrmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 540);
            this.Controls.Add(this.pgBarPrintouts);
            this.Controls.Add(this.lblLabelTitle);
            this.Controls.Add(this.cmbxLabelsType);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNameTitle);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.lblDescriptionTitle);
            this.Controls.Add(this.lblQuantityTitle);
            this.Controls.Add(this.lblSKU);
            this.Controls.Add(this.lblSkuTitle);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnImprimirTodo);
            this.Controls.Add(this.lblImpresionTitle);
            this.Controls.Add(this.dataGridInventoryPrintouts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInventory";
            this.Text = "FrmInventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventoryPrintouts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblImpresionTitle;
        private System.Windows.Forms.Label lblLabelTitle;
        private System.Windows.Forms.ComboBox cmbxLabelsType;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label lblDescriptionTitle;
        private System.Windows.Forms.Label lblQuantityTitle;
        private System.Windows.Forms.Label lblSKU;
        private System.Windows.Forms.Label lblSkuTitle;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnImprimirTodo;
        private System.Windows.Forms.ProgressBar pgBarPrintouts;
        private System.Windows.Forms.DataGridView dataGridInventoryPrintouts;
    }
}