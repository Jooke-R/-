namespace 虚拟开箱系统
{
    partial class ForgetPwd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.labelNum = new System.Windows.Forms.Label();
            this.labelNPwd = new System.Windows.Forms.Label();
            this.textBoxNPwd = new System.Windows.Forms.TextBox();
            this.labelCNPwd = new System.Windows.Forms.Label();
            this.textBoxCNPwd = new System.Windows.Forms.TextBox();
            this.buttonY = new System.Windows.Forms.Button();
            this.buttonN = new System.Windows.Forms.Button();
            this.labelCheck = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("宋体", 20F);
            this.labelTitle.Location = new System.Drawing.Point(252, 43);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(120, 27);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "修改密码";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(286, 137);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(151, 21);
            this.textBoxNum.TabIndex = 1;
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Font = new System.Drawing.Font("宋体", 12F);
            this.labelNum.Location = new System.Drawing.Point(171, 137);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(72, 16);
            this.labelNum.TabIndex = 2;
            this.labelNum.Text = "账户号码";
            // 
            // labelNPwd
            // 
            this.labelNPwd.AutoSize = true;
            this.labelNPwd.Font = new System.Drawing.Font("宋体", 12F);
            this.labelNPwd.Location = new System.Drawing.Point(171, 231);
            this.labelNPwd.Name = "labelNPwd";
            this.labelNPwd.Size = new System.Drawing.Size(56, 16);
            this.labelNPwd.TabIndex = 3;
            this.labelNPwd.Text = "新密码";
            // 
            // textBoxNPwd
            // 
            this.textBoxNPwd.Location = new System.Drawing.Point(286, 226);
            this.textBoxNPwd.Name = "textBoxNPwd";
            this.textBoxNPwd.PasswordChar = '*';
            this.textBoxNPwd.Size = new System.Drawing.Size(151, 21);
            this.textBoxNPwd.TabIndex = 4;
            // 
            // labelCNPwd
            // 
            this.labelCNPwd.AutoSize = true;
            this.labelCNPwd.Font = new System.Drawing.Font("宋体", 12F);
            this.labelCNPwd.Location = new System.Drawing.Point(171, 278);
            this.labelCNPwd.Name = "labelCNPwd";
            this.labelCNPwd.Size = new System.Drawing.Size(72, 16);
            this.labelCNPwd.TabIndex = 5;
            this.labelCNPwd.Text = "确认密码";
            // 
            // textBoxCNPwd
            // 
            this.textBoxCNPwd.Location = new System.Drawing.Point(286, 273);
            this.textBoxCNPwd.Name = "textBoxCNPwd";
            this.textBoxCNPwd.PasswordChar = '*';
            this.textBoxCNPwd.Size = new System.Drawing.Size(151, 21);
            this.textBoxCNPwd.TabIndex = 6;
            // 
            // buttonY
            // 
            this.buttonY.Location = new System.Drawing.Point(136, 360);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(91, 32);
            this.buttonY.TabIndex = 7;
            this.buttonY.Text = "确认修改";
            this.buttonY.UseVisualStyleBackColor = true;
            this.buttonY.Click += new System.EventHandler(this.buttonY_Click);
            // 
            // buttonN
            // 
            this.buttonN.Location = new System.Drawing.Point(402, 360);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(91, 32);
            this.buttonN.TabIndex = 8;
            this.buttonN.Text = "取消返回";
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // labelCheck
            // 
            this.labelCheck.AutoSize = true;
            this.labelCheck.Font = new System.Drawing.Font("宋体", 12F);
            this.labelCheck.Location = new System.Drawing.Point(171, 184);
            this.labelCheck.Name = "labelCheck";
            this.labelCheck.Size = new System.Drawing.Size(56, 16);
            this.labelCheck.TabIndex = 9;
            this.labelCheck.Text = "验证码";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(286, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 21);
            this.textBox1.TabIndex = 10;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(474, 177);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 11;
            this.buttonCheck.Text = "获取验证码";
            this.buttonCheck.UseVisualStyleBackColor = true;
            // 
            // ForgetPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 470);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelCheck);
            this.Controls.Add(this.buttonN);
            this.Controls.Add(this.buttonY);
            this.Controls.Add(this.textBoxCNPwd);
            this.Controls.Add(this.labelCNPwd);
            this.Controls.Add(this.textBoxNPwd);
            this.Controls.Add(this.labelNPwd);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ForgetPwd";
            this.Text = "忘记密码";
            this.Load += new System.EventHandler(this.ForgetPwd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label labelNPwd;
        private System.Windows.Forms.TextBox textBoxNPwd;
        private System.Windows.Forms.Label labelCNPwd;
        private System.Windows.Forms.TextBox textBoxCNPwd;
        private System.Windows.Forms.Button buttonY;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Label labelCheck;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCheck;
    }
}