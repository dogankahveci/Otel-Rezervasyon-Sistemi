using OtelRezarvasyon.BLL;
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
    
    public partial class RoomSelectForReservationForm : Form
    {
       
        RoomController _rc;
        DateTime _entryingDate;
        DateTime _leavingDate;
        List<Room> _selectedRooms ;
        
        public RoomSelectForReservationForm(DateTime entryingDate, DateTime leavingDate)
        {
            _entryingDate = entryingDate;
            _leavingDate = leavingDate;
            _rc = new RoomController();
            _selectedRooms = new List<Room>();
            InitializeComponent();
          
        }
        public void LoadRoom()
        {
            
            List<Room> emptyRooms = _rc.GetEmptyRoom(_entryingDate,_leavingDate);
            foreach (Room room in emptyRooms)
            {
                Button btn = new Button();
                btn.Tag = room; 
                btn.Size = new Size(80, 60);
                btn.Text = room.RoomNumber + "\n" + room.Capacity + " Kişilik";
                btn.BackColor = Color.Green;
                btn.Click += Btn_Click;
                flpOdalar.Controls.Add(btn); 
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
           
            Button btn = sender as Button; 
            if (btn.BackColor == Color.Green)
            {
                btn.BackColor = Color.Gray;
                
                _selectedRooms.Add((Room)btn.Tag);

            }
            else
            {
                btn.BackColor = Color.Green; 
                _selectedRooms.Remove((Room)btn.Tag);
            }
        }

        private void RoomSelectForReservationForm_Load(object sender, EventArgs e)
        {
            LoadRoom();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Tag = _selectedRooms;

        }
    }
}
