namespace Accounting.App
{
    partial class frmProduct
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnWereHouse = new System.Windows.Forms.ToolStripButton();
            this.BtnNewFactor = new System.Windows.Forms.ToolStripButton();
            this.BtnFactors = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnWereHouse,
            this.BtnNewFactor,
            this.BtnFactors});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(682, 67);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnWereHouse
            // 
            this.BtnWereHouse.Image = global::Accounting.App.Properties.Resources._1371476049_fork3;
            this.BtnWereHouse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnWereHouse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnWereHouse.Name = "BtnWereHouse";
            this.BtnWereHouse.Size = new System.Drawing.Size(44, 64);
            this.BtnWereHouse.Text = "انبار";
            this.BtnWereHouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnWereHouse.Click += new System.EventHandler(this.BtnWereHouse_Click);
            // 
            // BtnNewFactor
            // 
            this.BtnNewFactor.Image = global::Accounting.App.Properties.Resources._1371475930_filenew;
            this.BtnNewFactor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnNewFactor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNewFactor.Name = "BtnNewFactor";
            this.BtnNewFactor.Size = new System.Drawing.Size(86, 64);
            this.BtnNewFactor.Text = "فاکتور جدید";
            this.BtnNewFactor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNewFactor.Click += new System.EventHandler(this.BtnNewFactor_Click);
            // 
            // BtnFactors
            // 
            this.BtnFactors.Image = global::Accounting.App.Properties.Resources.list2;
            this.BtnFactors.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnFactors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFactors.Name = "BtnFactors";
            this.BtnFactors.Size = new System.Drawing.Size(65, 64);
            this.BtnFactors.Text = "فاکتورها";
            this.BtnFactors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "کالا";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnWereHouse;
        private System.Windows.Forms.ToolStripButton BtnNewFactor;
        private System.Windows.Forms.ToolStripButton BtnFactors;
    }
}