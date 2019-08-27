using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer;
using Accounting.DataLayer.Contex;

namespace Accounting.App
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            Bindgrid();
        }

        private void Bindgrid()
        {
            using (UnitofWork db = new UnitofWork())
            {
                MydataGridView.AutoGenerateColumns = false;
                MydataGridView.DataSource = db.CustomerRepository.GetAllCustomers();
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            TxtFilter.Text = "";
            Bindgrid();
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitofWork db = new UnitofWork())
            {
                MydataGridView.DataSource = db.CustomerRepository.GetCustomersByFilter(TxtFilter.Text);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MydataGridView.CurrentRow != null)
            {              
                using (UnitofWork db = new UnitofWork())
                {
                    string name = MydataGridView.CurrentRow.Cells[1].Value.ToString();
                    if (RtlMessageBox.Show($"ایا از حذف {name} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int customerId = int.Parse(MydataGridView.CurrentRow.Cells[0].Value.ToString());
                        db.CustomerRepository.DeleteCustomer(customerId);
                        db.Save();
                        Bindgrid();
                    }
                }
                    
            }
            else
            {
                RtlMessageBox.Show("لطفا شخص مورد نظر را انتخاب کنید");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            frmADDorEDIT myfrm = new frmADDorEDIT();
            if(myfrm.ShowDialog()==DialogResult.OK)
            {
                Bindgrid();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if(MydataGridView.CurrentRow!= null)
            {
                int customerId = int.Parse(MydataGridView.CurrentRow.Cells[0].Value.ToString());
                frmADDorEDIT myfrm = new frmADDorEDIT();
                myfrm.customerId = customerId;
                if (myfrm.ShowDialog()==DialogResult.OK)
                {
                    Bindgrid();
                }
                    
            }
        }
    }
}
