namespace Accounting.App
{
    partial class frmTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransaction));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MydataGridView = new System.Windows.Forms.DataGridView();
            this.TxtFilter = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.RbtnIncome = new System.Windows.Forms.RadioButton();
            this.RbtnOutgoing = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumericAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDecription = new System.Windows.Forms.TextBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.rangeValidator1 = new ValidationComponents.RangeValidator(this.components);
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MydataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MydataGridView);
            this.groupBox1.Controls.Add(this.TxtFilter);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اشخاص";
            // 
            // MydataGridView
            // 
            this.MydataGridView.AllowUserToAddRows = false;
            this.MydataGridView.AllowUserToDeleteRows = false;
            this.MydataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MydataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.MydataGridView.Location = new System.Drawing.Point(7, 51);
            this.MydataGridView.Name = "MydataGridView";
            this.MydataGridView.ReadOnly = true;
            this.MydataGridView.RowTemplate.Height = 24;
            this.MydataGridView.Size = new System.Drawing.Size(221, 281);
            this.MydataGridView.TabIndex = 1;
            this.MydataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MydataGridView_CellClick);
            // 
            // TxtFilter
            // 
            this.TxtFilter.Location = new System.Drawing.Point(7, 22);
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(221, 23);
            this.TxtFilter.TabIndex = 0;
            this.TxtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FullName";
            this.Column1.HeaderText = "نام شخص";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(537, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "طرف حساب :";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(252, 3);
            this.TxtName.Name = "TxtName";
            this.TxtName.ReadOnly = true;
            this.TxtName.Size = new System.Drawing.Size(274, 23);
            this.TxtName.TabIndex = 2;
            // 
            // RbtnIncome
            // 
            this.RbtnIncome.AutoSize = true;
            this.RbtnIncome.Location = new System.Drawing.Point(454, 43);
            this.RbtnIncome.Name = "RbtnIncome";
            this.RbtnIncome.Size = new System.Drawing.Size(72, 21);
            this.RbtnIncome.TabIndex = 3;
            this.RbtnIncome.TabStop = true;
            this.RbtnIncome.Text = "دریافت ";
            this.RbtnIncome.UseVisualStyleBackColor = true;
            // 
            // RbtnOutgoing
            // 
            this.RbtnOutgoing.AutoSize = true;
            this.RbtnOutgoing.Location = new System.Drawing.Point(377, 43);
            this.RbtnOutgoing.Name = "RbtnOutgoing";
            this.RbtnOutgoing.Size = new System.Drawing.Size(71, 21);
            this.RbtnOutgoing.TabIndex = 3;
            this.RbtnOutgoing.TabStop = true;
            this.RbtnOutgoing.Text = "پرداخت";
            this.RbtnOutgoing.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(542, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "نوع تراکنش :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(577, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "مبلغ :";
            // 
            // NumericAmount
            // 
            this.NumericAmount.Location = new System.Drawing.Point(252, 81);
            this.NumericAmount.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.NumericAmount.Name = "NumericAmount";
            this.NumericAmount.Size = new System.Drawing.Size(283, 23);
            this.NumericAmount.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(573, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "شرح :";
            // 
            // TxtDecription
            // 
            this.TxtDecription.Location = new System.Drawing.Point(252, 136);
            this.TxtDecription.Multiline = true;
            this.TxtDecription.Name = "TxtDecription";
            this.TxtDecription.Size = new System.Drawing.Size(316, 142);
            this.TxtDecription.TabIndex = 5;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(465, 285);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(102, 36);
            this.BtnSubmit.TabIndex = 6;
            this.BtnSubmit.Text = "ثبت";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // rangeValidator1
            // 
            this.rangeValidator1.CancelFocusChangeWhenInvalid = false;
            this.rangeValidator1.ControlToValidate = this.NumericAmount;
            this.rangeValidator1.ErrorMessage = "مبلغ را وارد کنید";
            this.rangeValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("rangeValidator1.Icon")));
            this.rangeValidator1.MaximumValue = "999999999999999";
            this.rangeValidator1.MinimumValue = "1";
            this.rangeValidator1.Type = ValidationComponents.ValidationDataType.Integer;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.TxtName;
            this.requiredFieldValidator1.ErrorMessage = "نام طرف حساب را انتخاب کنید";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 353);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.TxtDecription);
            this.Controls.Add(this.NumericAmount);
            this.Controls.Add(this.RbtnOutgoing);
            this.Controls.Add(this.RbtnIncome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTransaction";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تراکنش جدید";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MydataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView MydataGridView;
        private System.Windows.Forms.TextBox TxtFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.RadioButton RbtnIncome;
        private System.Windows.Forms.RadioButton RbtnOutgoing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumericAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDecription;
        private System.Windows.Forms.Button BtnSubmit;
        private ValidationComponents.RangeValidator rangeValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
    }
}