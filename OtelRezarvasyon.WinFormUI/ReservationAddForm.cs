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
    public partial class ReservationAddForm : Form
    {
        List<Room> _selectedRooms;
        List<CustomerRoomDTO> _customersRooms;
        public ReservationAddForm()
        {
            InitializeComponent();
        }

        private void btnRoomSelect_Click(object sender, EventArgs e)
        {
            RoomSelectForReservationForm frm = new RoomSelectForReservationForm(dtpEntiringDate.Value,dtpLeavingDate.Value);
            frm.MdiParent = this.MdiParent;
            frm.Controls["btnOk"].Click += RoomSelectOk_Click;
            frm.Show();
        }

        private void RoomSelectOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPersonCount.Text !=null)
                {
                    Button btn = sender as Button;
                    _selectedRooms = (List<Room>)btn.Tag;
                    int customerCount = Convert.ToInt32(txtPersonCount.Text);
                    int roomsCapacity = 0;
                    foreach (var room in _selectedRooms)
                    {
                        roomsCapacity += room.Capacity;
                    }
                    if (customerCount > roomsCapacity)
                    {
                        Mesaj mesaj = new Mesaj();
                        mesaj.Color = Color.Red;
                        mesaj.Content = "Müşteri sayısı oda kapasitesinden fazla";
                        Helper.ShowMessage(mesaj);
                        return;
                    }
                    Form frm = (Form)btn.Parent;
                    frm.Close(); 
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Kisi Sayısı Girmediniz","Bilgilendirme Pencresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            
            CustomerAddForReservationForm frm = new CustomerAddForReservationForm(Convert.ToInt32(txtPersonCount.Text), _selectedRooms,_customersRooms);
            frm.MdiParent = this.MdiParent;
            frm.Controls["btnOk"].Click += CustomersAddOk_Click;
            frm.Show();
        }

        private void CustomersAddOk_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            _customersRooms = (List<CustomerRoomDTO>)btn.Tag;
         

                if(Helper.isFillin(_customersRooms))
                {
                
                Form frm = (Form)btn.Parent;
                frm.Close();
                decimal cost = 0;
                foreach (CustomerRoomDTO customerRoom in _customersRooms)
                {
                    cost += customerRoom.Room.RoomCost;
                }
                txtTotalPrice.Text = cost.ToString();
                }
                else
                {
                    Mesaj mesaj = new Mesaj();
                    mesaj.Content = "Gereken Bilgileri giriniz";
                    mesaj.Color = Color.Red;
                    Helper.ShowMessage(mesaj);
                   

                }
           

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ReservationFullDTO dto = new ReservationFullDTO();
            dto.CheckIn = dtpEntiringDate.Value;
            dto.CheckOut = dtpLeavingDate.Value;
            dto.TCNo = txtCustomerIdentity.Text;
            dto.CustomerName = txtCustomerName.Text;
            dto.CustomerSurname = txtCustomerLastName.Text;
            dto.CustomerRooms = _customersRooms;
            ReservationFullDTOController rc = new ReservationFullDTOController();
            rc.Add(dto);
        }

        private void txtPersonCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.OnlyNumber(sender,e);
        }
    }
}
