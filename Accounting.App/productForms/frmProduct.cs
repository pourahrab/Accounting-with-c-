using Accounting.App.productForms;
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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void BtnWereHouse_Click(object sender, EventArgs e)
        {
            frmWareHouse myfrm = new frmWareHouse();
            myfrm.ShowDialog();
        }

        private void BtnNewFactor_Click(object sender, EventArgs e)
        {
            frmNewFactor myfrm = new frmNewFactor();
            myfrm.ShowDialog();
        }
    }
}
