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
    public partial class Regist : Form
    {
        SqlCommand sqlCmd = new SqlCommand();
        Goto Goto = new Goto();//界面转换变量
        Regex Rg = new Regex("^[0-9]+$");
        Regex Rg2 = new Regex("(?i)^[0-9a-z]+$");
        private void ClearTextBox()
        {
            textBoxNum.Text = "";
            textBoxName.Text = "";
            textBoxPwd.Text = "";
            textBoxCPwd.Text = "";
            textBoxPhone.Text = "";
        }

        public Regist()
        {
            InitializeComponent();
        }

        private void Regist_Load(object sender, EventArgs e)
        {
           // Goto.Load();
           sqlCmd.Connection = Goto.sqlCon;
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            Goto.GotoLogin();//跳转至Login
            this.Hide();
            this.ClearTextBox();
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            if(textBoxNum.Text==""||textBoxName.Text==""||textBoxPwd.Text==""||textBoxCPwd.Text==""||textBoxPhone.Text=="")
            {
                MessageBox.Show("请填写完整的信息！","警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //SqlDataReader sqlda= sqlCmd.ExecuteReader();读表
                //for(int i=0;i<sqlda.Read ())显示
                if(Rg2.IsMatch(textBoxNum.Text))
                {
                    //sqlCmd.Connection = Goto.sqlCon;
                    sqlCmd.CommandText = "select num from Regist where num='" + textBoxNum.Text + "'";
                    if (Convert.ToString(sqlCmd.ExecuteScalar()) == textBoxNum.Text)//判断账号是否被使用
                    { 
                        MessageBox.Show("该账号已被人使用，请更换后再试", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxNum.Text = "";
                        textBoxPwd.Text = "";
                        textBoxCPwd.Text = "";
                    }
                    else
                    {
                        if (textBoxPwd.Text == textBoxCPwd.Text)//判断密码与确认密码是否一致
                        {
                            if (textBoxPhone.Text.Length == 11 && double.TryParse(textBoxPhone.Text, out double Phone))//判断手机号是否合法
                            {
                                sqlCmd.CommandText = "insert into Regist values ('" + textBoxNum.Text + "','" + textBoxName.Text + "',pwdencrypt('" + textBoxPwd.Text + "'),'" + textBoxPhone.Text + "','0')";
                                sqlCmd.ExecuteNonQuery();
                                //sqlCmd.CommandText = "insert into XXX values ('0000','"+textBoxNum.Text+"','普通','0')";
                                //sqlCmd.ExecuteNonQuery();//为新注册的用户赠送注册赠品
                                MessageBox.Show("已成功注册，请登录使用。");
                                Goto.GotoLogin();//跳转回登录界面
                                this.Hide();
                                this.ClearTextBox();
                            }
                            else
                            {
                                MessageBox.Show("请填写正确的电话号码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("密码与确认密码不一致，请确认后重试！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBoxPwd.Text = "";
                            textBoxCPwd.Text = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("输入的账号不合法，请检查后再输！","警告！",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    this.ClearTextBox();
                }
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            sqlCmd.CommandText = "select num from Regist where num='"+textBoxNum.Text+"'";
            if(Convert.ToString(sqlCmd.ExecuteScalar())== textBoxNum.Text)//判断账号是否被使用
            {
                MessageBox.Show("该账号已被人使用，请更换后再试", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNum.Text = "";
                textBoxPwd.Text = "";
                textBoxCPwd.Text = "";
            }
            else if(!Rg2.IsMatch(textBoxNum.Text))
            {
                MessageBox.Show("该账号不合法，请检查后重输！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNum.Text = "";
                textBoxPwd.Text = "";
                textBoxCPwd.Text = "";
            }
            else
            {
                MessageBox.Show("该账号可以使用。");
            }
        }

        private void textBoxNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
