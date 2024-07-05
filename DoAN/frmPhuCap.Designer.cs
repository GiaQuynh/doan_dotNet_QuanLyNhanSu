namespace DoAN
{
    partial class frmPhuCap
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttenpc = new System.Windows.Forms.TextBox();
            this.txtmapc = new System.Windows.Forms.TextBox();
            this.qLNHANSUDataSet1 = new DoAN.QLNHANSUDataSet1();
            this.cHUCVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHUCVUTableAdapter = new DoAN.QLNHANSUDataSet1TableAdapters.CHUCVUTableAdapter();
            this.txttienpc = new System.Windows.Forms.TextBox();
            this.dgv_PhuCap = new System.Windows.Forms.DataGridView();
            this.mAPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIENPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHUCAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNHANSUDataSet3 = new DoAN.QLNHANSUDataSet3();
            this.pHUCAPTableAdapter = new DoAN.QLNHANSUDataSet3TableAdapters.PHUCAPTableAdapter();
            this.btn_Moi = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhuCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUCAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã PC";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(151, 109);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(84, 29);
            this.btnthem.TabIndex = 14;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(316, 109);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(84, 29);
            this.btnxoa.TabIndex = 15;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(446, 109);
            this.btnsua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(84, 29);
            this.btnsua.TabIndex = 16;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(682, 109);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(84, 29);
            this.btnthoat.TabIndex = 17;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên PC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tiền PC";
            // 
            // txttenpc
            // 
            this.txttenpc.Location = new System.Drawing.Point(226, 240);
            this.txttenpc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttenpc.Name = "txttenpc";
            this.txttenpc.Size = new System.Drawing.Size(216, 26);
            this.txttenpc.TabIndex = 25;
            // 
            // txtmapc
            // 
            this.txtmapc.Location = new System.Drawing.Point(226, 184);
            this.txtmapc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmapc.Name = "txtmapc";
            this.txtmapc.Size = new System.Drawing.Size(216, 26);
            this.txtmapc.TabIndex = 24;
            // 
            // qLNHANSUDataSet1
            // 
            this.qLNHANSUDataSet1.DataSetName = "QLNHANSUDataSet1";
            this.qLNHANSUDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cHUCVUBindingSource
            // 
            this.cHUCVUBindingSource.DataMember = "CHUCVU";
            this.cHUCVUBindingSource.DataSource = this.qLNHANSUDataSet1;
            // 
            // cHUCVUTableAdapter
            // 
            this.cHUCVUTableAdapter.ClearBeforeFill = true;
            // 
            // txttienpc
            // 
            this.txttienpc.Location = new System.Drawing.Point(567, 184);
            this.txttienpc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttienpc.Name = "txttienpc";
            this.txttienpc.Size = new System.Drawing.Size(199, 26);
            this.txttienpc.TabIndex = 22;
            // 
            // dgv_PhuCap
            // 
            this.dgv_PhuCap.AutoGenerateColumns = false;
            this.dgv_PhuCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhuCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAPCDataGridViewTextBoxColumn,
            this.tENPCDataGridViewTextBoxColumn,
            this.tIENPCDataGridViewTextBoxColumn});
            this.dgv_PhuCap.DataSource = this.pHUCAPBindingSource;
            this.dgv_PhuCap.Location = new System.Drawing.Point(151, 319);
            this.dgv_PhuCap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_PhuCap.Name = "dgv_PhuCap";
            this.dgv_PhuCap.RowHeadersWidth = 51;
            this.dgv_PhuCap.RowTemplate.Height = 24;
            this.dgv_PhuCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PhuCap.Size = new System.Drawing.Size(615, 214);
            this.dgv_PhuCap.TabIndex = 26;
            this.dgv_PhuCap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhuCap_CellContentClick);
            // 
            // mAPCDataGridViewTextBoxColumn
            // 
            this.mAPCDataGridViewTextBoxColumn.DataPropertyName = "MAPC";
            this.mAPCDataGridViewTextBoxColumn.HeaderText = "MAPC";
            this.mAPCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAPCDataGridViewTextBoxColumn.Name = "mAPCDataGridViewTextBoxColumn";
            this.mAPCDataGridViewTextBoxColumn.Width = 125;
            // 
            // tENPCDataGridViewTextBoxColumn
            // 
            this.tENPCDataGridViewTextBoxColumn.DataPropertyName = "TENPC";
            this.tENPCDataGridViewTextBoxColumn.HeaderText = "TENPC";
            this.tENPCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENPCDataGridViewTextBoxColumn.Name = "tENPCDataGridViewTextBoxColumn";
            this.tENPCDataGridViewTextBoxColumn.Width = 125;
            // 
            // tIENPCDataGridViewTextBoxColumn
            // 
            this.tIENPCDataGridViewTextBoxColumn.DataPropertyName = "TIENPC";
            this.tIENPCDataGridViewTextBoxColumn.HeaderText = "TIENPC";
            this.tIENPCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tIENPCDataGridViewTextBoxColumn.Name = "tIENPCDataGridViewTextBoxColumn";
            this.tIENPCDataGridViewTextBoxColumn.Width = 125;
            // 
            // pHUCAPBindingSource
            // 
            this.pHUCAPBindingSource.DataMember = "PHUCAP";
            this.pHUCAPBindingSource.DataSource = this.qLNHANSUDataSet3;
            // 
            // qLNHANSUDataSet3
            // 
            this.qLNHANSUDataSet3.DataSetName = "QLNHANSUDataSet3";
            this.qLNHANSUDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHUCAPTableAdapter
            // 
            this.pHUCAPTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Moi
            // 
            this.btn_Moi.Location = new System.Drawing.Point(567, 109);
            this.btn_Moi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Moi.Name = "btn_Moi";
            this.btn_Moi.Size = new System.Drawing.Size(84, 29);
            this.btn_Moi.TabIndex = 27;
            this.btn_Moi.Text = "Mới";
            this.btn_Moi.UseVisualStyleBackColor = true;
            this.btn_Moi.Click += new System.EventHandler(this.btn_Moi_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(351, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 37);
            this.label12.TabIndex = 41;
            this.label12.Text = "Phụ Cấp";
            // 
            // frmPhuCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_Moi);
            this.Controls.Add(this.dgv_PhuCap);
            this.Controls.Add(this.txttenpc);
            this.Controls.Add(this.txttienpc);
            this.Controls.Add(this.txtmapc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPhuCap";
            this.Text = "FrPC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhuCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUCAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttenpc;
        private System.Windows.Forms.TextBox txtmapc;
        private QLNHANSUDataSet1 qLNHANSUDataSet1;
        private System.Windows.Forms.BindingSource cHUCVUBindingSource;
        private QLNHANSUDataSet1TableAdapters.CHUCVUTableAdapter cHUCVUTableAdapter;
        private System.Windows.Forms.TextBox txttienpc;
        private System.Windows.Forms.DataGridView dgv_PhuCap;
        private QLNHANSUDataSet3 qLNHANSUDataSet3;
        private System.Windows.Forms.BindingSource pHUCAPBindingSource;
        private QLNHANSUDataSet3TableAdapters.PHUCAPTableAdapter pHUCAPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAPCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENPCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIENPCDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Moi;
        private System.Windows.Forms.Label label12;
    }
}