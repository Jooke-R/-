namespace 虚拟开箱系统
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.buttonY = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPwd = new System.Windows.Forms.Label();
            this.buttonN = new System.Windows.Forms.Button();
            this.labelTip = new System.Windows.Forms.Label();
            this.labelTip2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("宋体", 25F);
            this.labelLogin.Location = new System.Drawing.Point(227, 54);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(287, 34);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "欢迎使用开箱系统";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(300, 221);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(154, 21);
            this.textBoxNum.TabIndex = 1;
            this.textBoxNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Location = new System.Drawing.Point(300, 277);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.PasswordChar = '*';
            this.textBoxPwd.Size = new System.Drawing.Size(154, 21);
            this.textBoxPwd.TabIndex = 2;
            // 
            // buttonY
            // 
            this.buttonY.Location = new System.Drawing.Point(171, 421);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(74, 39);
            this.buttonY.TabIndex = 3;
            this.buttonY.Text = "确认";
            this.buttonY.UseVisualStyleBackColor = true;
            this.buttonY.Click += new System.EventHandler(this.buttonY_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("宋体", 20F);
            this.label.Location = new System.Drawing.Point(328, 124);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(93, 27);
            this.label.TabIndex = 5;
            this.label.Text = "请登录";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("宋体", 12F);
            this.labelName.Location = new System.Drawing.Point(185, 220);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(72, 16);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "账户号码";
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.Font = new System.Drawing.Font("宋体", 12F);
            this.labelPwd.Location = new System.Drawing.Point(185, 276);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(40, 16);
            this.labelPwd.TabIndex = 7;
            this.labelPwd.Text = "密码";
            // 
            // buttonN
            // 
            this.buttonN.Location = new System.Drawing.Point(494, 421);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(74, 39);
            this.buttonN.TabIndex = 8;
            this.buttonN.Text = "取消";
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Location = new System.Drawing.Point(486, 221);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(77, 24);
            this.labelTip.TabIndex = 9;
            this.labelTip.Text = "还没有账号？\r\n快来注册";
            this.labelTip.Click += new System.EventHandler(this.labelTip_Click);
            // 
            // labelTip2
            // 
            this.labelTip2.AutoSize = true;
            this.labelTip2.Location = new System.Drawing.Point(486, 286);
            this.labelTip2.Name = "labelTip2";
            this.labelTip2.Size = new System.Drawing.Size(101, 12);
            this.labelTip2.TabIndex = 10;
            this.labelTip2.Text = "忘记及修改密码？";
            this.labelTip2.Click += new System.EventHandler(this.labelTip2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(41, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(749, 520);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTip2);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.buttonN);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonY);
            this.Controls.Add(this.textBoxPwd);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.labelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "欢迎使用";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.Button buttonY;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Label labelTip2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

