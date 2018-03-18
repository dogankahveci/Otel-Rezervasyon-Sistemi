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
    public partial class RoomAddForm : Form
    {
        RoomController _rc;
        Room _room = new Room();
        Mesaj _mesaj = new Mesaj();
       
        public RoomAddForm()
        {
            _rc = new RoomController();   
            InitializeComponent();
        }

       

    



        private void RoomAddForm_Load(object sender, EventArgs e)
        {

        }

        public void fillinRoom(Room _room)
        {
            _room.RoomNumber = txtRoomNumber.Text;
            _room.RoomCost = decimal.Parse(txtRoomPrice.Text);
            _room.Capacity =byte.Parse(txtRoomCapacity.Text);
        }
       
       
       


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            fillinRoom(_room);
           _mesaj= _rc.Insert(_room);
            Helper.ShowMessage(_mesaj);
            this.Close();
        }

        

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRoomPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.OnlyNumber(sender, e);
        }

        private void txtRoomCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.OnlyNumber(sender, e);
        }

        private void txtRoomNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.OnlyNumber(sender, e);
        }
    }
}
