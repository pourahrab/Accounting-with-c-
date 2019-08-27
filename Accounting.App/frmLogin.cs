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
    public partial class frmLogin : Form
    {
        public bool IsEdit = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                this.Text = "تنظیمات ورود به برنامه";
                BtnLogin.Text = "ذخیره تغییرات";
                BtnSignUp.Text = "لغو";
                using (UnitofWork db = new UnitofWork())
                {
                    var login = db.LoginRepository.GetAll().First();
                    TxtUsername.Text = login.UserName;
                    Txtpassword.Text = login.Password;
                }
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
           
            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitofWork db = new UnitofWork())
                {
                    if (IsEdit)
                    {
                        var Login = db.LoginRepository.GetAll().First();
                        Login.UserName = TxtUsername.Text;
                        Login.Password = Txtpassword.Text;
                        db.LoginRepository.Update(Login);
                        db.Save();
                        Application.Restart();
                    }
                    else
                    {
                        if (db.LoginRepository.GetAll(l =>
                                              l.UserName == TxtUsername.Text &&
                                              l.Password == Txtpassword.Text).Any())
                        {
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            RtlMessageBox.Show("اطلاعات وارد شده صحیح نمیباشد");
                        }
                    }
                }
            }
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            Txtpassword.UseSystemPasswordChar = false;
            
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            Txtpassword.UseSystemPasswordChar = true;
        }

        private void Txtpassword_TextChanged(object sender, EventArgs e)
        {
            Txtpassword.UseSystemPasswordChar = true;
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                frmLogin myfrml = new frmLogin();
                this.Close();
            }
            else
            {
                frmSignUp myfrm = new frmSignUp();
                myfrm.ShowDialog();
            }
        }
    }
}
