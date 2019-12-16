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
using System.Text.RegularExpressions;

namespace 虚拟开箱系统
{
    public partial class Sale : Form
    {
        SqlCommand sqlCmd = new SqlCommand();
        private Goto Goto = new Goto();
        Regex Rg = new Regex("^[0-9]+$");
        public Sale()
        {
            InitializeComponent();
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            //Goto.GotoUserInfo();
            this.Close();
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            sqlCmd.Connection = Goto.sqlCon;
            labelName2.Text = UserInfo.item[0];
            textBoxPrice.Text = UserInfo.item[1];
            string Name = UserInfo.item[0];
            this.pictureBox1.ImageLocation = "img\\" + Name + ".png";
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            if(textBoxPrice.Text=="")
            {
                MessageBox.Show("还未填写上架价格","警告",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else
            {
                if(double.TryParse(textBoxPrice.Text, out double Price) && Convert.ToInt32(textBoxPrice.Text)>0)
                {
                    sqlCmd.CommandText = "update item set item_price='" + textBoxPrice.Text + "',item_state='1' where item_id='" + UserInfo.item[2] + "'";
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("上架成功！", "上架提示");
                    //Goto.GotoUserInfo();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("请输入正确的价格","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    textBoxPrice.Text = "";
                }
            }
        }
    }
}
