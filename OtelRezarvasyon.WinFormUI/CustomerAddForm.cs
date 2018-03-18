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
    public partial class CustomerAddForm : Form
    {
        CustomerController _cuc;
        ContactController _coc;
        ContactAddForm _contactAddForm;
        

        public CustomerAddForm()
        {
        
            _cuc = new CustomerController();
            _coc = new ContactController();
               InitializeComponent();
        }

        private void btnAdress_Click(object sender, EventArgs e)
        {
           _contactAddForm = new ContactAddForm();
            _contactAddForm.MdiParent = this.MdiParent;
            Button btn =(Button) _contactAddForm.Controls["btnSave"];
            btn.Click += Btn_Click;

            _contactAddForm.Show();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Form frm=(Form)btn.Parent;
            string adress= frm.Controls["txtAdress"].Text;
            string tel = frm.Controls["txtTel"].Text;
            string email = frm.Controls["txtEmail"].Text;
            bool isSave = true; //herhangi bir kayıt engelleyen unsur ile karşılaşırsak bunu false yapıp kayıt yapmayacağız.
            Mesaj mesaj = new Mesaj();
            if(!Helper.IsTelephoneNumber(tel))//ben kayıt yapmadan önce telefonu konrol ettim.
            {
                isSave = false;
                mesaj.Content = mesaj.Content + "Lütfen telefon numarasınıuygungiriniz.";
            }

            if(!Helper.IsEmail(email)) 
            {
                isSave = false;
                mesaj.Content = mesaj.Content + "Lütfen Emaili uygun bir şekilde giriniz";
            }
           
            if(isSave)
                
            { 
            ListViewItem li = new ListViewItem();

            li.Text = adress;
            li.SubItems.Add(tel);
            li.SubItems.Add(email);

            lstViewCustContact.Items.Add(li);
            frm.Close();
            }
            else
            {
                frm.Show();
                Helper.ShowMessage(mesaj);
            }
                 
        }



        private Customer FiilinCustomer()
        {
            Customer customer = new Customer();
            customer.CustomerName = txtCustomerName.Text;
            customer.CustomerLastName = txtCustomerLastName.Text;
            customer.IdentityNumber =txtCustomerIdentity.Text;
                  
            if (rdMan.Text=="Erkek")
            {
                customer.Gender = rdMan.Text;
            }
            else
            {
                customer.Gender = rdWoman.Text;
            }
            return customer;          
        }

        private void btnCustomerSave_Click(object sender, EventArgs e)
        {
            
           Customer customer= FiilinCustomer();
            Mesaj mesaj = new Mesaj();
            mesaj = _cuc.Insert(customer);

          foreach (ListViewItem item in lstViewCustContact.Items)
            {
                Contact contact = new Contact();
                contact.Adress = item.SubItems[0].Text;
                contact.Email = item.SubItems[2].Text;
                contact.Tel = item.SubItems[1].Text;
                contact.CustomerId = customer.CustomerId;
                _coc.Insert(contact);
            }

          Helper.ShowMessage(mesaj);
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.OnlyText(sender,e);
        }

        private void txtCustomerLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.OnlyText(sender, e);
        }

        private void txtCustomerIdentity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.OnlyNumber(sender, e);
        }
    }
}
