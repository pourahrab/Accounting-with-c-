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

namespace Accounting.App.productForms
{
    public partial class frmNewFactor : Form
    {
        public frmNewFactor()
        {
            InitializeComponent();
        }

        private void Btnsubmit_Click(object sender, EventArgs e)
        {
            using (UnitofWork db = new UnitofWork())
            {
                DataTable dt = new DataTable();
                List<DataLayer.Factors> factor = new List<DataLayer.Factors>
                {


                };
            }


        }
    }
}
