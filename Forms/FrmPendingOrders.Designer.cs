namespace TSCLIB_DLL_IN_C_Sharp
{
    partial class FrmPendingOrders
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridOrders = new System.Windows.Forms.DataGridView();
            this.dataGridPrintouts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblImpresionTitle = new System.Windows.Forms.Label();
            this.btnImprimirTodo = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.pbOrders = new System.Windows.Forms.ProgressBar();
            this.pbPrintouts = new System.Windows.Forms.ProgressBar();
            this.lblSkuTitle = new System.Windows.Forms.Label();
            this.lblSKU = new System.Windows.Forms.Label();
            this.lblQuantityTitle = new System.Windows.Forms.Label();
            this.lblDescriptionTitle = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.cmbxLabelsType = new System.Windows.Forms.ComboBox();
            this.lblLabelTitle = new System.Windows.Forms.Label();
            this.lblVendorTitle = new System.Windows.Forms.Label();
            this.lblDateTitle = new System.Windows.Forms.Label();
            this.lblPrintoutsTitle = new System.Windows.Forms.Label();
            this.lblVendor = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblTotalPendingPrintouts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrintouts)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridOrders
            // 
            this.dataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrders.Location = new System.Drawing.Point(12, 45);
            this.dataGridOrders.Name = "dataGridOrders";
            this.dataGridOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOrders.Size = new System.Drawing.Size(467, 152);
            this.dataGridOrders.TabIndex = 1;
            this.dataGridOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOrders_CellClick);
            // 
            // dataGridPrintouts
            // 
            this.dataGridPrintouts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPrintouts.Location = new System.Drawing.Point(12, 236);
            this.dataGridPrintouts.Name = "dataGridPrintouts";
            this.dataGridPrintouts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPrintouts.Size = new System.Drawing.Size(904, 435);
            this.dataGridPrintouts.TabIndex = 2;
            this.dataGridPrintouts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPrintouts_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listado de ordenes pendientes de ingreso";
            // 
            // lblImpresionTitle
            // 
            this.lblImpresionTitle.AutoSize = true;
            this.lblImpresionTitle.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpresionTitle.Location = new System.Drawing.Point(7, 203);
            this.lblImpresionTitle.Name = "lblImpresionTitle";
            this.lblImpresionTitle.Size = new System.Drawing.Size(136, 30);
            this.lblImpresionTitle.TabIndex = 4;
            this.lblImpresionTitle.Text = "Impresiones";
            // 
            // btnImprimirTodo
            // 
            this.btnImprimirTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirTodo.Location = new System.Drawing.Point(922, 624);
            this.btnImprimirTodo.Name = "btnImprimirTodo";
            this.btnImprimirTodo.Size = new System.Drawing.Size(200, 47);
            this.btnImprimirTodo.TabIndex = 5;
            this.btnImprimirTodo.Text = "Imprimir todos los pendientes";
            this.btnImprimirTodo.UseVisualStyleBackColor = true;
            this.btnImprimirTodo.Click += new System.EventHandler(this.btnImprimirTodo_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(922, 583);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(200, 36);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // pbOrders
            // 
            this.pbOrders.Location = new System.Drawing.Point(12, 101);
            this.pbOrders.Name = "pbOrders";
            this.pbOrders.Size = new System.Drawing.Size(467, 23);
            this.pbOrders.TabIndex = 9;
            // 
            // pbPrintouts
            // 
            this.pbPrintouts.Location = new System.Drawing.Point(12, 361);
            this.pbPrintouts.Name = "pbPrintouts";
            this.pbPrintouts.Size = new System.Drawing.Size(904, 20);
            this.pbPrintouts.TabIndex = 10;
            this.pbPrintouts.Visible = false;
            // 
            // lblSkuTitle
            // 
            this.lblSkuTitle.AutoSize = true;
            this.lblSkuTitle.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkuTitle.Location = new System.Drawing.Point(919, 285);
            this.lblSkuTitle.Name = "lblSkuTitle";
            this.lblSkuTitle.Size = new System.Drawing.Size(35, 15);
            this.lblSkuTitle.TabIndex = 11;
            this.lblSkuTitle.Text = "SKU:";
            // 
            // lblSKU
            // 
            this.lblSKU.AutoSize = true;
            this.lblSKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSKU.Location = new System.Drawing.Point(919, 310);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Size = new System.Drawing.Size(75, 15);
            this.lblSKU.TabIndex = 12;
            this.lblSKU.Text = "-----------------";
            // 
            // lblQuantityTitle
            // 
            this.lblQuantityTitle.AutoSize = true;
            this.lblQuantityTitle.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityTitle.Location = new System.Drawing.Point(922, 540);
            this.lblQuantityTitle.Name = "lblQuantityTitle";
            this.lblQuantityTitle.Size = new System.Drawing.Size(67, 15);
            this.lblQuantityTitle.TabIndex = 13;
            this.lblQuantityTitle.Text = "Cantidad:";
            // 
            // lblDescriptionTitle
            // 
            this.lblDescriptionTitle.AutoSize = true;
            this.lblDescriptionTitle.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionTitle.Location = new System.Drawing.Point(919, 371);
            this.lblDescriptionTitle.Name = "lblDescriptionTitle";
            this.lblDescriptionTitle.Size = new System.Drawing.Size(84, 15);
            this.lblDescriptionTitle.TabIndex = 15;
            this.lblDescriptionTitle.Text = "Descripción:";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Enabled = false;
            this.rtxtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescription.Location = new System.Drawing.Point(922, 387);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(200, 146);
            this.rtxtDescription.TabIndex = 17;
            this.rtxtDescription.Text = "";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(922, 557);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(200, 22);
            this.txtQuantity.TabIndex = 18;
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTitle.Location = new System.Drawing.Point(919, 333);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(61, 15);
            this.lblNameTitle.TabIndex = 19;
            this.lblNameTitle.Text = "Nombre:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(922, 346);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 15);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "-----------------";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(916, 206);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(58, 13);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "-----------------";
            this.lblID.Visible = false;
            // 
            // cmbxLabelsType
            // 
            this.cmbxLabelsType.FormattingEnabled = true;
            this.cmbxLabelsType.Location = new System.Drawing.Point(922, 252);
            this.cmbxLabelsType.Name = "cmbxLabelsType";
            this.cmbxLabelsType.Size = new System.Drawing.Size(200, 21);
            this.cmbxLabelsType.TabIndex = 22;
            // 
            // lblLabelTitle
            // 
            this.lblLabelTitle.AutoSize = true;
            this.lblLabelTitle.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelTitle.Location = new System.Drawing.Point(919, 234);
            this.lblLabelTitle.Name = "lblLabelTitle";
            this.lblLabelTitle.Size = new System.Drawing.Size(62, 15);
            this.lblLabelTitle.TabIndex = 23;
            this.lblLabelTitle.Text = "Etiqueta:";
            // 
            // lblVendorTitle
            // 
            this.lblVendorTitle.AutoSize = true;
            this.lblVendorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendorTitle.Location = new System.Drawing.Point(485, 45);
            this.lblVendorTitle.Name = "lblVendorTitle";
            this.lblVendorTitle.Size = new System.Drawing.Size(118, 25);
            this.lblVendorTitle.TabIndex = 24;
            this.lblVendorTitle.Text = "Proveedor:";
            // 
            // lblDateTitle
            // 
            this.lblDateTitle.AutoSize = true;
            this.lblDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTitle.Location = new System.Drawing.Point(485, 85);
            this.lblDateTitle.Name = "lblDateTitle";
            this.lblDateTitle.Size = new System.Drawing.Size(79, 25);
            this.lblDateTitle.TabIndex = 25;
            this.lblDateTitle.Text = "Fecha:";
            // 
            // lblPrintoutsTitle
            // 
            this.lblPrintoutsTitle.AutoSize = true;
            this.lblPrintoutsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintoutsTitle.Location = new System.Drawing.Point(485, 122);
            this.lblPrintoutsTitle.Name = "lblPrintoutsTitle";
            this.lblPrintoutsTitle.Size = new System.Drawing.Size(248, 25);
            this.lblPrintoutsTitle.TabIndex = 26;
            this.lblPrintoutsTitle.Text = "Impresiones pendientes:";
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Font = new System.Drawing.Font("Noto Serif Armenian", 12F);
            this.lblVendor.Location = new System.Drawing.Point(746, 54);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(0, 22);
            this.lblVendor.TabIndex = 27;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Noto Serif Armenian", 12F);
            this.lblOrderDate.Location = new System.Drawing.Point(746, 94);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(0, 22);
            this.lblOrderDate.TabIndex = 28;
            // 
            // lblTotalPendingPrintouts
            // 
            this.lblTotalPendingPrintouts.AutoSize = true;
            this.lblTotalPendingPrintouts.Font = new System.Drawing.Font("Noto Serif Armenian", 12F);
            this.lblTotalPendingPrintouts.Location = new System.Drawing.Point(746, 134);
            this.lblTotalPendingPrintouts.Name = "lblTotalPendingPrintouts";
            this.lblTotalPendingPrintouts.Size = new System.Drawing.Size(0, 22);
            this.lblTotalPendingPrintouts.TabIndex = 29;
            // 
            // FrmPendingOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 677);
            this.Controls.Add(this.lblTotalPendingPrintouts);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblVendor);
            this.Controls.Add(this.lblPrintoutsTitle);
            this.Controls.Add(this.lblDateTitle);
            this.Controls.Add(this.lblVendorTitle);
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
            this.Controls.Add(this.pbPrintouts);
            this.Controls.Add(this.pbOrders);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnImprimirTodo);
            this.Controls.Add(this.lblImpresionTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridPrintouts);
            this.Controls.Add(this.dataGridOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPendingOrders";
            this.Text = "Ordenes de compra";
            this.Load += new System.EventHandler(this.FrmPendingOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrintouts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridOrders;
        private System.Windows.Forms.DataGridView dataGridPrintouts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblImpresionTitle;
        private System.Windows.Forms.Button btnImprimirTodo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ProgressBar pbOrders;
        private System.Windows.Forms.ProgressBar pbPrintouts;
        private System.Windows.Forms.Label lblSkuTitle;
        private System.Windows.Forms.Label lblSKU;
        private System.Windows.Forms.Label lblQuantityTitle;
        private System.Windows.Forms.Label lblDescriptionTitle;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cmbxLabelsType;
        private System.Windows.Forms.Label lblLabelTitle;
        private System.Windows.Forms.Label lblVendorTitle;
        private System.Windows.Forms.Label lblDateTitle;
        private System.Windows.Forms.Label lblPrintoutsTitle;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblTotalPendingPrintouts;
    }
}