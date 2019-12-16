namespace 虚拟开箱系统
{
    partial class Charge
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
            this.comboBoxMoney = new System.Windows.Forms.ComboBox();
            this.labelMoney = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonZhi = new System.Windows.Forms.RadioButton();
            this.radioButtonWei = new System.Windows.Forms.RadioButton();
            this.labelName1 = new System.Windows.Forms.Label();
            this.labelNum1 = new System.Windows.Forms.Label();
            this.labelBalance1 = new System.Windows.Forms.Label();
            this.labelBalance2 = new System.Windows.Forms.Label();
            this.labelName2 = new System.Windows.Forms.Label();
            this.labelNum2 = new System.Windows.Forms.Label();
            this.buttonY = new System.Windows.Forms.Button();
            this.buttonN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("宋体", 15F);
            this.labelTitle.Location = new System.Drawing.Point(293, 53);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(169, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "欢迎使用充值系统";
            // 
            // comboBoxMoney
            // 
            this.comboBoxMoney.FormattingEnabled = true;
            this.comboBoxMoney.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxMoney.Items.AddRange(new object[] {
            "100",
            "200",
            "500",
            "1000",
            "5000"});
            this.comboBoxMoney.Location = new System.Drawing.Point(331, 297);
            this.comboBoxMoney.Name = "comboBoxMoney";
            this.comboBoxMoney.Size = new System.Drawing.Size(153, 20);
            this.comboBoxMoney.TabIndex = 1;
            this.comboBoxMoney.Text = "100";
            this.comboBoxMoney.SelectedIndexChanged += new System.EventHandler(this.comboBoxMoney_SelectedIndexChanged);
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("宋体", 12F);
            this.labelMoney.Location = new System.Drawing.Point(174, 301);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(72, 16);
            this.labelMoney.TabIndex = 2;
            this.labelMoney.Text = "充值金额";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonZhi);
            this.groupBox1.Controls.Add(this.radioButtonWei);
            this.groupBox1.Location = new System.Drawing.Point(507, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 149);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "充值方式选择";
            // 
            // radioButtonZhi
            // 
            this.radioButtonZhi.AutoSize = true;
            this.radioButtonZhi.Location = new System.Drawing.Point(23, 100);
            this.radioButtonZhi.Name = "radioButtonZhi";
            this.radioButtonZhi.Size = new System.Drawing.Size(83, 16);
            this.radioButtonZhi.TabIndex = 1;
            this.radioButtonZhi.TabStop = true;
            this.radioButtonZhi.Text = "支付宝支付";
            this.radioButtonZhi.UseVisualStyleBackColor = true;
            // 
            // radioButtonWei
            // 
            this.radioButtonWei.AutoSize = true;
            this.radioButtonWei.Location = new System.Drawing.Point(23, 48);
            this.radioButtonWei.Name = "radioButtonWei";
            this.radioButtonWei.Size = new System.Drawing.Size(71, 16);
            this.radioButtonWei.TabIndex = 0;
            this.radioButtonWei.TabStop = true;
            this.radioButtonWei.Text = "微信支付";
            this.radioButtonWei.UseVisualStyleBackColor = true;
            // 
            // labelName1
            // 
            this.labelName1.AutoSize = true;
            this.labelName1.Font = new System.Drawing.Font("宋体", 12F);
            this.labelName1.Location = new System.Drawing.Point(174, 193);
            this.labelName1.Name = "labelName1";
            this.labelName1.Size = new System.Drawing.Size(72, 16);
            this.labelName1.TabIndex = 4;
            this.labelName1.Text = "账户名称";
            // 
            // labelNum1
            // 
            this.labelNum1.AutoSize = true;
            this.labelNum1.Font = new System.Drawing.Font("宋体", 12F);
            this.labelNum1.Location = new System.Drawing.Point(174, 139);
            this.labelNum1.Name = "labelNum1";
            this.labelNum1.Size = new System.Drawing.Size(72, 16);
            this.labelNum1.TabIndex = 5;
            this.labelNum1.Text = "账户号码";
            // 
            // labelBalance1
            // 
            this.labelBalance1.AutoSize = true;
            this.labelBalance1.Font = new System.Drawing.Font("宋体", 12F);
            this.labelBalance1.Location = new System.Drawing.Point(174, 247);
            this.labelBalance1.Name = "labelBalance1";
            this.labelBalance1.Size = new System.Drawing.Size(72, 16);
            this.labelBalance1.TabIndex = 6;
            this.labelBalance1.Text = "账户余额";
            // 
            // labelBalance2
            // 
            this.labelBalance2.AutoSize = true;
            this.labelBalance2.Font = new System.Drawing.Font("宋体", 12F);
            this.labelBalance2.Location = new System.Drawing.Point(328, 247);
            this.labelBalance2.Name = "labelBalance2";
            this.labelBalance2.Size = new System.Drawing.Size(56, 16);
            this.labelBalance2.TabIndex = 7;
            this.labelBalance2.Text = "label4";
            // 
            // labelName2
            // 
            this.labelName2.AutoSize = true;
            this.labelName2.Font = new System.Drawing.Font("宋体", 12F);
            this.labelName2.Location = new System.Drawing.Point(328, 193);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(56, 16);
            this.labelName2.TabIndex = 8;
            this.labelName2.Text = "label5";
            // 
            // labelNum2
            // 
            this.labelNum2.AutoSize = true;
            this.labelNum2.Font = new System.Drawing.Font("宋体", 12F);
            this.labelNum2.Location = new System.Drawing.Point(328, 139);
            this.labelNum2.Name = "labelNum2";
            this.labelNum2.Size = new System.Drawing.Size(56, 16);
            this.labelNum2.TabIndex = 9;
            this.labelNum2.Text = "label6";
            // 
            // buttonY
            // 
            this.buttonY.Location = new System.Drawing.Point(162, 421);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(84, 42);
            this.buttonY.TabIndex = 10;
            this.buttonY.Text = "确定";
            this.buttonY.UseVisualStyleBackColor = true;
            this.buttonY.Click += new System.EventHandler(this.buttonY_Click);
            // 
            // buttonN
            // 
            this.buttonN.Location = new System.Drawing.Point(498, 421);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(84, 42);
            this.buttonN.TabIndex = 11;
            this.buttonN.Text = "返回";
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // Charge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 527);
            this.Controls.Add(this.buttonN);
            this.Controls.Add(this.buttonY);
            this.Controls.Add(this.labelNum2);
            this.Controls.Add(this.labelName2);
            this.Controls.Add(this.labelBalance2);
            this.Controls.Add(this.labelBalance1);
            this.Controls.Add(this.labelNum1);
            this.Controls.Add(this.labelName1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.comboBoxMoney);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Charge";
            this.Text = "充值";
            this.Activated += new System.EventHandler(this.Charge_Activated);
            this.Load += new System.EventHandler(this.Charge_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxMoney;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelName1;
        private System.Windows.Forms.Label labelNum1;
        private System.Windows.Forms.Label labelBalance1;
        private System.Windows.Forms.Label labelBalance2;
        private System.Windows.Forms.Label labelName2;
        private System.Windows.Forms.Label labelNum2;
        private System.Windows.Forms.RadioButton radioButtonZhi;
        private System.Windows.Forms.RadioButton radioButtonWei;
        private System.Windows.Forms.Button buttonY;
        private System.Windows.Forms.Button buttonN;
    }
}