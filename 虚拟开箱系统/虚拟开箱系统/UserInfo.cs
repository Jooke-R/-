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
    public partial class UserInfo : Form
    {
        SqlCommand sqlCmd = new SqlCommand();      
        Goto Goto = new Goto();
        internal static string[] item = new string[3];
        //private string PicturePathName = Application.StartupPath.re;
        

        private void ClearTextBox()
        {
            labelName2.Text = "";
            labelBalance2.Text = "";
            listView1.Items.Clear();
        }
        internal void ReLoadInfo()
        {
            sqlCmd.Connection = Goto.sqlCon;
            sqlCmd.CommandText = "update item set item_price ='0' where item_owner='" +Login.Num+ "'and item_state='0'";//检查上架状态改变价格
            sqlCmd.ExecuteNonQuery();
            sqlCmd.CommandText = "select name from Regist where num = '" + Login.Num + "'";
            labelName2.Text = Convert.ToString(sqlCmd.ExecuteScalar());
            sqlCmd.CommandText = "select remain from Regist where num = '" + Login.Num + "'";
            labelBalance2.Text = Convert.ToString(sqlCmd.ExecuteScalar());
            //sqlCmd.CommandText = "select * from item where item_owner='" +Login.Num+"'";
            sqlCmd.CommandText = "select * from item,item_type where item.item_typeid = item_type.item_typeid and item.item_color = item_type.item_color and item_owner='" + Login.Num + "'";
            SqlDataReader sqlDr = sqlCmd.ExecuteReader();
            listView1.Items.Clear();
            int i = 1;
            while (sqlDr.Read())//sqlDr下标从0开始
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = i.ToString();
                i++;
                lvi.SubItems.Add(sqlDr[9].ToString());
                lvi.SubItems.Add(sqlDr[10].ToString());
                lvi.SubItems.Add(sqlDr[15].ToString());
                lvi.SubItems.Add(sqlDr[5].ToString());
                if (sqlDr[6].ToString() == "False")
                {
                    lvi.SubItems.Add("未上架");
                }
                else
                {
                    lvi.SubItems.Add("已上架");
                }
                lvi.SubItems.Add(sqlDr[0].ToString());
                listView1.Items.Add(lvi);
                //lvi.SubItems[1].Text = sqlDr[4].ToString(); 
            }
            sqlDr.Close();
            this.pictureBox1.ImageLocation = "img\\LOGO.png";
        }
        public UserInfo()
        {
            InitializeComponent();
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            //Goto.Load();测试用
            this.ReLoadInfo();
        }

        private void buttonCharge_Click(object sender, EventArgs e)
        {
            this.ClearTextBox();
            Goto.GotoCharge();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listView1.SelectedItems[].SubItems;
            if(listView1.SelectedItems.Count!=0)
            {
                string PicName = listView1.SelectedItems[0].SubItems[1].Text + listView1.SelectedItems[0].SubItems[2].Text;
                //MessageBox.Show(Name);
                this.pictureBox1.ImageLocation = "img\\"+PicName+".png";   
            }
        }

        private void buttonSale_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count==0)
            {
                MessageBox.Show("尚未选择物品，请选择物品后再试！","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if(listView1.SelectedItems[0].SubItems[5].Text=="已上架")
            {
                MessageBox.Show("所选物品已上架，请先下架再重新设置价格！","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                //保存当前选中的物品信息
                item[0] = listView1.SelectedItems[0].SubItems[1].Text + listView1.SelectedItems[0].SubItems[2].Text;
                sqlCmd.CommandText = "select item_worth from item_type where item_type.item_typename='" + listView1.SelectedItems[0].SubItems[1].Text + "' and item_type.item_colorname='" + listView1.SelectedItems[0].SubItems[2].Text + "'";
                item[1] = Convert.ToString(sqlCmd.ExecuteScalar());
                item[2] = listView1.SelectedItems[0].SubItems[6].Text;
                Goto.GotoSale();
                listView1.SelectedItems.Clear();
                //pictureBox1.显示LOGO
            }
            //this.sta
        }

        private void buttonMarket_Click(object sender, EventArgs e)
        {
            this.ClearTextBox();
            Goto.GotoMarket();
            this.Hide();
        }

        private void UserInfo_Activated(object sender, EventArgs e)
        {
            this.ReLoadInfo();
        }

        private void buttonUnSale_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0].SubItems[5].Text == "未上架")
                {
                    MessageBox.Show("所选物品还未上架，不可执行下架操作！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    listView1.SelectedItems.Clear();
                }
                else
                {
                    string itemName = listView1.SelectedItems[0].SubItems[6].Text;
                    if (MessageBox.Show("是否下架当前选择物品？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {  
                        sqlCmd.CommandText = "update item set item_state='0' where item_id='" +itemName+"'";
                        sqlCmd.ExecuteNonQuery();
                        listView1.SelectedItems.Clear();
                        this.ReLoadInfo();
                    }
                    else
                    {
                        listView1.SelectedItems.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("尚未选择物品，请选择物品后再试！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            Goto.GotoOpenBox();
            this.Hide();
        }
    }
}
