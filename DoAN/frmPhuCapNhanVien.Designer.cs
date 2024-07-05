namespace DoAN
{
    partial class frmPhuCapNhanVien
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
            this.label12 = new System.Windows.Forms.Label();
            this.txttenpc = new System.Windows.Forms.TextBox();
            this.txttienpc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.cbomapc = new System.Windows.Forms.ComboBox();
            this.dgv_PhuCap = new System.Windows.Forms.DataGridView();
            this.pPhuCapNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLiNhanSu_Nhom2DataSet = new DoAN.QuanLiNhanSu_Nhom2DataSet();
            this.getEmployeeWithAllowanceTableAdapter = new DoAN.QuanLiNhanSu_Nhom2DataSetTableAdapters.GetEmployeeWithAllowanceTableAdapter();
            this.mANVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENVNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhuCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPhuCapNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiNhanSu_Nhom2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(397, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(319, 37);
            this.label12.TabIndex = 54;
            this.label12.Text = "Phụ Cấp Nhân Viên";
            // 
            // txttenpc
            // 
            this.txttenpc.Location = new System.Drawing.Point(478, 181);
            this.txttenpc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttenpc.Name = "txttenpc";
            this.txttenpc.Size = new System.Drawing.Size(216, 26);
            this.txttenpc.TabIndex = 51;
            // 
            // txttienpc
            // 
            this.txttienpc.Location = new System.Drawing.Point(753, 178);
            this.txttienpc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttienpc.Name = "txttienpc";
            this.txttienpc.Size = new System.Drawing.Size(199, 26);
            this.txttienpc.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(749, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Tổng Tiền PC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Tên PC";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(558, 264);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(84, 29);
            this.btnthoat.TabIndex = 46;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(468, 264);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(84, 29);
            this.btnxoa.TabIndex = 44;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(378, 264);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(84, 29);
            this.btnthem.TabIndex = 43;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Mã PC";
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(180, 181);
            this.txttennv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(168, 26);
            this.txttennv.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Tên NV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Mã NV";
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(180, 129);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(168, 26);
            this.txtmanv.TabIndex = 55;
            // 
            // cbomapc
            // 
            this.cbomapc.FormattingEnabled = true;
            this.cbomapc.Location = new System.Drawing.Point(478, 123);
            this.cbomapc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbomapc.Name = "cbomapc";
            this.cbomapc.Size = new System.Drawing.Size(216, 28);
            this.cbomapc.TabIndex = 59;
            this.cbomapc.SelectedIndexChanged += new System.EventHandler(this.cbomapc_SelectedIndexChanged);
            // 
            // dgv_PhuCap
            // 
            this.dgv_PhuCap.AutoGenerateColumns = false;
            this.dgv_PhuCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhuCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mANVDataGridViewTextBoxColumn,
            this.tENVNDataGridViewTextBoxColumn,
            this.mAPCDataGridViewTextBoxColumn,
            this.tENPCDataGridViewTextBoxColumn});
            this.dgv_PhuCap.DataSource = this.pPhuCapNhanVienBindingSource;
            this.dgv_PhuCap.Location = new System.Drawing.Point(78, 336);
            this.dgv_PhuCap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_PhuCap.Name = "dgv_PhuCap";
            this.dgv_PhuCap.RowHeadersWidth = 51;
            this.dgv_PhuCap.RowTemplate.Height = 24;
            this.dgv_PhuCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PhuCap.Size = new System.Drawing.Size(959, 298);
            this.dgv_PhuCap.TabIndex = 52;
            this.dgv_PhuCap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhuCap_CellContentClick);
            // 
            // pPhuCapNhanVienBindingSource
            // 
            this.pPhuCapNhanVienBindingSource.DataMember = "GetEmployeeWithAllowance";
            this.pPhuCapNhanVienBindingSource.DataSource = this.quanLiNhanSu_Nhom2DataSet;
            // 
            // quanLiNhanSu_Nhom2DataSet
            // 
            this.quanLiNhanSu_Nhom2DataSet.DataSetName = "QuanLiNhanSu_Nhom2DataSet";
            this.quanLiNhanSu_Nhom2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getEmployeeWithAllowanceTableAdapter
            // 
            this.getEmployeeWithAllowanceTableAdapter.ClearBeforeFill = true;
            // 
            // mANVDataGridViewTextBoxColumn
            // 
            this.mANVDataGridViewTextBoxColumn.DataPropertyName = "MANV";
            this.mANVDataGridViewTextBoxColumn.HeaderText = "MANV";
            this.mANVDataGridViewTextBoxColumn.Name = "mANVDataGridViewTextBoxColumn";
            // 
            // tENVNDataGridViewTextBoxColumn
            // 
            this.tENVNDataGridViewTextBoxColumn.DataPropertyName = "TENVN";
            this.tENVNDataGridViewTextBoxColumn.HeaderText = "TENVN";
            this.tENVNDataGridViewTextBoxColumn.Name = "tENVNDataGridViewTextBoxColumn";
            this.tENVNDataGridViewTextBoxColumn.Width = 200;
            // 
            // mAPCDataGridViewTextBoxColumn
            // 
            this.mAPCDataGridViewTextBoxColumn.DataPropertyName = "MAPC";
            this.mAPCDataGridViewTextBoxColumn.HeaderText = "MAPC";
            this.mAPCDataGridViewTextBoxColumn.Name = "mAPCDataGridViewTextBoxColumn";
            // 
            // tENPCDataGridViewTextBoxColumn
            // 
            this.tENPCDataGridViewTextBoxColumn.DataPropertyName = "TENPC";
            this.tENPCDataGridViewTextBoxColumn.HeaderText = "TENPC";
            this.tENPCDataGridViewTextBoxColumn.Name = "tENPCDataGridViewTextBoxColumn";
            this.tENPCDataGridViewTextBoxColumn.Width = 200;
            // 
            // frmPhuCapNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 647);
            this.Controls.Add(this.cbomapc);
            this.Controls.Add(this.txttennv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgv_PhuCap);
            this.Controls.Add(this.txttenpc);
            this.Controls.Add(this.txttienpc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label1);
            this.Name = "frmPhuCapNhanVien";
            this.Text = "frmPhuCapNhanVien";
            this.Load += new System.EventHandler(this.frmPhuCapNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhuCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPhuCapNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiNhanSu_Nhom2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txttenpc;
        private System.Windows.Forms.TextBox txttienpc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.ComboBox cbomapc;
        private System.Windows.Forms.DataGridView dgv_PhuCap;
        private System.Windows.Forms.BindingSource pPhuCapNhanVienBindingSource;
        private QuanLiNhanSu_Nhom2DataSet quanLiNhanSu_Nhom2DataSet;
        private QuanLiNhanSu_Nhom2DataSetTableAdapters.GetEmployeeWithAllowanceTableAdapter getEmployeeWithAllowanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENVNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAPCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENPCDataGridViewTextBoxColumn;
    }
}