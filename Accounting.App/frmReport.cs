using Accounting.DataLayer;
using Accounting.DataLayer.Contex;
using Accounting.Utility.Convertor;
using Accounting.ViewModels.Customers;
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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }
        public int TypeID = 0;

        void Filter()
        {
            using (UnitofWork db = new UnitofWork())
            {
                List<DataLayer.Accounting> Result = new List<DataLayer.Accounting>();
                DateTime? startdate;
                DateTime? enddate;

                if ((int)CbCustomer.SelectedValue != 0)
                {
                    int customerID = int.Parse(CbCustomer.SelectedValue.ToString());
                    Result.AddRange(db.accountingrepository.GetAll(a => a.TypeID == TypeID
                                                                     && a.CustomerID == customerID));
                }
                else
                {
                    Result.AddRange(db.accountingrepository.GetAll(a => a.TypeID == TypeID));
                }


                if (TxtFromDate.Text != "    /  /")
                {
                    startdate = Convert.ToDateTime(TxtFromDate.Text);
                    startdate = DateConvertor.ToMiladi(startdate.Value);
                    Result = Result.Where(d => d.Datetime >= startdate.Value).ToList();

                }

                if (TxtToDate.Text != "    /  /")
                {
                    enddate = Convert.ToDateTime(TxtToDate.Text);
                    enddate = DateConvertor.ToMiladi(enddate.Value);
                    Result = Result.Where(d => d.Datetime <= enddate.Value).ToList();



                }


                MYdataGridView.Rows.Clear();
                foreach (var account in Result)
                {
                    string customerName = db.CustomerRepository.GetCustomerNameById(account.CustomerID);
                    MYdataGridView.Rows.Add(account.AccID, customerName, account.Amount, account.Description, account.Datetime.ToShamsi());
                }
            }
        }
        private void frmReport_Load(object sender, EventArgs e)
        {
            using (UnitofWork db = new UnitofWork())
            {
                List<ListCustomerViewModel> list = new List<ListCustomerViewModel>();
                list.Add(new ListCustomerViewModel()
                {
                    CustomerID = 0,
                    FullName = "انتخاب کنید"
                });
                list.AddRange(db.CustomerRepository.GetCustomersName());
                CbCustomer.DataSource = list;
                CbCustomer.DisplayMember = "FullName";
                CbCustomer.ValueMember = "CustomerID";
            }

            if (TypeID == 1)
            {
                this.Text = "گزارش دریافتی ها";
            }
            else
            {
                this.Text = " گزارش پرداختی ها";
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (MYdataGridView.CurrentRow != null)
            {
                int id = int.Parse(MYdataGridView.CurrentRow.Cells[0].Value.ToString());
                frmTransaction myfrm = new frmTransaction();
                myfrm.AccountId = id;
                if (myfrm.ShowDialog() == DialogResult.OK)
                {
                    Filter();
                }
            }
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MYdataGridView.CurrentRow != null)
            {
                int id = int.Parse(MYdataGridView.CurrentRow.Cells[0].Value.ToString());
                if (RtlMessageBox.Show("ایا از حذف شخص مطمئن هستید", "توجه"
                                         , MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (UnitofWork db = new UnitofWork())
                    {
                        db.accountingrepository.Delete(id);
                        db.Save();
                        Filter();
                    }
                }
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Filter();
        }
    }
}
