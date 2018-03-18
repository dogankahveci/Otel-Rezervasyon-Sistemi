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
    public partial class RoomListForm : Form
    {   RoomController _rc;
        Mesaj _mesaj = new Mesaj();
        Room _room = new Room();
        public RoomListForm()
        {
            _rc = new RoomController();  
            InitializeComponent();
        }

        private void RoomListForm_Load(object sender, EventArgs e)
        {

            RoomList();
        }

        private void RoomList()
        {
            lstRoomView.Items.Clear();
            List<Room> Rooms = _rc.GetAllByIsActive();
            foreach (var room in Rooms)
            {
                    ListViewItem li = new ListViewItem();
                    li.Tag = room;
                    li.Text = room.RoomNumber;
                    li.SubItems.Add(room.RoomCost.ToString());
                    li.SubItems.Add(room.Capacity.ToString());
                    lstRoomView.Items.Add(li);
            }
        }

        


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _room = (Room)lstRoomView.SelectedItems[0].Tag;
                RoomUpdateForm roomUpdateform = new RoomUpdateForm(_room);
                roomUpdateform.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Herhangi bir kayıt seçmediniz", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }
        
        private void RoomListForm_Click(object sender, EventArgs e)
        {
            RoomList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstRoomView.SelectedItems[0] != null)
                {
                    _room = (Room)lstRoomView.SelectedItems[0].Tag;
                    _mesaj = _rc.IsActiveSituation(_room);
                    Helper.ShowMessage(_mesaj);
                    RoomList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Herhangi bir kayıt seçmediniz", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
