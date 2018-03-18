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
    public partial class RoomUpdateForm : Form
    {
        Room _room;
        RoomController _rc;
        Mesaj _mesaj = new Mesaj();
        public RoomUpdateForm(Room room)
        {
            _rc = new RoomController();
            _room = room;
            InitializeComponent();
        }
        
        private void RoomUpdateForm_Load(object sender, EventArgs e)
        {

            txtRoomNumber.Text = _room.RoomNumber;
            txtRoomCost.Text = _room.RoomCost.ToString();
            txtRoomCapacity.Text = _room.Capacity.ToString();

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            _room.RoomNumber =txtRoomNumber.Text;
            _room.RoomCost  =decimal.Parse(txtRoomCost.Text);
            _room.Capacity = byte.Parse(txtRoomCapacity.Text);
            _mesaj = _rc.Update(_room);
            Helper.ShowMessage(_mesaj);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
