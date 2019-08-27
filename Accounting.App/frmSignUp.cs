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

namespace Accounting.App
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

   

        private void Btnsubmit_Click(object sender, EventArgs e)
        {
            using (UnitofWork db = new UnitofWork())
            {
                if (BaseValidator.IsFormValid(this.components))
                {
                    if (Txtrepeatpassword.Text != TxtPassword.Text)
                    {
                        RtlMessageBox.Show("لطفا کلمه عبور را دوباره وارد کنید");
                        Txtrepeatpassword.Focus();
                        Txtrepeatpassword.SelectAll();
                    }
                    else
                    {
                        DataLayer.Login login = new DataLayer.Login()
                        {
                            FullName = TxtName.Text,
                            UserName = TxtUsername.Text,
                            Password = TxtPassword.Text
                        };
                        if (db.LoginRepository.GetAll(l=> l.UserName==TxtUsername.Text).Any()==false)
                        {
                            db.LoginRepository.Insert(login);
                        }
                        db.Save();
                        Application.Restart();
                        DialogResult = DialogResult.OK;
                    }

                }
            }
        }
    }
}
