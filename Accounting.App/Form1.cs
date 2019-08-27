using Accounting.Utility.Convertor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomers Myfrm = new frmCustomers();
            Myfrm.ShowDialog();
        }

        private void BtnNewTransaction_Click(object sender, EventArgs e)
        {
            frmTransaction Myfrm = new frmTransaction();
            Myfrm.ShowDialog();
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            frmReport myfrm = new frmReport();
            myfrm.TypeID = 2;
            myfrm.ShowDialog();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            frmReport myfrm = new frmReport();
            myfrm.TypeID = 1;
            myfrm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

          this.Hide();
            frmLogin myfrm = new frmLogin();
            if (myfrm.ShowDialog()==DialogResult.OK)
            {
                this.Show();
                Lbldate.Text = DateTime.Now.ToShamsi();
                timer1.Start();
            }
            else
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void BtnEtitLogin_Click(object sender, EventArgs e)
        {
            frmLogin Myfrm = new frmLogin();
            Myfrm.IsEdit = true;
            Myfrm.ShowDialog();
        }

        private void BtnsignUP_Click(object sender, EventArgs e)
        {
            frmSignUp myfrm = new frmSignUp();
            myfrm.StartPosition = FormStartPosition.CenterScreen;
            myfrm.ShowDialog();
        }

        private void BtnProduct_Click(object sender, EventArgs e)
        {
            frmProduct myfrm = new frmProduct();
            myfrm.ShowDialog();
        }
    }
}
