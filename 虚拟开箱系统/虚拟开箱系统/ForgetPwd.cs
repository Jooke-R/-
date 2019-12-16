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
    public partial class ForgetPwd : Form
    {
        SqlCommand sqlCmd = new SqlCommand();
        Goto Goto = new Goto();

        private void ClearTextBox()
        {
            textBoxNum.Text = "";
            textBoxNPwd.Text = "";
            textBoxCNPwd.Text = "";
        }
        public ForgetPwd()
        {
            InitializeComponent();
        }

        private void ForgetPwd_Load(object sender, EventArgs e)
        {
            //Goto.Load();
            sqlCmd.Connection = Goto.sqlCon;
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            if(textBoxNum.Text==""||textBoxNPwd.Text==""||textBoxCNPwd.Text=="")
            {
                MessageBox.Show("请填写完整信息！","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {                
                sqlCmd.CommandText ="select * from Regist where num = '"+textBoxNum.Text+"'";
                if (Convert.ToInt32(sqlCmd.ExecuteScalar()) != 1)//查到用户修改密码
                {
                    if(textBoxNPwd.Text==textBoxCNPwd.Text)//确认新密码是否与确认密码相同
                    {                       
                        if(MessageBox.Show("确定要修改密码？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
                        {
                            sqlCmd.CommandText = "update Regist set pwd = pwdencrypt('" + textBoxNPwd.Text + "') where num='" + textBoxNum.Text + "'";
                            sqlCmd.ExecuteNonQuery();
                            MessageBox.Show("已成功修改密码，请使用修改后的密码登录。", "修改提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Goto.GotoLogin();
                            this.ClearTextBox();
                            this.Hide();
                        }
                        else
                        {
                            this.ClearTextBox();
                        }
                    }
                    else
                    {
                        MessageBox.Show("新密码与确认密码不一致，请检查后重试！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxNPwd.Text = "";
                        textBoxCNPwd.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("没有查到该用户，请核对账户号码后再试！","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    this.ClearTextBox();
                }
            }
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            Goto.GotoLogin();
            this.Hide();
            this.ClearTextBox();
        }
    }
}
