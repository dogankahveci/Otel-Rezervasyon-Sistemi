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
    public partial class ContactUpdateForm : Form
    {
        Contact _contact;
        ContactController _coc;
        
        public ContactUpdateForm(Contact contact)  
        {
            _coc = new ContactController();
            _contact = contact;
            InitializeComponent();
        }

       

        private void ContactUpdateForm_Load(object sender, EventArgs e)
        {
            txtAdress.Text = _contact.Adress;
            txtEmail.Text = _contact.Email;
            txtTel.Text = _contact.Tel;
          
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           
            //this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
