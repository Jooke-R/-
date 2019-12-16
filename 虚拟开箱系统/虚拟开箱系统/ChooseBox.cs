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
    public partial class ChooseBox : Form
    {
        SqlCommand sqlCmd = new SqlCommand();
        Goto Goto = new Goto();
        public ChooseBox()
        {
            InitializeComponent();
        }
        private void ItemGet(int typeid,int color,int level,double money_left)
        {
            money_left -= 500;
            sqlCmd.CommandText = "update Regist set remain = '"+ money_left + "' where num='"+Login.Num+"'";
            sqlCmd.ExecuteNonQuery();
            sqlCmd.CommandText = "insert into item values ('" + typeid + "','" + Login.Num + "','"+color+"','"+level+"','0','0')";
            sqlCmd.ExecuteNonQuery();
            string [] id = new string[3];
            sqlCmd.CommandText = "select item_typename,item_colorname,item_level from item_type where item_typeid='"+typeid+ "'and item_color='"+color+"'";
            SqlDataReader sqlDr = sqlCmd.ExecuteReader();
            while(sqlDr.Read())
            {
                id[0] = sqlDr[0].ToString();
                id[1] = sqlDr[1].ToString();
                id[2] = sqlDr[2].ToString();
            }
            sqlDr.Close();
            DialogResult result = MessageBox.Show("恭喜您开出"+"--"+id[0]+id[1]+"-- "+"\n现在前去库存查看吗？", "恭喜！", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Goto.GotoUserInfo();
                this.Hide();
            }
                //MessageBox.Show("yes");
        }

        private void ChooseBox_Load(object sender, EventArgs e)
        {
            sqlCmd.Connection = Goto.sqlCon;
            pictureBox1.ImageLocation = ("img\\幻影武器箱.jpg");
            pictureBox2.ImageLocation = ("img\\光谱武器箱.jpg");
            pictureBox3.ImageLocation = ("img\\狩猎武器箱.jpg");
            pictureBox4.ImageLocation = ("img\\突围武器箱.jpg");
        }

        private void buttonOpenBox_Click(object sender, EventArgs e)
        {
            Goto.GotoOpenBox();
            this.Hide();
        }

        private void buttonBox1_Click(object sender, EventArgs e)
        {
            double money_left = 0;
            sqlCmd.CommandText = "select remain from Regist where num = '"+Login.Num+"'";
            //SqlCommand command = new SqlCommand(sql, DataOperator.connection);
            money_left = Convert.ToDouble(sqlCmd.ExecuteScalar());
            if (money_left >= 500)
            {
                Random ran = new Random();
                int num = ran.Next(1, 100);
                if (num < 20)
                {
                    ItemGet(13,1,1, money_left);
                }
                else if (num < 35)
                {
                    ItemGet(5,1,1, money_left);
                }
                else if (num < 50)
                {
                    ItemGet(5, 3, 2, money_left);
                }
                else if (num < 75)
                {
                    ItemGet(13, 2, 2, money_left);
                }
                else if (num < 80)
                {
                    ItemGet(13, 3, 2, money_left);
                }
                else if (num < 85)
                {
                    ItemGet(13, 4, 2, money_left);
                }
                else if (num < 88)
                {
                    ItemGet(5, 4, 2, money_left);
                }
                else if (num < 91)
                {
                    ItemGet(5, 2, 3, money_left);
                }
                else if (num < 93)
                {
                    ItemGet(9, 1, 2, money_left);
                }
                else if (num < 95)
                {
                    ItemGet(9,2,3, money_left);
                }
                else if (num < 96)
                {
                    ItemGet(9,3,3, money_left);
                }
                else if (num < 97)
                {
                    ItemGet(1,1,3, money_left);
                }
                else if (num < 98)
                {
                    ItemGet(1,2,4, money_left);
                }
                else if (num < 99)
                {
                    ItemGet(1,3,4, money_left);
                }
                else if (num < 100)
                {
                    ItemGet(1,4,4, money_left);
                }
                else if (num < 101)
                {
                    ItemGet(9,4,4, money_left);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("您的余额不足\n现在前去充值吗？", "余额不足！", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Goto.GotoCharge();
                    this.Hide();
                }
            }
        }

        private void buttonBox2_Click(object sender, EventArgs e)
        {
            double money_left = 0;
            sqlCmd.CommandText = "select remain from Regist where num = '" + Login.Num + "'";
            //SqlCommand command = new SqlCommand(sql, DataOperator.connection);
            money_left = Convert.ToDouble(sqlCmd.ExecuteScalar());
            if (money_left >= 500)
            {
                Random ran = new Random();
                int num = ran.Next(1, 100);
                if (num < 30)
                {
                    ItemGet(8,1,1, money_left);
                }
                else if (num < 50)
                {
                    ItemGet(12,1,2, money_left);
                }
                else if (num < 65)
                {
                    ItemGet(8,2,2, money_left);
                }
                else if (num < 80)
                {
                    ItemGet(12,2,3, money_left);
                }
                else if (num < 85)
                {
                    ItemGet(8,3,3, money_left);
                }
                else if (num < 90)
                {
                    ItemGet(12,3,3, money_left);
                }
                else if (num < 93)
                {
                    ItemGet(4,1,3, money_left);
                }
                else if (num < 96)
                {
                    ItemGet(4,3,4, money_left);
                }
                else if (num < 98)
                {
                    ItemGet(8,4,3, money_left);
                }
                else if (num < 99)
                {
                    ItemGet(4,2,4, money_left);
                }
                else if (num < 100)
                {
                    ItemGet(4,4,4, money_left);
                }
                else if (num < 101)
                {
                    ItemGet(12,4,4, money_left);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("您的余额不足\n现在前去充值吗？", "余额不足！", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Goto.GotoCharge();
                    this.Hide();
                }
            }
        }

        private void buttonBox3_Click(object sender, EventArgs e)
        {
            double money_left = 0;
            sqlCmd.CommandText = "select remain from Regist where num = '" + Login.Num + "'";
            //SqlCommand command = new SqlCommand(sql, DataOperator.connection);
            money_left = Convert.ToDouble(sqlCmd.ExecuteScalar());
            if (money_left >= 500)
            {
                Random ran = new Random();
                int num = ran.Next(1, 100);
                if (num < 20)
                {
                    ItemGet(14, 1, 1, money_left);
                }
                else if (num < 35)
                {
                    ItemGet(6, 1, 1, money_left);
                }
                else if (num < 50)
                {
                    ItemGet(6, 2, 1, money_left);
                }
                else if (num < 75)
                {
                    ItemGet(14, 2, 1, money_left);
                }
                else if (num < 80)
                {
                    ItemGet(6, 3, 2, money_left);
                }
                else if (num < 85)
                {
                    ItemGet(10, 1, 2, money_left);
                }
                else if (num < 88)
                {
                    ItemGet(14, 3, 3, money_left);
                }
                else if (num < 91)
                {
                    ItemGet(14, 4, 3, money_left);
                }
                else if (num < 93)
                {
                    ItemGet(10, 2, 3, money_left);
                }
                else if (num < 95)
                {
                    ItemGet(10, 3, 3, money_left);
                }
                else if (num < 96)
                {
                    ItemGet(10, 4, 3, money_left);
                }
                else if (num < 97)
                {
                    ItemGet(2, 1, 3, money_left);
                }
                else if (num < 98)
                {
                    ItemGet(6, 4, 3, money_left);
                }
                else if (num < 99)
                {
                    ItemGet(2, 2, 4, money_left);
                }
                else if (num < 100)
                {
                    ItemGet(2, 4, 4, money_left);
                }
                else if (num < 101)
                {
                    ItemGet(2, 3, 4, money_left);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("您的余额不足\n现在前去充值吗？", "余额不足！", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Goto.GotoCharge();
                    this.Hide();
                }
            }
        }

        private void buttonBox4_Click(object sender, EventArgs e)
        {
            double money_left = 0;
            sqlCmd.CommandText = "select remain from Regist where num = '" + Login.Num + "'";
            //SqlCommand command = new SqlCommand(sql, DataOperator.connection);
            money_left = Convert.ToDouble(sqlCmd.ExecuteScalar());
            if (money_left >= 500)
            {
                Random ran = new Random();
                int num = ran.Next(1, 100);
                if (num < 25)
                {
                    ItemGet(7,1,1, money_left);
                }
                else if (num < 40)
                {
                    ItemGet(7,2,2, money_left);
                }
                else if (num < 55)
                {
                    ItemGet(7,4,2, money_left);
                }
                else if (num < 70)
                {
                    ItemGet(7,3,2, money_left);
                }
                else if (num < 80)
                {
                    ItemGet(11,1,2, money_left);
                }
                else if (num < 86)
                {
                    ItemGet(11,2,3, money_left);
                }
                else if (num < 90)
                {
                    ItemGet(11,3,3, money_left);
                }
                else if (num < 93)
                {
                    ItemGet(11,4,3, money_left);
                }
                else if (num < 96)
                {
                    ItemGet(3,1,3, money_left);
                }
                else if (num < 98)
                {
                    ItemGet(3,2,4, money_left);
                }
                else if (num < 100)
                {
                    ItemGet(3,4,4, money_left);
                }
                else if (num < 101)
                {
                    ItemGet(3,3,4, money_left);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("您的余额不足\n现在前去充值吗？", "余额不足！", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Goto.GotoCharge();
                    this.Hide();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.pictureBoxInfo.ImageLocation = "img\\幻影武器箱展示.jpg";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.pictureBoxInfo.ImageLocation = "img\\狩猎武器箱展示.jpg";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.pictureBoxInfo.ImageLocation = "img\\光谱武器箱展示.jpg";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.pictureBoxInfo.ImageLocation = "img\\突围武器箱展示.jpg";
        }
    }
}
