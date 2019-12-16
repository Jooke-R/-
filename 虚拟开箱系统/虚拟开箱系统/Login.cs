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
    public partial class Login : Form
    {
        SqlCommand sqlCmd = new SqlCommand();
        Goto Goto = new Goto();
        public static string Num;
        
        private void ClearTextBox()
        {
            textBoxNum.Text = "";
            textBoxPwd.Text = "";
        }
        public Login()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            Goto.Load();
            sqlCmd.Connection =Goto.sqlCon;
            this.pictureBox1.ImageLocation = "img\\Phoenix1.jpg";
            //this.ClearTextBox();
        }

        private void labelTip_Click(object sender, EventArgs e)
        {
            Goto.GotoRegist();//跳转至注册
            this.Hide();
            this.ClearTextBox();
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            if(textBoxNum.Text=="")
            {
                MessageBox.Show("用户名不能为空","登录提示",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(textBoxPwd.Text=="")
            {
                MessageBox.Show("密码不能为空", "登录提示",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                sqlCmd.CommandText = "select num from Regist where num = '"+textBoxNum.Text+"'";
                if(Convert.ToString(sqlCmd.ExecuteScalar())==textBoxNum.Text)
                {
                    sqlCmd.CommandText = "select pwdcompare('" + textBoxPwd.Text + "',(select pwd from Regist where num='" + textBoxNum.Text + "'),1)";
                    if (Convert.ToInt32(sqlCmd.ExecuteScalar()) == 1)
                    {
                        Num = textBoxNum.Text;
                        this.ClearTextBox();
                        Goto.GotoUserInfo();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("输入的密码有误，请核实后再输!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxPwd.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("您输入的用户名有误，请验证后再试！","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                
            }
        }

        private void buttonN_Click(object sender, EventArgs e)
        {          
            this.Close();
        }

        private void labelTip2_Click(object sender, EventArgs e)
        {
            Goto.GotoForgetPwd();//跳转忘记密码
            this.ClearTextBox();
            this.Hide();
        }
    }
}
