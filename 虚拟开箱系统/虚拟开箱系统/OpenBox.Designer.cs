namespace 虚拟开箱系统
{
    partial class OpenBox
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonMarket = new System.Windows.Forms.Button();
            this.buttonUserInfo = new System.Windows.Forms.Button();
            this.buttonCharge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonStart.Font = new System.Drawing.Font("宋体", 20F);
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStart.Location = new System.Drawing.Point(290, 67);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(207, 138);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "开箱";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonMarket
            // 
            this.buttonMarket.Location = new System.Drawing.Point(150, 310);
            this.buttonMarket.Name = "buttonMarket";
            this.buttonMarket.Size = new System.Drawing.Size(84, 33);
            this.buttonMarket.TabIndex = 1;
            this.buttonMarket.Text = "进入商城";
            this.buttonMarket.UseVisualStyleBackColor = true;
            this.buttonMarket.Click += new System.EventHandler(this.buttonMarket_Click);
            // 
            // buttonUserInfo
            // 
            this.buttonUserInfo.Location = new System.Drawing.Point(344, 310);
            this.buttonUserInfo.Name = "buttonUserInfo";
            this.buttonUserInfo.Size = new System.Drawing.Size(84, 33);
            this.buttonUserInfo.TabIndex = 2;
            this.buttonUserInfo.Text = "我的库存";
            this.buttonUserInfo.UseVisualStyleBackColor = true;
            this.buttonUserInfo.Click += new System.EventHandler(this.buttonItem_Click);
            // 
            // buttonCharge
            // 
            this.buttonCharge.Location = new System.Drawing.Point(538, 310);
            this.buttonCharge.Name = "buttonCharge";
            this.buttonCharge.Size = new System.Drawing.Size(84, 33);
            this.buttonCharge.TabIndex = 3;
            this.buttonCharge.Text = "余额充值";
            this.buttonCharge.UseVisualStyleBackColor = true;
            this.buttonCharge.Click += new System.EventHandler(this.buttonCharge_Click);
            // 
            // OpenBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCharge);
            this.Controls.Add(this.buttonUserInfo);
            this.Controls.Add(this.buttonMarket);
            this.Controls.Add(this.buttonStart);
            this.Name = "OpenBox";
            this.Text = "开箱选项";
            this.Load += new System.EventHandler(this.OpenBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonMarket;
        private System.Windows.Forms.Button buttonUserInfo;
        private System.Windows.Forms.Button buttonCharge;
    }
}