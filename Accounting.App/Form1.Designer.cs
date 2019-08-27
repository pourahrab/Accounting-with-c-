namespace Accounting.App
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Lbldate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCustomer = new System.Windows.Forms.ToolStripButton();
            this.BtnNewTransaction = new System.Windows.Forms.ToolStripButton();
            this.BtnPay = new System.Windows.Forms.ToolStripButton();
            this.btnIncome = new System.Windows.Forms.ToolStripButton();
            this.BtnProduct = new System.Windows.Forms.ToolStripButton();
            this.BtnEditLogin = new System.Windows.Forms.ToolStripDropDownButton();
            this.BtnEtitLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnsignUP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnEditLogin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(782, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCustomer,
            this.BtnNewTransaction,
            this.BtnPay,
            this.btnIncome,
            this.BtnProduct});
            this.toolStrip2.Location = new System.Drawing.Point(0, 27);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(782, 73);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Lbldate,
            this.toolStripStatusLabel3,
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 524);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(782, 29);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(54, 24);
            this.toolStripStatusLabel1.Text = "تاریخ : ";
            // 
            // Lbldate
            // 
            this.Lbldate.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)));
            this.Lbldate.Name = "Lbldate";
            this.Lbldate.Size = new System.Drawing.Size(155, 24);
            this.Lbldate.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(60, 24);
            this.toolStripStatusLabel3.Text = "ساعت :";
            // 
            // lblTime
            // 
            this.lblTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)));
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(155, 24);
            this.lblTime.Text = "toolStripStatusLabel4";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Accounting.App.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(25, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 372);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCustomer
            // 
            this.BtnCustomer.Image = global::Accounting.App.Properties.Resources._1371476468_preferences_contact_list;
            this.BtnCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCustomer.Name = "BtnCustomer";
            this.BtnCustomer.Size = new System.Drawing.Size(90, 70);
            this.BtnCustomer.Text = "طرف حساب";
            this.BtnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCustomer.Click += new System.EventHandler(this.BtnCustomer_Click);
            // 
            // BtnNewTransaction
            // 
            this.BtnNewTransaction.AutoSize = false;
            this.BtnNewTransaction.Image = global::Accounting.App.Properties.Resources._1371476499_todo_list;
            this.BtnNewTransaction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnNewTransaction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNewTransaction.Name = "BtnNewTransaction";
            this.BtnNewTransaction.Size = new System.Drawing.Size(90, 70);
            this.BtnNewTransaction.Text = "تراکنش";
            this.BtnNewTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNewTransaction.Click += new System.EventHandler(this.BtnNewTransaction_Click);
            // 
            // BtnPay
            // 
            this.BtnPay.Image = global::Accounting.App.Properties.Resources.servicesCosts;
            this.BtnPay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnPay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(102, 70);
            this.BtnPay.Text = "گزارش پرداخت";
            this.BtnPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.AutoSize = false;
            this.btnIncome.Image = global::Accounting.App.Properties.Resources._1370791030_credit_card;
            this.btnIncome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnIncome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(110, 70);
            this.btnIncome.Text = "گزارش دریافت";
            this.btnIncome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // BtnProduct
            // 
            this.BtnProduct.AutoSize = false;
            this.BtnProduct.Image = global::Accounting.App.Properties.Resources._1371476143_deliverables;
            this.BtnProduct.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnProduct.Name = "BtnProduct";
            this.BtnProduct.Size = new System.Drawing.Size(65, 70);
            this.BtnProduct.Text = "کالا";
            this.BtnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnProduct.Click += new System.EventHandler(this.BtnProduct_Click);
            // 
            // BtnEditLogin
            // 
            this.BtnEditLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnEditLogin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnEtitLogin,
            this.BtnsignUP});
            this.BtnEditLogin.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditLogin.Image")));
            this.BtnEditLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEditLogin.Name = "BtnEditLogin";
            this.BtnEditLogin.Size = new System.Drawing.Size(78, 24);
            this.BtnEditLogin.Text = "تنظیمات";
            // 
            // BtnEtitLogin
            // 
            this.BtnEtitLogin.Name = "BtnEtitLogin";
            this.BtnEtitLogin.Size = new System.Drawing.Size(191, 26);
            this.BtnEtitLogin.Text = "تنظیمات ورود";
            this.BtnEtitLogin.Click += new System.EventHandler(this.BtnEtitLogin_Click);
            // 
            // BtnsignUP
            // 
            this.BtnsignUP.Name = "BtnsignUP";
            this.BtnsignUP.Size = new System.Drawing.Size(191, 26);
            this.BtnsignUP.Text = "ساخت کاربر جدید";
            this.BtnsignUP.Click += new System.EventHandler(this.BtnsignUP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابداری شخصی";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton BtnEditLogin;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton BtnCustomer;
        private System.Windows.Forms.ToolStripButton BtnNewTransaction;
        private System.Windows.Forms.ToolStripButton BtnPay;
        private System.Windows.Forms.ToolStripButton btnIncome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Lbldate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem BtnEtitLogin;
        private System.Windows.Forms.ToolStripMenuItem BtnsignUP;
        private System.Windows.Forms.ToolStripButton BtnProduct;
    }
}

