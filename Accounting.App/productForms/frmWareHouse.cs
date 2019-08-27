using Accounting.App.productForms;
using Accounting.DataLayer.Contex;
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
    
    public partial class frmWareHouse : Form
    {
        public frmWareHouse()
        {
            InitializeComponent();
        }

        public void bindgrid()
        {
            using (UnitofWork db = new UnitofWork())
            {
                MydataGridView.AutoGenerateColumns = false;
                MydataGridView.DataSource = db.ProductRepository.GetAll(p=> p.ProductName.Contains(Txtfilter.Text));
            }
        }


        private void frmWareHouse_Load(object sender, EventArgs e)
        {
            bindgrid();
            
        }

      

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            frmADDorEDITproduct myfrm = new frmADDorEDITproduct();
            myfrm.ShowDialog();
            if (myfrm.DialogResult==DialogResult.OK)
            {
                bindgrid();
            }
        }

        private void BtnEditProduct_Click(object sender, EventArgs e)
        {
            
            frmADDorEDITproduct myfrm = new frmADDorEDITproduct();
            myfrm.IsEdit = true;
            myfrm.ShowDialog();
            if (myfrm.DialogResult == DialogResult.OK)
            {
                bindgrid();
            }

        }

        private void Txtfilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitofWork db = new UnitofWork())
            {
                MydataGridView.AutoGenerateColumns = false;
                MydataGridView.DataSource = db.ProductRepository.GetAll(p => p.ProductName.Contains(Txtfilter.Text));
            }
        }
    }
}
