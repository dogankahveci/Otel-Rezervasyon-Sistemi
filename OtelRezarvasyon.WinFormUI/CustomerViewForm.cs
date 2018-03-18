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
    public partial class CustomerViewForm : Form
    {
        CustomerController _cuc;
        ContactController _coc;
        Customer _customer = new Customer();
        Mesaj  _mesaj = new Mesaj();
       
        List<Customer> _customers;
        public CustomerViewForm()
        {
            _coc = new ContactController();
            _cuc = new CustomerController();
               InitializeComponent();
        }

        private void CustomerViewForm_Load(object sender, EventArgs e)
        {
            
            
            _customers= _cuc.GetAllByIsActive();
            CustomerList();
        }

        private void CustomerList() 
        {
            lstCustomerView.Items.Clear();
            
           
            foreach (var customer in _customers)
            { 
                string CustomerAddress ="";
                CustomerAddress = _coc.Get(customer.CustomerId).Adress;
                ListViewItem li = new ListViewItem();
                li.Tag = customer;
                li.Text = customer.CustomerName;
                li.SubItems.Add(customer.CustomerLastName);
                li.SubItems.Add(customer.IdentityNumber);
                li.SubItems.Add(customer.Gender);     
                li.SubItems.Add(CustomerAddress);
                 
         
                lstCustomerView.Items.Add(li);
            }
        }

        private void CustomerList(List<Customer> list) 
        {
            lstCustomerView.Items.Clear();


            foreach (var customer in list)
            {
                string CustomerAddress = "";
                CustomerAddress = _coc.Get(customer.CustomerId).Adress;
                ListViewItem li = new ListViewItem();
                li.Tag = customer;
                li.Text = customer.CustomerName;
                li.SubItems.Add(customer.CustomerLastName);
                li.SubItems.Add(customer.IdentityNumber);
                li.SubItems.Add(customer.Gender);
                li.SubItems.Add(CustomerAddress);


                lstCustomerView.Items.Add(li);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstCustomerView.SelectedItems[0].Tag != null)
                {
                    _customer = (Customer)lstCustomerView.SelectedItems[0].Tag;
                    CustomerUpdateForm cstUpdateForm = new CustomerUpdateForm(_customer);
                    cstUpdateForm.MdiParent = this.MdiParent;
                    cstUpdateForm.Show();
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Herhangi bir kayıt seçmediniz", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstCustomerView.SelectedItems[0] != null)
                {
                    _customer = (Customer)lstCustomerView.SelectedItems[0].Tag;
                    _mesaj = _cuc.IsActiveSituation(_customer);
                    Helper.ShowMessage(_mesaj);
                    //ekleme ve silmede customers değiştiğinden onu veritabanından yeniden çekmemiz lazım..
                    _customers = _cuc.GetAllByIsActive();
                    CustomerList();
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Herhangi bir kayıt seçmediniz", "Silme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
           
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerAddForm customerAddForm = new CustomerAddForm(); //formun instance ını aldın. artık ramde bir nesne
            customerAddForm.MdiParent = this.MdiParent; //onun mdi parentı şu anki formun mdi parenti oldu
            Button btn = (Button)customerAddForm.Controls["btnCustomerSave"]; //ramde bekleyen formun bir controllünü yakaladın.
            btn.Click += Btn_Click; //onun event propertysine bir metot ataması yaptın. 
            //ee form ramde bekliyo 
            customerAddForm.Show(); //ayneeen. şimdi görünür oldu. Anladım  bu click olayını ezbere yapıyorum 
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //ekleme ve silmede customers değiştiğinden onu veritabanından yeniden çekmemiz lazım..
            _customers = _cuc.GetAllByIsActive();
            CustomerList();
            Button btn = sender as Button;
            Form frm = (Form)btn.Parent;
            frm.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            List<Customer> list = Helper.Search(_customers, txtCustomerSearch.Text);
            CustomerList(list);
        }

    }
}
