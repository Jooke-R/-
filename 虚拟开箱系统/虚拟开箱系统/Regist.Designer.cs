namespace 虚拟开箱系统
{
    partial class Regist
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
            this.buttonY = new System.Windows.Forms.Button();
            this.labelNum = new System.Windows.Forms.Label();
            this.labelPwd = new System.Windows.Forms.Label();
            this.labelCPwd = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.textBoxCPwd = new System.Windows.Forms.TextBox();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelTip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonY
            // 
            this.buttonY.Location = new System.Drawing.Point(132, 403);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(96, 37);
            this.buttonY.TabIndex = 0;
            this.buttonY.Text = "确认注册";
            this.buttonY.UseVisualStyleBackColor = true;
            this.buttonY.Click += new System.EventHandler(this.buttonY_Click);
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Font = new System.Drawing.Font("宋体", 12F);
            this.labelNum.Location = new System.Drawing.Point(175, 125);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(72, 16);
            this.labelNum.TabIndex = 1;
            this.labelNum.Text = "账户号码";
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.Font = new System.Drawing.Font("宋体", 12F);
            this.labelPwd.Location = new System.Drawing.Point(175, 217);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(72, 16);
            this.labelPwd.TabIndex = 2;
            this.labelPwd.Text = "账户密码";
            // 
            // labelCPwd
            // 
            this.labelCPwd.AutoSize = true;
            this.labelCPwd.Font = new System.Drawing.Font("宋体", 12F);
            this.labelCPwd.Location = new System.Drawing.Point(175, 263);
            this.labelCPwd.Name = "labelCPwd";
            this.labelCPwd.Size = new System.Drawing.Size(72, 16);
            this.labelCPwd.TabIndex = 3;
            this.labelCPwd.Text = "确认密码";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("宋体", 12F);
            this.labelName.Location = new System.Drawing.Point(175, 171);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(72, 16);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "账号名称";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("宋体", 20F);
            this.labelTitle.Location = new System.Drawing.Point(294, 48);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(120, 27);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "欢迎注册";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(299, 120);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(160, 21);
            this.textBoxNum.TabIndex = 6;
            this.textBoxNum.TextChanged += new System.EventHandler(this.textBoxNum_TextChanged);
            // 
            // textBoxCPwd
            // 
            this.textBoxCPwd.Location = new System.Drawing.Point(299, 258);
            this.textBoxCPwd.Name = "textBoxCPwd";
            this.textBoxCPwd.PasswordChar = '*';
            this.textBoxCPwd.Size = new System.Drawing.Size(160, 21);
            this.textBoxCPwd.TabIndex = 7;
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Location = new System.Drawing.Point(299, 212);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.PasswordChar = '*';
            this.textBoxPwd.Size = new System.Drawing.Size(160, 21);
            this.textBoxPwd.TabIndex = 8;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(299, 166);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(160, 21);
            this.textBoxName.TabIndex = 9;
            // 
            // buttonN
            // 
            this.buttonN.Location = new System.Drawing.Point(454, 403);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(96, 37);
            this.buttonN.TabIndex = 10;
            this.buttonN.Text = "取消";
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(490, 120);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 11;
            this.buttonCheck.Text = "检查账号";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("宋体", 12F);
            this.labelPhone.Location = new System.Drawing.Point(176, 309);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(72, 16);
            this.labelPhone.TabIndex = 12;
            this.labelPhone.Text = "联系电话";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(299, 304);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(160, 21);
            this.textBoxPhone.TabIndex = 13;
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Location = new System.Drawing.Point(488, 146);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(149, 12);
            this.labelTip.TabIndex = 14;
            this.labelTip.Text = "账号只可为字母与数字组合";
            // 
            // Regist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 496);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonN);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPwd);
            this.Controls.Add(this.textBoxCPwd);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelCPwd);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.buttonY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Regist";
            this.Text = "欢迎注册";
            this.Load += new System.EventHandler(this.Regist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonY;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.Label labelCPwd;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.TextBox textBoxCPwd;
        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelTip;
    }
}