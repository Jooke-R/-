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
    public partial class MarketOne : Form
    {
        SqlCommand sqlCmd = new SqlCommand();
        Goto Goto = new Goto();
        public static int GoWhere;
        public static string item_num;
        //public static string user_id = "1005";
        public static string owner_id;
        public static decimal balance_1;
        public static decimal balance_2;
        public static bool aff = true;

        public MarketOne()
        {
            InitializeComponent();
        }

        private void Market1_Load(object sender, EventArgs e)
        {
            //string market = "Data Source=LAPTOP-1ELORC9F;Initial Catalog=开箱模拟;Integrated Security=True";
            //SqlConnection con = new SqlConnection(@market);
            //con.Open();
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;
            sqlCmd.Connection = Goto.sqlCon;
            sqlCmd.CommandText = "select item_type.item_typename AS 物品名称, item_type.item_colorname AS 涂装, item_type.item_levelname AS 稀有等级 ,item_price AS 价格,Regist.name AS 卖家,item.item_id AS 物品编号 from item left join Regist on item_owner = Regist.num left join item_type on item.item_typeid = item_type.item_typeid and item.item_color = item_type.item_color where item.item_state = 1";
            SqlDataReader sqlDr = sqlCmd.ExecuteReader();
            listView1.Items.Clear();
            int i = 1;
            while (sqlDr.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = i.ToString();
                i++;
                lvi.SubItems.Add(sqlDr[0].ToString());
                lvi.SubItems.Add(sqlDr[1].ToString());
                lvi.SubItems.Add(sqlDr[2].ToString());
                lvi.SubItems.Add(sqlDr[3].ToString());
                lvi.SubItems.Add(sqlDr[4].ToString());
                lvi.SubItems.Add(sqlDr[5].ToString());
                listView1.Items.Add(lvi);

            }
            sqlDr.Close();
            this.pictureBox1.ImageLocation = "img\\LOGO.png";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                string PicName = listView1.SelectedItems[0].SubItems[1].Text + listView1.SelectedItems[0].SubItems[2].Text;
                //MessageBox.Show(PicName);
                this.pictureBox1.ImageLocation = "img\\" + PicName + ".png";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string market = "Data Source=LAPTOP-1ELORC9F;Initial Catalog=开箱模拟;Integrated Security=True";
            //SqlConnection con = new SqlConnection(@market);
            //con.Open();
            //SqlCommand cmd = new SqlCommand();
            //sqlCmd.Connection = Goto.sqlCon;
            sqlCmd.CommandText = "select item_type.item_typename AS 物品名称, item_type.item_colorname AS 涂装, item_type.item_levelname AS 稀有等级 ,item_price AS 价格,Regist.name AS 卖家,item.item_id AS 物品编号 from item left join Regist on item_owner = Regist.num left join item_type on item.item_typeid = item_type.item_typeid and item.item_color = item_type.item_color where item.item_state = 1";
            SqlDataReader sqlDr = sqlCmd.ExecuteReader();
            listView1.Items.Clear();
            int i = 1;
            while (sqlDr.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = i.ToString();
                i++;
                lvi.SubItems.Add(sqlDr[0].ToString());
                lvi.SubItems.Add(sqlDr[1].ToString());
                lvi.SubItems.Add(sqlDr[2].ToString());
                lvi.SubItems.Add(sqlDr[3].ToString());
                lvi.SubItems.Add(sqlDr[4].ToString());
                lvi.SubItems.Add(sqlDr[5].ToString());
                listView1.Items.Add(lvi);

            }
            sqlDr.Close();
            listView1.SelectedItems.Clear();
            this.pictureBox1.ImageLocation = "img\\LOGO.png";
            MessageBox.Show("刷新成功！");
            //con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 1)
            {
                item_num = this.listView1.SelectedItems[0].SubItems[6].Text;
                //string market = "Data Source=LAPTOP-1ELORC9F;Initial Catalog=开箱模拟;Integrated Security=True";
                //SqlConnection con = new SqlConnection(@market);
                //con.Open();
                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = con;
                sqlCmd.CommandText = "select item_owner from item where item_id='" + item_num + "'";
                SqlDataReader sqlDr = sqlCmd.ExecuteReader();
                sqlDr.Read();
                owner_id = sqlDr[0].ToString();
                sqlDr.Close();
                sqlCmd.CommandText = "select remain from Regist where num='" + owner_id + "'";
                SqlDataReader sqlDr_balance = sqlCmd.ExecuteReader();
                sqlDr_balance.Read();
                balance_2 = Convert.ToDecimal(sqlDr_balance.GetValue(0));
                sqlDr_balance.Close();
                if (MarketOne.owner_id != Login.Num)
                {
                    MarketTwo obj = new MarketTwo();
                    obj.ShowDialog();

                    if (GoWhere == 1)
                    {
                        this.Hide();
                        Goto.GotoUserInfo();
                    }
                    else if(GoWhere == 2)
                    {
                        this.Hide();
                        Goto.GotoCharge();
                    }
                    else
                    {
                        Goto.GotoMarket();
                    }
                }
                else
                {
                    MessageBox.Show("该件物品是你的在售物品，请前往库存下架取回。");
                }
            }
            else
            {
                MessageBox.Show("请选择想购买的物品！");
            }
        }

        private void Market1_Activated(object sender, EventArgs e)
        {
            //string market = "Data Source=LAPTOP-1ELORC9F;Initial Catalog=开箱模拟;Integrated Security=True";
            //SqlConnection con = new SqlConnection(@market);
            //con.Open();
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;
            sqlCmd.CommandText = "select item_type.item_typename AS 物品名称, item_type.item_colorname AS 涂装, item_type.item_levelname AS 稀有等级 ,item_price AS 价格,Regist.name AS 卖家,item.item_id AS 物品编号 from item left join Regist on item_owner = Regist.num left join item_type on item.item_typeid = item_type.item_typeid and item.item_color = item_type.item_color where item.item_state = 1";
            SqlDataReader sqlDr = sqlCmd.ExecuteReader();
            listView1.Items.Clear();
            int i = 1;
            while (sqlDr.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = i.ToString();
                i++;
                lvi.SubItems.Add(sqlDr[0].ToString());
                lvi.SubItems.Add(sqlDr[1].ToString());
                lvi.SubItems.Add(sqlDr[2].ToString());
                lvi.SubItems.Add(sqlDr[3].ToString());
                lvi.SubItems.Add(sqlDr[4].ToString());
                lvi.SubItems.Add(sqlDr[5].ToString());
                listView1.Items.Add(lvi);

            }
            sqlDr.Close();
            this.pictureBox1.ImageLocation = "img\\LOGO.png";
            sqlCmd.CommandText = "select remain from Regist where num='"+Login.Num+"'";
            labelRemian.Text = "余额："+sqlCmd.ExecuteScalar().ToString();
        }

        private void buttonUserInfo_Click(object sender, EventArgs e)
        {
            Goto.GotoUserInfo();
            this.Hide();
        }
    }
}

