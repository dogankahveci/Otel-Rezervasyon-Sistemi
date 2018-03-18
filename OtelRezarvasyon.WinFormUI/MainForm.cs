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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Room _room = new Room();
        Customer _customer = new Customer();
        private void üyeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void odaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RoomAddForm roomAddForm = new RoomAddForm();
            roomAddForm.MdiParent = this;
            roomAddForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            roomAddForm.Show();

        }

        private void odaGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomListForm roomListFrom = new RoomListForm();
            roomListFrom.MdiParent = this;
            roomListFrom.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            roomListFrom.Show();
        }

        private void odaGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomUpdateForm roomUpdateForm = new RoomUpdateForm(_room);
            roomUpdateForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            roomUpdateForm.MdiParent = this;
            roomUpdateForm.Show();
        }

        private void CustomerAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerAddForm customerAddForm = new CustomerAddForm();
            customerAddForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            customerAddForm.MdiParent = this;
            customerAddForm.Show();
        }

        private void CustomerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerViewForm customerViewForm = new CustomerViewForm();
            customerViewForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            customerViewForm.MdiParent = this;
            customerViewForm.Show();
        }

        private void musterGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerUpdateForm customerUpdateForm = new CustomerUpdateForm(_customer);
            customerUpdateForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            customerUpdateForm.MdiParent = this;
            customerUpdateForm.Show();
        }

        private void rezervasyonYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservationAddForm frm = new ReservationAddForm();
           frm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
