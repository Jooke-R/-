namespace 虚拟开箱系统
{
    partial class UserInfo
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
            this.labelName1 = new System.Windows.Forms.Label();
            this.labelBank = new System.Windows.Forms.Label();
            this.buttonSale = new System.Windows.Forms.Button();
            this.buttonCharge = new System.Windows.Forms.Button();
            this.labelName2 = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelBalance2 = new System.Windows.Forms.Label();
            this.buttonMarket = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonUnSale = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName1
            // 
            this.labelName1.AutoSize = true;
            this.labelName1.Font = new System.Drawing.Font("宋体", 12F);
            this.labelName1.Location = new System.Drawing.Point(44, 50);
            this.labelName1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName1.Name = "labelName1";
            this.labelName1.Size = new System.Drawing.Size(56, 16);
            this.labelName1.TabIndex = 0;
            this.labelName1.Text = "用户名";
            // 
            // labelBank
            // 
            this.labelBank.AutoSize = true;
            this.labelBank.Font = new System.Drawing.Font("宋体", 12F);
            this.labelBank.Location = new System.Drawing.Point(44, 106);
            this.labelBank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBank.Name = "labelBank";
            this.labelBank.Size = new System.Drawing.Size(40, 16);
            this.labelBank.TabIndex = 1;
            this.labelBank.Text = "库存";
            // 
            // buttonSale
            // 
            this.buttonSale.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonSale.Location = new System.Drawing.Point(611, 47);
            this.buttonSale.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSale.Name = "buttonSale";
            this.buttonSale.Size = new System.Drawing.Size(85, 30);
            this.buttonSale.TabIndex = 3;
            this.buttonSale.Text = "上架物品";
            this.buttonSale.UseVisualStyleBackColor = true;
            this.buttonSale.Click += new System.EventHandler(this.buttonSale_Click);
            // 
            // buttonCharge
            // 
            this.buttonCharge.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonCharge.Location = new System.Drawing.Point(443, 92);
            this.buttonCharge.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCharge.Name = "buttonCharge";
            this.buttonCharge.Size = new System.Drawing.Size(85, 30);
            this.buttonCharge.TabIndex = 4;
            this.buttonCharge.Text = "充值";
            this.buttonCharge.UseVisualStyleBackColor = true;
            this.buttonCharge.Click += new System.EventHandler(this.buttonCharge_Click);
            // 
            // labelName2
            // 
            this.labelName2.AutoSize = true;
            this.labelName2.Font = new System.Drawing.Font("宋体", 12F);
            this.labelName2.Location = new System.Drawing.Point(133, 50);
            this.labelName2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(40, 16);
            this.labelName2.TabIndex = 5;
            this.labelName2.Text = "Name";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("宋体", 12F);
            this.labelBalance.Location = new System.Drawing.Point(346, 50);
            this.labelBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(72, 16);
            this.labelBalance.TabIndex = 6;
            this.labelBalance.Text = "账户余额";
            // 
            // labelBalance2
            // 
            this.labelBalance2.AutoSize = true;
            this.labelBalance2.Font = new System.Drawing.Font("宋体", 12F);
            this.labelBalance2.Location = new System.Drawing.Point(458, 50);
            this.labelBalance2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBalance2.Name = "labelBalance2";
            this.labelBalance2.Size = new System.Drawing.Size(56, 16);
            this.labelBalance2.TabIndex = 7;
            this.labelBalance2.Text = "Remain";
            // 
            // buttonMarket
            // 
            this.buttonMarket.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonMarket.Location = new System.Drawing.Point(113, 92);
            this.buttonMarket.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMarket.Name = "buttonMarket";
            this.buttonMarket.Size = new System.Drawing.Size(85, 30);
            this.buttonMarket.TabIndex = 8;
            this.buttonMarket.Text = "市场";
            this.buttonMarket.UseVisualStyleBackColor = true;
            this.buttonMarket.Click += new System.EventHandler(this.buttonMarket_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(560, 215);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.type,
            this.color,
            this.level,
            this.price,
            this.sale});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(47, 134);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(495, 280);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "编号";
            // 
            // type
            // 
            this.type.Text = "类型";
            this.type.Width = 83;
            // 
            // color
            // 
            this.color.Text = "涂装";
            this.color.Width = 93;
            // 
            // level
            // 
            this.level.Text = "等级";
            this.level.Width = 76;
            // 
            // price
            // 
            this.price.Text = "价格";
            this.price.Width = 95;
            // 
            // sale
            // 
            this.sale.Text = "上架状态";
            this.sale.Width = 84;
            // 
            // buttonUnSale
            // 
            this.buttonUnSale.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonUnSale.Location = new System.Drawing.Point(611, 92);
            this.buttonUnSale.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUnSale.Name = "buttonUnSale";
            this.buttonUnSale.Size = new System.Drawing.Size(85, 30);
            this.buttonUnSale.TabIndex = 11;
            this.buttonUnSale.Text = "下架物品";
            this.buttonUnSale.UseVisualStyleBackColor = true;
            this.buttonUnSale.Click += new System.EventHandler(this.buttonUnSale_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonOpen.Location = new System.Drawing.Point(611, 137);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(85, 30);
            this.buttonOpen.TabIndex = 12;
            this.buttonOpen.Text = "开箱";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 447);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonUnSale);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonMarket);
            this.Controls.Add(this.labelBalance2);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.labelName2);
            this.Controls.Add(this.buttonCharge);
            this.Controls.Add(this.buttonSale);
            this.Controls.Add(this.labelBank);
            this.Controls.Add(this.labelName1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "UserInfo";
            this.Text = "用户信息";
            this.Activated += new System.EventHandler(this.UserInfo_Activated);
            this.Load += new System.EventHandler(this.UserInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName1;
        private System.Windows.Forms.Label labelBank;
        private System.Windows.Forms.Button buttonSale;
        private System.Windows.Forms.Button buttonCharge;
        private System.Windows.Forms.Label labelName2;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelBalance2;
        private System.Windows.Forms.Button buttonMarket;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader color;
        private System.Windows.Forms.ColumnHeader level;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader sale;
        private System.Windows.Forms.Button buttonUnSale;
        private System.Windows.Forms.Button buttonOpen;
    }
}