using Accounting.DataLayer;
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
using ValidationComponents;
using Accounting.DataLayer.Services;

namespace Accounting.App.productForms
{
    public partial class frmADDorEDITproduct : Form
    {
        public frmADDorEDITproduct()
        {
            InitializeComponent();
        }

        public bool IsEdit = false;

        public void bindgrid()
        {
            using (UnitofWork db = new UnitofWork())
            {
                MydataGridView.AutoGenerateColumns = false;
                MydataGridView.DataSource = db.ProductRepositories.GetProductName(TxtFilter.Text);
            }
        }
        private void frmADDorEDITproduct_Load(object sender, EventArgs e)
        {
            bindgrid();
            if (IsEdit == true)
            {
                this.Text = "ویرایش کالا";
                BtnSubmit.Text = "ویرایش";
                TxtProductName.ReadOnly = true;
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            using (UnitofWork db = new UnitofWork())
            {
                if (BaseValidator.IsFormValid(this.components))
                {
                    
                    DataLayer.Product product = new DataLayer.Product()
                    {
                        ProductName = TxtProductName.Text,
                        Unit = TxtUnit.Text,
                        QTY = int.Parse(NumQTY.Value.ToString()),
                        Price = int.Parse(NumPrice.Value.ToString())
                    };
                    if (IsEdit == false)
                    {
                        db.ProductRepository.Insert(product);
                    }
                    else
                    {
                        int id = Convert.ToInt32(MydataGridView.CurrentRow.Cells[0].Value.ToString());
                        
                        product.ProductID = id;
                        db.ProductRepository.Update(product);
                    }

                }
                db.Save();
                
                DialogResult = DialogResult.OK;
                bindgrid();

            }
        }

        private void MydataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id =int.Parse(MydataGridView.CurrentRow.Cells[0].Value.ToString());
            using (UnitofWork db = new UnitofWork())
            {

                var res = db.ProductRepository.GetById(id);
                //(p =>
                //  p.ProductName == MydataGridView.CurrentRow.Cells[1].Value.ToString() &&
                //  p.ProductID ==int.Parse(MydataGridView.CurrentRow.Cells[0].Value.ToString()));

                TxtUnit.Text = res.Unit;
                NumPrice.Value = Convert.ToDecimal(res.Price); 
                NumQTY.Value = Convert.ToDecimal(res.QTY);
                TxtProductName.Text = res.ProductName;

            }
            //TxtProductName.Text = MydataGridView.CurrentRow.Cells[1].Value.ToString();
            


        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitofWork db = new UnitofWork())
            {
                MydataGridView.AutoGenerateColumns = false;
                MydataGridView.DataSource = db.ProductRepositories.GetProductName(TxtFilter.Text);
            }
        }
    }
}
