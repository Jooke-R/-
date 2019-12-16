namespace 虚拟开箱系统
{
    partial class Sale
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelName2 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonY = new System.Windows.Forms.Button();
            this.buttonN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("宋体", 15F);
            this.labelTitle.Location = new System.Drawing.Point(255, 45);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(89, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "上架物品";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("宋体", 12F);
            this.labelName.Location = new System.Drawing.Point(103, 128);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(72, 16);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "物品名称";
            // 
            // labelName2
            // 
            this.labelName2.AutoSize = true;
            this.labelName2.Font = new System.Drawing.Font("宋体", 12F);
            this.labelName2.Location = new System.Drawing.Point(231, 128);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(56, 16);
            this.labelName2.TabIndex = 2;
            this.labelName2.Text = "label1";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("宋体", 12F);
            this.labelPrice.Location = new System.Drawing.Point(104, 202);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(72, 16);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "物品价格";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(234, 197);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(119, 21);
            this.textBoxPrice.TabIndex = 5;
            // 
            // buttonY
            // 
            this.buttonY.Location = new System.Drawing.Point(123, 275);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(90, 35);
            this.buttonY.TabIndex = 6;
            this.buttonY.Text = "确认上架";
            this.buttonY.UseVisualStyleBackColor = true;
            this.buttonY.Click += new System.EventHandler(this.buttonY_Click);
            // 
            // buttonN
            // 
            this.buttonN.Location = new System.Drawing.Point(423, 275);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(90, 35);
            this.buttonN.TabIndex = 7;
            this.buttonN.Text = "取消";
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(423, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.BackColor = System.Drawing.SystemColors.Control;
            this.labelTip.ForeColor = System.Drawing.Color.Red;
            this.labelTip.Location = new System.Drawing.Point(190, 226);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(209, 12);
            this.labelTip.TabIndex = 9;
            this.labelTip.Text = "此为推荐售价，且成交后收取5%手续费";
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 336);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonN);
            this.Controls.Add(this.buttonY);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelName2);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelTitle);
            this.Name = "Sale";
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelName2;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonY;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTip;
    }
}