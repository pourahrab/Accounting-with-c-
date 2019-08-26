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
using Accounting.DataLayer;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;
using Accounting.DataLayer.Contex;
using System.IO;
using Accounting.App;
namespace Accounting.App
{
    public partial class frmADDorEDIT : Form
    {
        public int customerId = 0;
        UnitofWork db = new UnitofWork();
        public frmADDorEDIT()
        {
            InitializeComponent();
        }

        private void BtnSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog MyOFD = new OpenFileDialog();
            if (MyOFD.ShowDialog()==DialogResult.OK)
            {
                MypictureBox.ImageLocation = MyOFD.FileName;
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //if (BaseValidator.IsFormValid(this.components))
            if (TxtName.Text != null)
            {
                if (TxtMobile.Text != null)
                {
                    string Path = Application.StartupPath + "/Images/";
                    string ImageName = Guid.NewGuid() + System.IO.Path.GetExtension(MypictureBox.ImageLocation);

                    if (!Directory.Exists(Path))
                    {
                        Directory.CreateDirectory(Path);
                    }

                    MypictureBox.Image.Save(Path + ImageName);


                    Customers customers = new Customers()
                    {
                        FullName = TxtName.Text,
                        Mobile = TxtMobile.Text,
                        Email = TxtEmail.Text,
                        Address = TxtAddress.Text,
                        CustomerImage = "no"
                    };
                    if (customerId == 0)
                    {
                        db.CustomerRepository.InsertCustomer(customers);
                    }
                    else
                    {
                        customers.CustomerID = customerId;
                        db.CustomerRepository.UpdateCustomer(customers);
                    }
                    db.Save();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    RtlMessageBox.Show("لطفا شماره موبایل را وارد کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا شماره نام" +
                    "را وارد کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                
            
        }

        private void frmADDorEDIT_Load(object sender, EventArgs e)
        {
            if (customerId != 0)
            {
                this.Text = "ویرایش شخص";
                BtnSubmit.Text = "ویرایش";
                var customer = db.CustomerRepository.GetCustomerById(customerId);
                TxtName.Text = customer.FullName;
                TxtMobile.Text = customer.Mobile;
                TxtEmail.Text = customer.Email;
                TxtAddress.Text = customer.Address;
                MypictureBox.ImageLocation = Application.StartupPath + "/Images/" + customer.CustomerImage;
            }
        }

      
    }
}
