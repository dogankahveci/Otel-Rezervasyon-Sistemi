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
    public partial class CustomerUpdateForm : Form
    {
        Customer _customer; 
        CustomerController _cuc;
        ContactController _coc;
        ContactAddForm _contactAddForm;
        ContactUpdateForm _contactUpdateform;
        Mesaj _mesaj = new Mesaj();
   
        
        public CustomerUpdateForm(Customer customer)
        {
           
            _customer = customer;
            _cuc = new CustomerController();
            _coc = new ContactController();
            InitializeComponent();
        }
      
        
        private void CustomerUpdateForm_Load(object sender, EventArgs e)
        {
            
            txtCustomerName.Text = _customer.CustomerName;
            txtCustomerLastName.Text = _customer.CustomerLastName;
            txtCustomerIdentity.Text = _customer.IdentityNumber;

            _customer = _cuc.Get(_customer.CustomerId);
            CustomerContactlist();

        }

     

        private void btnSave_Click(object sender, EventArgs e)
        {

        } 

        private void btnAddAdress_Click(object sender, EventArgs e)
        {
          _contactAddForm  = new ContactAddForm();
           _contactAddForm.MdiParent = this.MdiParent;
           Button btn = (Button)_contactAddForm.Controls["btnSave"];
            btn.Click += Btn_Click;
            _contactAddForm.Show();

            
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Form frm = (Form)btn.Parent;
            Contact contact = new Contact();
            contact.Adress = frm.Controls["txtAdress"].Text;
            contact.Tel = frm.Controls["txtTel"].Text;
            contact.Email = frm.Controls["txtEmail"].Text;
            contact.CustomerId = _customer.CustomerId;
            bool isSave = true;
            Mesaj mesaj = new Mesaj();
            if (!Helper.IsTelephoneNumber(contact.Tel))
            {
                isSave = false;
                mesaj.Content =  mesaj.Content+"\n-Lütfen Uygun bir Tel numarası girin";
            }
            if (!Helper.IsEmail(contact.Email))
            {
                isSave = false;
                mesaj.Content = mesaj.Content+"\n-Lütfen Uygun bir Email Adresi giriniz";
            }
            if (isSave)
            {
                _mesaj = _coc.Insert(contact);
                Helper.ShowMessage(_mesaj);
                CustomerContactlist();
            }
          
            else
            {
        
                Helper.ShowMessage(mesaj);
            }


        }

        public  void CustomerContactlist()
        {
            lstCustomerContactUpdate.Items.Clear();
            List<Contact> CustomerAdressList = _coc.GetByCustomerIdActive(_customer.CustomerId);
            foreach (var customeradres in CustomerAdressList)
            {
                ListViewItem li = new ListViewItem();
                li.Tag = customeradres;
                li.Text = customeradres.Adress;
                li.SubItems.Add(customeradres.Tel);
                li.SubItems.Add(customeradres.Email);
                lstCustomerContactUpdate.Items.Add(li);
            }
        }

      

       

        private void btnDeleteAdress_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstCustomerContactUpdate.SelectedItems[0]!=null)
                {
                    Contact contact = (Contact)lstCustomerContactUpdate.SelectedItems[0].Tag;
                    _mesaj = _coc.IsActiveSituation(contact);
                    Helper.ShowMessage(_mesaj);
                    CustomerContactlist();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Herhangi bir kayıt seçmediniz","Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.OnlyText( sender, e);
        }

        private void txtCustomerLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.OnlyText(sender, e);
        }

        private void txtCustomerIdentity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.OnlyNumber(sender,e);
        }

        private void BtnUpdateAdress_Click(object sender, EventArgs e)
        {
            try
            {
                Contact contact = (Contact)lstCustomerContactUpdate.SelectedItems[0].Tag;
                _contactUpdateform = new ContactUpdateForm(contact);
                Button buttonUpdate = (Button)_contactUpdateform.Controls["btnSave"];
                buttonUpdate.Click += ButtonUpdate_Click;
                _contactUpdateform.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Herhangi bir kayıt seçmediniz", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }//2 tane sıkıntı var update ekledikten sonra mesaj vermemeye başladı birde mesajı verirken hem tel mesajını verıyor hemde email aynı anda eğer girilen bir telefon numarası değil ise verir. biz belirli bir karakterin altındaki girişleri de kabul etmedik regex ile.. şuan o mesaj verme işini cozelim istersen suan göstermiyor ok.burda bişe sorcam Emaile tel düşüyor tele email :D:D veriler dogru geliyor acaba goruntudemi bi sıkıntı yaptım 

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {// burayı kendim yazdım kopy cektım tabiki :D
            Button btn = sender as Button;
            Form frm = (Form)btn.Parent;
            Contact contact = new Contact();
            contact.Adress = frm.Controls["txtAdress"].Text;
            contact.Tel = frm.Controls["txtTel"].Text;
            contact.Email = frm.Controls["txtEmail"].Text;
            contact.CustomerId = _customer.CustomerId;
            bool isSave = true;
            Mesaj mesaj = new Mesaj();
            if (!Helper.IsTelephoneNumber(contact.Tel))
            {
                isSave = false;
                mesaj.Content = "Lütfen Uygun bir Tel numarası girin";
            }
            if (!Helper.IsEmail(contact.Email))
            {
                isSave = false;
                mesaj.Content = "Lütfen Uygun bir Email Adresi giriniz";
            }
            if (isSave)
            {
                _mesaj = _coc.Update(contact);
                Helper.ShowMessage(_mesaj);
                CustomerContactlist();
            }
            else
            {
                Helper.ShowMessage(mesaj);
            }

        }
    }
}
