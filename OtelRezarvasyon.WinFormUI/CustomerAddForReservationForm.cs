using MyUserControls;
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
    public partial class CustomerAddForReservationForm : Form
    {
        int _personelCount;
        List<CustomerRoomDTO> _customersRooms;
        List<Room> _rooms;
        bool cmbsIsLoad = false;

        public CustomerAddForReservationForm(int personelCount, List<Room> rooms, List<CustomerRoomDTO> customersRooms)
        {
            _personelCount = personelCount;
            _customersRooms = customersRooms;
            if(_customersRooms==null)
            {
                _customersRooms = new List<CustomerRoomDTO>();
            }
            _rooms = rooms;
            InitializeComponent();
            
        }

        private void CustomerAddForReservationForm_Load(object sender, EventArgs e)
        {
            flpCustomers.Width = this.Width - 20;
            CustomerInfoLoad();

        }

        private void CustomerInfoLoad()
        {
            for (int i = 0; i < _personelCount; i++)
            {
                CustomerInfo userControl = new CustomerInfo();
                CustomerRoomDTO customerRoom = new CustomerRoomDTO();
                userControl.Tag = customerRoom; 
                ComboBox cmb = (ComboBox)userControl.Controls["cmbRoomNumber"];
                cmb.SelectedIndexChanged += Cmb_SelectedIndexChanged;
                cmb.DisplayMember = "RoomNumber";
                cmb.ValueMember = "RoomId";
                cmb.DataSource = _rooms;
                cmb.SelectedIndex = -1;

                flpCustomers.Controls.Add(userControl);
              
            }
            cmbsIsLoad = true;
        }

        private void Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox cmb = sender as ComboBox;//bu eventi tetikleyen combobox yakalandı.
            if (cmb.SelectedIndex > -1 && cmbsIsLoad)
            {
                CustomerInfo ci = (CustomerInfo)cmb.Parent; 
                CustomerRoomDTO customerRoom = (CustomerRoomDTO)ci.Tag;  

                if (customerRoom.Room != null)
                {
                    customerRoom.Room.Capacity += 1; 
                }

                Room room = _rooms.Where(r => r.RoomId == (int)cmb.SelectedValue).FirstOrDefault(); 
                if (room.Capacity <= 0)
                {
                    Mesaj mesaj = new Mesaj();
                    mesaj.Content = room.RoomNumber + " numaralı oda dolu";
                    mesaj.Color = Color.Red;
                    Helper.ShowMessage(mesaj);
                    room = customerRoom.Room; //yarın bakacaz
                    if (room == null)
                    {
                        cmb.SelectedIndex = -1;
                    }
                    else
                    {
                        cmb.SelectedValue = room.RoomNumber;
                    }

                }
                room.Capacity -= 1; 
                customerRoom.Room = room;
            }

        }

        public void CustomerLoad(CustomerInfo ci)
        {
            CustomerRoomDTO customerRoom = (CustomerRoomDTO)ci.Tag;
            customerRoom.CustomerName = ci.Controls["txtName"].Text;
            customerRoom.CustomerLastName = ci.Controls["txtSurname"].Text;
            customerRoom.IdentityNumber = ci.Controls["txtIdentityNumber"].Text;
            customerRoom.Gender = ((RadioButton)ci.Controls["rdMan"]).Checked == true ? "Erkek" : "Kadın";

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            foreach (var item in flpCustomers.Controls)
            {
                if (item is CustomerInfo) 
                {
                    CustomerInfo ci = (CustomerInfo)item;
                    CustomerLoad(ci);
                   
                    _customersRooms.Add((CustomerRoomDTO)ci.Tag);
                }
            }
          
            Button btn = sender as Button;
            btn.Tag = _customersRooms;
           
        }
    }
}
