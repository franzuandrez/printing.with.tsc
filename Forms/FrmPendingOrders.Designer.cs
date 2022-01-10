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
            this.label2 = new System.Windows.Forms.Label();
            this.btnImprimirTodo = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.pbOrders = new System.Windows.Forms.ProgressBar();
            this.pbPrintouts = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSKU = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.cmbxLabelsType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.dataGridOrders.Location = new System.Drawing.Point(17, 50);
            this.dataGridOrders.Name = "dataGridOrders";
            this.dataGridOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOrders.Size = new System.Drawing.Size(467, 152);
            this.dataGridOrders.TabIndex = 1;
            this.dataGridOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOrders_CellClick);
            // 
            // dataGridPrintouts
            // 
            this.dataGridPrintouts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPrintouts.Location = new System.Drawing.Point(17, 241);
            this.dataGridPrintouts.Name = "dataGridPrintouts";
            this.dataGridPrintouts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPrintouts.Size = new System.Drawing.Size(946, 465);
            this.dataGridPrintouts.TabIndex = 2;
            this.dataGridPrintouts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPrintouts_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listado de ordenes pendientes de ingreso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Impresiones";
            // 
            // btnImprimirTodo
            // 
            this.btnImprimirTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirTodo.Location = new System.Drawing.Point(969, 659);
            this.btnImprimirTodo.Name = "btnImprimirTodo";
            this.btnImprimirTodo.Size = new System.Drawing.Size(200, 47);
            this.btnImprimirTodo.TabIndex = 5;
            this.btnImprimirTodo.Text = "Imprimir todos los pendientes";
            this.btnImprimirTodo.UseVisualStyleBackColor = true;
            this.btnImprimirTodo.Click += new System.EventHandler(this.btnImprimirTodo_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(969, 618);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(200, 36);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // pbOrders
            // 
            this.pbOrders.Location = new System.Drawing.Point(17, 106);
            this.pbOrders.Name = "pbOrders";
            this.pbOrders.Size = new System.Drawing.Size(467, 23);
            this.pbOrders.TabIndex = 9;
            // 
            // pbPrintouts
            // 
            this.pbPrintouts.Location = new System.Drawing.Point(17, 366);
            this.pbPrintouts.Name = "pbPrintouts";
            this.pbPrintouts.Size = new System.Drawing.Size(946, 20);
            this.pbPrintouts.TabIndex = 10;
            this.pbPrintouts.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(966, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "SKU:";
            // 
            // lblSKU
            // 
            this.lblSKU.AutoSize = true;
            this.lblSKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSKU.Location = new System.Drawing.Point(966, 317);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Size = new System.Drawing.Size(75, 15);
            this.lblSKU.TabIndex = 12;
            this.lblSKU.Text = "-----------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(969, 575);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cantidad:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(966, 378);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(84, 15);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "Descripción:";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Enabled = false;
            this.rtxtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescription.Location = new System.Drawing.Point(969, 394);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(200, 168);
            this.rtxtDescription.TabIndex = 17;
            this.rtxtDescription.Text = "";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(969, 592);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(200, 22);
            this.txtQuantity.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(966, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nombre:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(969, 353);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 15);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "-----------------";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(963, 213);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(58, 13);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "-----------------";
            this.lblID.Visible = false;
            // 
            // cmbxLabelsType
            // 
            this.cmbxLabelsType.FormattingEnabled = true;
            this.cmbxLabelsType.Location = new System.Drawing.Point(969, 259);
            this.cmbxLabelsType.Name = "cmbxLabelsType";
            this.cmbxLabelsType.Size = new System.Drawing.Size(200, 21);
            this.cmbxLabelsType.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(966, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Etiqueta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(490, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Proveedor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(490, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Fecha:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(490, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(248, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Impresiones pendientes:";
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Font = new System.Drawing.Font("Noto Serif Armenian", 12F);
            this.lblVendor.Location = new System.Drawing.Point(751, 59);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(0, 22);
            this.lblVendor.TabIndex = 27;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Noto Serif Armenian", 12F);
            this.lblOrderDate.Location = new System.Drawing.Point(751, 99);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(0, 22);
            this.lblOrderDate.TabIndex = 28;
            // 
            // lblTotalPendingPrintouts
            // 
            this.lblTotalPendingPrintouts.AutoSize = true;
            this.lblTotalPendingPrintouts.Font = new System.Drawing.Font("Noto Serif Armenian", 12F);
            this.lblTotalPendingPrintouts.Location = new System.Drawing.Point(751, 139);
            this.lblTotalPendingPrintouts.Name = "lblTotalPendingPrintouts";
            this.lblTotalPendingPrintouts.Size = new System.Drawing.Size(0, 22);
            this.lblTotalPendingPrintouts.TabIndex = 29;
            // 
            // FrmPendingOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 762);
            this.Controls.Add(this.lblTotalPendingPrintouts);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblVendor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbxLabelsType);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSKU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbPrintouts);
            this.Controls.Add(this.pbOrders);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnImprimirTodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridPrintouts);
            this.Controls.Add(this.dataGridOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPendingOrders";
            this.Text = "PendingOrders";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImprimirTodo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ProgressBar pbOrders;
        private System.Windows.Forms.ProgressBar pbPrintouts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSKU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cmbxLabelsType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblTotalPendingPrintouts;
    }
}