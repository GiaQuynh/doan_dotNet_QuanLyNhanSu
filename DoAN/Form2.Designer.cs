namespace DoAN
{
    partial class Form2
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
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qLNHANSUDataSet1 = new DoAN.QLNHANSUDataSet1();
            this.cHUCVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHUCVUTableAdapter = new DoAN.QLNHANSUDataSet1TableAdapters.CHUCVUTableAdapter();
            this.mACVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bACLUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lUONGCBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbacluong = new System.Windows.Forms.TextBox();
            this.txtluongcb = new System.Windows.Forms.TextBox();
            this.txtmacv = new System.Windows.Forms.TextBox();
            this.txttencv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã CV";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(66, 35);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(213, 35);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(377, 35);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 3;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(538, 35);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên CV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bậc lương";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lương CB";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mACVDataGridViewTextBoxColumn,
            this.tENCNDataGridViewTextBoxColumn,
            this.bACLUONGDataGridViewTextBoxColumn,
            this.lUONGCBDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cHUCVUBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(66, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(547, 243);
            this.dataGridView1.TabIndex = 8;
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
            // mACVDataGridViewTextBoxColumn
            // 
            this.mACVDataGridViewTextBoxColumn.DataPropertyName = "MACV";
            this.mACVDataGridViewTextBoxColumn.HeaderText = "MACV";
            this.mACVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mACVDataGridViewTextBoxColumn.Name = "mACVDataGridViewTextBoxColumn";
            this.mACVDataGridViewTextBoxColumn.Width = 125;
            // 
            // tENCNDataGridViewTextBoxColumn
            // 
            this.tENCNDataGridViewTextBoxColumn.DataPropertyName = "TENCN";
            this.tENCNDataGridViewTextBoxColumn.HeaderText = "TENCN";
            this.tENCNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENCNDataGridViewTextBoxColumn.Name = "tENCNDataGridViewTextBoxColumn";
            this.tENCNDataGridViewTextBoxColumn.Width = 125;
            // 
            // bACLUONGDataGridViewTextBoxColumn
            // 
            this.bACLUONGDataGridViewTextBoxColumn.DataPropertyName = "BACLUONG";
            this.bACLUONGDataGridViewTextBoxColumn.HeaderText = "BACLUONG";
            this.bACLUONGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bACLUONGDataGridViewTextBoxColumn.Name = "bACLUONGDataGridViewTextBoxColumn";
            this.bACLUONGDataGridViewTextBoxColumn.Width = 125;
            // 
            // lUONGCBDataGridViewTextBoxColumn
            // 
            this.lUONGCBDataGridViewTextBoxColumn.DataPropertyName = "LUONGCB";
            this.lUONGCBDataGridViewTextBoxColumn.HeaderText = "LUONGCB";
            this.lUONGCBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lUONGCBDataGridViewTextBoxColumn.Name = "lUONGCBDataGridViewTextBoxColumn";
            this.lUONGCBDataGridViewTextBoxColumn.Width = 125;
            // 
            // txtbacluong
            // 
            this.txtbacluong.Location = new System.Drawing.Point(436, 95);
            this.txtbacluong.Name = "txtbacluong";
            this.txtbacluong.Size = new System.Drawing.Size(177, 22);
            this.txtbacluong.TabIndex = 9;
            // 
            // txtluongcb
            // 
            this.txtluongcb.Location = new System.Drawing.Point(436, 137);
            this.txtluongcb.Name = "txtluongcb";
            this.txtluongcb.Size = new System.Drawing.Size(177, 22);
            this.txtluongcb.TabIndex = 10;
            // 
            // txtmacv
            // 
            this.txtmacv.Location = new System.Drawing.Point(133, 95);
            this.txtmacv.Name = "txtmacv";
            this.txtmacv.Size = new System.Drawing.Size(192, 22);
            this.txtmacv.TabIndex = 11;
            // 
            // txttencv
            // 
            this.txttencv.Location = new System.Drawing.Point(133, 140);
            this.txttencv.Name = "txttencv";
            this.txttencv.Size = new System.Drawing.Size(192, 22);
            this.txttencv.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.txttencv);
            this.Controls.Add(this.txtmacv);
            this.Controls.Add(this.txtluongcb);
            this.Controls.Add(this.txtbacluong);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "FrCVPB";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANSUDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLNHANSUDataSet1 qLNHANSUDataSet1;
        private System.Windows.Forms.BindingSource cHUCVUBindingSource;
        private QLNHANSUDataSet1TableAdapters.CHUCVUTableAdapter cHUCVUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mACVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bACLUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lUONGCBDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtbacluong;
        private System.Windows.Forms.TextBox txtluongcb;
        private System.Windows.Forms.TextBox txtmacv;
        private System.Windows.Forms.TextBox txttencv;
    }
}