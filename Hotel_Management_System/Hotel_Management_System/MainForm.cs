using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void 고객관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageClientsForm manageClientsForm = new ManageClientsForm();
            manageClientsForm.ShowDialog();
        }

        private void 방관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRoomsForm manageRoomsForm = new ManageRoomsForm();
            manageRoomsForm.ShowDialog();
        }

        private void 예약관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageReservationForm manageReservationForm = new ManageReservationForm();
            manageReservationForm.ShowDialog();
        }
    }
}
