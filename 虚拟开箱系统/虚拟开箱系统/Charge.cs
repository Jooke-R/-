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
    public partial class Charge : Form
    {
        SqlCommand sqlCmd = new SqlCommand();
        Goto Goto=new Goto();
        Regex Rg = new Regex("^[0-9]+$");

        private void ClearTextBox()
        {
            comboBoxMoney.Text = "100";
            radioButtonWei.Checked = false;
            radioButtonZhi.Checked = false;
        }
        public Charge()
        {
            InitializeComponent();
        }

        private void Charge_Load(object sender, EventArgs e)
        {
            //Goto.Load();//测试用
            sqlCmd.Connection = Goto.sqlCon;//连接命令
            labelNum2.Text = Login.Num;
            sqlCmd.CommandText = "select name from Regist where num = '"+Login.Num+"'";
            labelName2.Text = Convert.ToString(sqlCmd.ExecuteScalar());
            sqlCmd.CommandText = "select remain from Regist where num= '"+Login.Num+"'";
            labelBalance2.Text = Convert.ToString(sqlCmd.ExecuteScalar())+"元";
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            if(Rg.IsMatch(comboBoxMoney.Text)&&(radioButtonWei.Checked==true||radioButtonZhi.Checked==true))//判断合法
            {
                if(MessageBox.Show("是否确认充值？","充值提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
                {
                    sqlCmd.CommandText = "select remain from Regist where num = '" + Login.Num + "'";
                    double NewMoney = Convert.ToDouble(sqlCmd.ExecuteScalar()) + Convert.ToDouble(comboBoxMoney.Text);
                    sqlCmd.CommandText = "update Regist set remain ='" + NewMoney + "' where num='" + Login.Num + "'";
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("已成功充值！");
                    sqlCmd.CommandText = "select remain from Regist where num= '" + Login.Num + "'";//重新显示余额
                    labelBalance2.Text = Convert.ToString(sqlCmd.ExecuteScalar()) + "元";
                    this.ClearTextBox();
                }
            }
            else if(!Rg.IsMatch(comboBoxMoney.Text))
            {
                MessageBox.Show("输入金额必须为整数金额！");
                comboBoxMoney.Text = "100";
            }
            else
            {
                MessageBox.Show("请先选择充值方式！");
                radioButtonWei.Checked = false;
                radioButtonZhi.Checked = false;
            }
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            Goto.GotoUserInfo();
            this.Hide();//返回至某界面
        }

        private void comboBoxMoney_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Charge_Activated(object sender, EventArgs e)
        {
            radioButtonWei.Checked = false;
            radioButtonZhi.Checked = false;
        }
    }
}
