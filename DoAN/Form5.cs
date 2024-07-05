using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAN
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNHANSUDataSet5.TAIKHOAN' table. You can move, or remove it, as needed.
            this.tAIKHOANTableAdapter.Fill(this.qLNHANSUDataSet5.TAIKHOAN);
            // TODO: This line of code loads data into the 'qLNHANSUDataSet4.BAOHIEM' table. You can move, or remove it, as needed.
            this.bAOHIEMTableAdapter.Fill(this.qLNHANSUDataSet4.BAOHIEM);

        }
    }
}
