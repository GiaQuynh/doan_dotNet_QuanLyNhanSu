namespace DoAN
{
    partial class Form5
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
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.txtquyen = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.cHUCVUTableAdapter = new DoAN.QLNHANSUDataSet1TableAdapters.CHUCVUTableAdapter();
            this.cHUCVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNHANSUDataSet1 = new DoAN.QLNHANSUDataSet1();
            this.txtmatk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.qLNHANSUDataSet4 = new DoAN.QLNHANSUDataSet4();
            this.bAOHIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAOHIEMTableAdapter = new DoAN.QLNHANSUDataSet4TableAdapters.BAOHIEMTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qLNHANSUDataSet5 = new DoAN.QLNHANSUDataSet5();
            this.tAIKHOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAIKHOANTableAdapter = new DoAN.QLNHANSUDataSet5TableAdapters.TAIKHOANTableAdapter();
            this.mATKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAIKHOANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATKHAUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUYENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOHIEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(195, 129);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(192, 22);
            this.txtmanv.TabIndex = 25;
            // 
            // txtquyen
            // 
            this.txtquyen.Location = new System.Drawing.Point(498, 126);
            this.txtquyen.Name = "txtquyen";
            this.txtquyen.Size = new System.Drawing.Size(177, 22);
            this.txtquyen.TabIndex = 23;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(498, 84);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(177, 22);
            this.txtmatkhau.TabIndex = 22;
            // 
            // cHUCVUTableAdapter
            // 
            this.cHUCVUTableAdapter.ClearBeforeFill = true;
            // 
            // cHUCVUBindingSource
            // 
            this.cHUCVUBindingSource.DataMember = "CHUCVU";
            this.cHUCVUBindingSource.DataSource = this.qLNHANSUDataSet1;
            // 
            // qLNHANSUDataSet1
            // 
            this.qLNHANSUDataSet1.DataSetName = "QLNHANSUDataSet1";
            this.qLNHANSUDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtmatk
            // 
            this.txtmatk.Location = new System.Drawing.Point(195, 84);
            this.txtmatk.Name = "txtmatk";
            this.txtmatk.Size = new System.Drawing.Size(192, 22);
            this.txtmatk.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Quyền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã NV";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(600, 24);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 17;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(439, 24);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 16;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(275, 24);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 15;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(128, 24);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 14;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã TK";
            // 
            // qLNHANSUDataSet4
            // 
            this.qLNHANSUDataSet4.DataSetName = "QLNHANSUDataSet4";
            this.qLNHANSUDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bAOHIEMBindingSource
            // 
            this.bAOHIEMBindingSource.DataMember = "BAOHIEM";
            this.bAOHIEMBindingSource.DataSource = this.qLNHANSUDataSet4;
            // 
            // bAOHIEMTableAdapter
            // 
            this.bAOHIEMTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mATKDataGridViewTextBoxColumn,
            this.mANVDataGridViewTextBoxColumn,
            this.tAIKHOANDataGridViewTextBoxColumn,
            this.mATKHAUDataGridViewTextBoxColumn,
            this.qUYENDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tAIKHOANBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(128, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(547, 150);
            this.dataGridView1.TabIndex = 26;
            // 
            // qLNHANSUDataSet5
            // 
            this.qLNHANSUDataSet5.DataSetName = "QLNHANSUDataSet5";
            this.qLNHANSUDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAIKHOANBindingSource
            // 
            this.tAIKHOANBindingSource.DataMember = "TAIKHOAN";
            this.tAIKHOANBindingSource.DataSource = this.qLNHANSUDataSet5;
            // 
            // tAIKHOANTableAdapter
            // 
            this.tAIKHOANTableAdapter.ClearBeforeFill = true;
            // 
            // mATKDataGridViewTextBoxColumn
            // 
            this.mATKDataGridViewTextBoxColumn.DataPropertyName = "MATK";
            this.mATKDataGridViewTextBoxColumn.HeaderText = "MATK";
            this.mATKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mATKDataGridViewTextBoxColumn.Name = "mATKDataGridViewTextBoxColumn";
            this.mATKDataGridViewTextBoxColumn.Width = 125;
            // 
            // mANVDataGridViewTextBoxColumn
            // 
            this.mANVDataGridViewTextBoxColumn.DataPropertyName = "MANV";
            this.mANVDataGridViewTextBoxColumn.HeaderText = "MANV";
            this.mANVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mANVDataGridViewTextBoxColumn.Name = "mANVDataGridViewTextBoxColumn";
            this.mANVDataGridViewTextBoxColumn.Width = 125;
            // 
            // tAIKHOANDataGridViewTextBoxColumn
            // 
            this.tAIKHOANDataGridViewTextBoxColumn.DataPropertyName = "TAIKHOAN";
            this.tAIKHOANDataGridViewTextBoxColumn.HeaderText = "TAIKHOAN";
            this.tAIKHOANDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tAIKHOANDataGridViewTextBoxColumn.Name = "tAIKHOANDataGridViewTextBoxColumn";
            this.tAIKHOANDataGridViewTextBoxColumn.Width = 125;
            // 
            // mATKHAUDataGridViewTextBoxColumn
            // 
            this.mATKHAUDataGridViewTextBoxColumn.DataPropertyName = "MATKHAU";
            this.mATKHAUDataGridViewTextBoxColumn.HeaderText = "MATKHAU";
            this.mATKHAUDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mATKHAUDataGridViewTextBoxColumn.Name = "mATKHAUDataGridViewTextBoxColumn";
            this.mATKHAUDataGridViewTextBoxColumn.Width = 125;
            // 
            // qUYENDataGridViewTextBoxColumn
            // 
            this.qUYENDataGridViewTextBoxColumn.DataPropertyName = "QUYEN";
            this.qUYENDataGridViewTextBoxColumn.HeaderText = "QUYEN";
            this.qUYENDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qUYENDataGridViewTextBoxColumn.Name = "qUYENDataGridViewTextBoxColumn";
            this.qUYENDataGridViewTextBoxColumn.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tài khoản";
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Location = new System.Drawing.Point(195, 171);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(192, 22);
            this.txttaikhoan.TabIndex = 28;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttaikhoan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.txtquyen);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txtmatk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "FrTK";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOHIEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.TextBox txtquyen;
        private System.Windows.Forms.TextBox txtmatkhau;
        private QLNHANSUDataSet1TableAdapters.CHUCVUTableAdapter cHUCVUTableAdapter;
        private System.Windows.Forms.BindingSource cHUCVUBindingSource;
        private QLNHANSUDataSet1 qLNHANSUDataSet1;
        private System.Windows.Forms.TextBox txtmatk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label1;
        private QLNHANSUDataSet4 qLNHANSUDataSet4;
        private System.Windows.Forms.BindingSource bAOHIEMBindingSource;
        private QLNHANSUDataSet4TableAdapters.BAOHIEMTableAdapter bAOHIEMTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLNHANSUDataSet5 qLNHANSUDataSet5;
        private System.Windows.Forms.BindingSource tAIKHOANBindingSource;
        private QLNHANSUDataSet5TableAdapters.TAIKHOANTableAdapter tAIKHOANTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAIKHOANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATKHAUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUYENDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttaikhoan;
    }
}