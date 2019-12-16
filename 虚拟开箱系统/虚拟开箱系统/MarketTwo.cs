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
    public partial class MarketTwo : Form
    {
        SqlCommand sqlCmd = new SqlCommand();
        Goto Goto = new Goto();
        public MarketTwo()
        {
            InitializeComponent();
        }

        private void MarketTwo_Load(object sender, EventArgs e)
        {
            //string market = "Data Source=LAPTOP-1ELORC9F;Initial Catalog=开箱模拟;Integrated Security=True";
            //SqlConnection con = new SqlConnection(@market);
            //con.Open();
            //SqlCommand cmd = new SqlCommand();
            sqlCmd.Connection = Goto.sqlCon;
            sqlCmd.CommandText = "select item_price from item where item_id='" + MarketOne.item_num + "'";
            SqlDataReader sqlDr = sqlCmd.ExecuteReader();
            sqlDr.Read();
            decimal need = Convert.ToDecimal(sqlDr.GetValue(0));
            label1.Text = "当前所需要支付金额为    " + sqlDr[0].ToString() + " ¥ ";
            sqlDr.Close();
            //SqlCommand cmd2 = new SqlCommand();
            //cmd2.Connection = con;
            sqlCmd.CommandText = "select remain from Regist where num= '"+ Login.Num + "'";
            double Money = Convert.ToDouble(sqlCmd.ExecuteScalar());
            //SqlDataReader sqlDr2 = sqlCmd.ExecuteReader();
            //sqlDr2.Read();
            label2.Text = "您当前账户余额为        " + Money.ToString() + " ¥ ";
            decimal re = Convert.ToDecimal(Money) - need;
            label3.Text = "购买后账余额为          " + re + " ¥ ";
            MarketOne.balance_1 = re;
            double discount = Convert.ToDouble(need) * 0.95;
            decimal intrest = Convert.ToDecimal(discount);
            MarketOne.balance_2 = MarketOne.balance_2 + intrest;
            //sqlDr2.Close();
            //con.Close();
            if (re <= 0)//如何提示
            {
                MarketOne.aff = false;
                label4.Text = "余额不足！请前往充值。";
            }
            else
            {
                label4.Text = "";
                MarketOne.aff = true;
            }
            
            this.pictureBox1.ImageLocation = "img\\Phoenix1.jpg";
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            if (MarketOne.aff)
            {
                //string market = "Data Source=LAPTOP-1ELORC9F;Initial Catalog=开箱模拟;Integrated Security=True";
                //SqlConnection con = new SqlConnection(@market);
                //con.Open();
                //SqlCommand cmd = new SqlCommand();
                //sqlCmd.Connection = con;
                sqlCmd.CommandText = "update Regist set remain= '" + MarketOne.balance_1 + "' where num='" + Login.Num + "'";
                sqlCmd.ExecuteNonQuery();
                sqlCmd.CommandText = "update Regist set remain= '" + MarketOne.balance_2 + "' where num='" + MarketOne.owner_id + "'";
                sqlCmd.ExecuteNonQuery();
                sqlCmd.CommandText = "update item set item_state=0,item_owner= '" + Login.Num+ "',item_price=NULL where item_id='" + MarketOne.item_num+"'";
                sqlCmd.ExecuteNonQuery();               
                if (MessageBox.Show("您已购买成功！是否继续浏览市场？","购买提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
                {
                    MarketOne.GoWhere = 0;
                    //Goto.GotoUserInfo();
                    this.Close();
                }
                else
                {
                    MarketOne.GoWhere = 1;
                    this.Close();
                    //Goto.GotoMarket();
                    //this.Hide();
                }
                //this.Close();
            }
            else
            {
                if(MessageBox.Show("您的余额不足，请前往充值！", "购买提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    //bool isfind = false;
                    MarketOne.GoWhere = 2;
                    this.Close();
                    Goto.GotoCharge();  
                }
                else
                {
                    MarketOne.GoWhere = 0;
                    Goto.GotoMarket();
                    this.Close();
                }
            }

        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            //Goto.GotoMarket();
            MarketOne.GoWhere = 0;
            this.Close();
        }
    }
}
