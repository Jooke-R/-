using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 虚拟开箱系统
{
    public partial class OpenBox : Form
    {
        SqlCommand sqlCmd = new SqlCommand();
        Goto Goto = new Goto();
        public OpenBox()
        {
            InitializeComponent();
        }

        private void buttonMarket_Click(object sender, EventArgs e)
        {
            Goto.GotoMarket();
            this.Hide();
        }

        private void OpenBox_Load(object sender, EventArgs e)
        {
            sqlCmd.Connection = Goto.sqlCon;
        }

        private void buttonItem_Click(object sender, EventArgs e)
        {
            Goto.GotoUserInfo();
            this.Hide();
        }

        private void buttonCharge_Click(object sender, EventArgs e)
        {
            Goto.GotoCharge();
            this.Hide();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Goto.GotoChooseBox();
            this.Hide();
        }
    }
}
