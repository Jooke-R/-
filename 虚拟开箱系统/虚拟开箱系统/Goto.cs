using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;


namespace 虚拟开箱系统
{
    class Goto
    {
        public static SqlConnection sqlCon = new SqlConnection();

        internal void GotoWhere(string name)//并不可行，无法根据参数创建对象
        { 
        }
        internal void Load()
        {
            sqlCon.ConnectionString = "server=JOKER;uid=sa;pwd=chen;database=开箱模拟";
            sqlCon.Open();
        }

        internal void GotoLogin()//跳转至Login
        {
            bool isfind = false;
            foreach (Form fm in Application.OpenForms)
            {
                if (fm.Name == "Login")//Login
                {
                    //fm.WindowState = FormWindowState.Maximized;
                    fm.Visible = true;
                    //fm.Activate();
                    //MessageBox.Show("检测到了哦");
                    return;
                }
            }
            if (!isfind)
            {
                Login obj = new Login();
                obj.Show();
                //this.hide();
            }
        }
     
        internal void GotoRegist()//跳转至Regist
        {
            bool isfind = false;
            foreach (Form fm in Application.OpenForms)
            {
                if (fm.Name == "Regist")//Regist
                {
                    fm.Visible = true;
                    return;
                }
            }
            if (!isfind)
            {
                Regist obj = new Regist();
                obj.Show();
                //this.hide();
            }
        }
        /*
        internal void GotoSelFunction()//跳转至功能选择
        {
            bool isfind = false;
            foreach (Form fm in Application.OpenForms)
            {
                if (fm.Name == "SelFunction")//SelFunction
                {
                    fm.Visible = true;
                    return;
                }
            }
            if (!isfind)
            {
                SelFunction obj = new SelFunction();
                obj.Show();
                //this.Hide();
            }
        }
        */
        internal void GotoForgetPwd()//跳转至忘记密码
        {
            bool isfind = false;
            foreach (Form fm in Application.OpenForms)
            {
                if (fm.Name == "ForgetPwd")//ForgetPwd
                {
                    fm.Visible = true;
                    return;
                }
            }
            if (!isfind)
            {
                ForgetPwd obj = new ForgetPwd();
                obj.Show();
                //this.Hide();
            }
        }
        internal void GotoCharge()
        {
            bool isfind = false;
            foreach (Form fm in Application.OpenForms)
            {
                if (fm.Name == "Charge")//Charge
                {
                    fm.Visible = true;
                    return;
                }
            }
            if (!isfind)
            {
                Charge obj = new Charge();
                obj.Show();
                //this.Hide();
            }
        }
        internal void GotoUserInfo()//跳转至用户信息界面
        {
            bool isfind = false;
            foreach(Form fm in Application.OpenForms)
            {
                if(fm.Name=="UserInfo")
                {
                    fm.Visible = true;
                    return;
                }
            }
            if(!isfind)
            {
                UserInfo obj = new UserInfo();
                obj.Show();
                obj.ReLoadInfo();
            }
        }
        internal void GotoSale()
        {
            bool isfind = false;
            foreach (Form fm in Application.OpenForms)
            {
                if (fm.Name == "Sale")
                {
                    fm.Visible = true;
                    return;
                }
            }
            if (!isfind)
            {
                Sale obj = new Sale();
                obj.ShowDialog();
            }
        }
        internal void GotoMarket()
        {
            bool isfind = false;
            foreach (Form fm in Application.OpenForms)
            {
                if (fm.Name == "MarketOne")
                {
                    fm.Visible = true;
                    return;
                }
            }
            if (!isfind)
            {
                MarketOne obj = new MarketOne();
                obj.Show();
            }
        }
        internal void GotoOpenBox()
        {
            bool isfind = false;
            foreach (Form fm in Application.OpenForms)
            {
                if (fm.Name == "OpenBox")
                {
                    fm.Visible = true;
                    return;
                }
            }
            if (!isfind)
            {
                OpenBox obj = new OpenBox();
                obj.Show();
            }
        }
        internal void GotoChooseBox()
        {
            bool isfind = false;
            foreach (Form fm in Application.OpenForms)
            {
                if (fm.Name == "ChooseBox")
                {
                    fm.Visible = true;
                    return;
                }
            }
            if (!isfind)
            {
                ChooseBox obj = new ChooseBox();
                obj.Show();
            }
        }
    }
}
