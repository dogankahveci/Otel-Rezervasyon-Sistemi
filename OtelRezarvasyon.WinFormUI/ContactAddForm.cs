using OtelRezarvasyon.BLL;
using OtelRezarvasyon.DTO;
using OtelRezarvasyon.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezarvasyon.WinFormUI
{
    public partial class ContactAddForm : Form
    {
      

        public ContactAddForm()
        {           
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //this.Hide(); // burası sıkıntı..
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAdress_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.OnlyText(sender,e);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.OnlyNumber(sender,e);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.IsEmail(txtEmail.Text);
        }
    }
}
