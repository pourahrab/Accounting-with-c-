using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer.Contex;
using ValidationComponents;

namespace Accounting.App
{
    public partial class frmTransaction : Form
    {
        private UnitofWork db;

        public int AccountId = 0;

        public frmTransaction()
        {
            InitializeComponent();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            db = new UnitofWork();
            MydataGridView.AutoGenerateColumns = false;
            MydataGridView.DataSource = db.CustomerRepository.GetCustomersName();
            if (AccountId != 0)
            {

                var Account = db.accountingrepository.GetById(AccountId);
                NumericAmount.Value = Convert.ToDecimal(Account.Amount.ToString());
                TxtDecription.Text = Account.Description;
                TxtName.Text = db.CustomerRepository.GetCustomerNameById(Account.CustomerID);
                if (Account.TypeID == 1)
                {
                    RbtnIncome.Checked = true;
                }
                else
                {
                    RbtnOutgoing.Checked = true;
                }
                this.Text = "ویرایش";
                BtnSubmit.Text = "ویرایش";
            }
            db.Dispose();
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            db = new UnitofWork();
            MydataGridView.AutoGenerateColumns = false;
            MydataGridView.DataSource = db.CustomerRepository.GetCustomersName(TxtFilter.Text);
            db.Dispose();
        }

        private void MydataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtName.Text = MydataGridView.CurrentRow.Cells[0].Value.ToString();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (RbtnIncome.Checked || RbtnOutgoing.Checked)
                {
                    db = new UnitofWork();
                    DataLayer.Accounting accounting = new DataLayer.Accounting()
                    {
                        Amount = int.Parse(NumericAmount.Value.ToString()),
                        TypeID = (RbtnIncome.Checked) ? 1 : 2,
                        CustomerID = db.CustomerRepository.GetCustomerIdByName(TxtName.Text),
                        Description = TxtDecription.Text,
                        Datetime = DateTime.Now
                    };
                    if (AccountId == 0)
                    {
                        db.accountingrepository.Insert(accounting);

                    }
                    else
                    {

                        accounting.AccID = AccountId;
                        db.accountingrepository.Update(accounting);
                    }

                    db.Save();
                    db.Dispose();
                    DialogResult = DialogResult.OK;
                    
                }
                else
                {
                    RtlMessageBox.Show("لطفا نوع تراکنش را انتخاب کنید");
                }
            }
        }
    }
}
