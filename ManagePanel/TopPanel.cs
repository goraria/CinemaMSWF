using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project.Manage;

namespace Project {
    public partial class TopPanel : UserControl {
        public TopPanel() {
            InitializeComponent();
        }

        private void btnTicket_Click(object sender, EventArgs e) {
            btnTicket.Enabled = false;
            btnBill.Enabled = true;
            btnClient.Enabled = true;
            btnStaff.Enabled = true;
            btnFilm.Enabled = true;
            btnFood.Enabled = true;

            Manage.ticketPanel.Visible = true;
            Manage.billPanel.Visible = false;
            Manage.clientPanel.Visible = false;
            Manage.staffPanel.Visible = false;
            Manage.filmPanel.Visible = false;
            Manage.foodPanel.Visible = false;
        }

        private void btnBill_Click(object sender, EventArgs e) {
            btnTicket.Enabled = true;
            btnBill.Enabled = false;
            btnClient.Enabled = true;
            btnStaff.Enabled = true;
            btnFilm.Enabled = true;
            btnFood.Enabled = true;

            Manage.ticketPanel.Visible = false;
            Manage.billPanel.Visible = true;
            Manage.clientPanel.Visible = false;
            Manage.staffPanel.Visible = false;
            Manage.filmPanel.Visible = false;
            Manage.foodPanel.Visible = true;
        }

        private void btnClient_Click(object sender, EventArgs e) {
            btnTicket.Enabled = true;
            btnBill.Enabled = true;
            btnClient.Enabled = false;
            btnStaff.Enabled = true;
            btnFilm.Enabled = true;
            btnFood.Enabled = true;

            Manage.ticketPanel.Visible = false;
            Manage.billPanel.Visible = false;
            Manage.clientPanel.Visible = true;
            Manage.staffPanel.Visible = false;
            Manage.filmPanel.Visible = false;
            Manage.foodPanel.Visible = false;
        }

        private void btnStaff_Click(object sender, EventArgs e) {
            btnTicket.Enabled = true;
            btnBill.Enabled = true;
            btnClient.Enabled = true;
            btnStaff.Enabled = false;
            btnFilm.Enabled = true;
            btnFood.Enabled = true;

            Manage.ticketPanel.Visible = false;
            Manage.billPanel.Visible = false;
            Manage.clientPanel.Visible = false;
            Manage.staffPanel.Visible = true;
            Manage.filmPanel.Visible = false;
            Manage.foodPanel.Visible = false;
        }

        private void btnFilm_Click(object sender, EventArgs e) {
            btnTicket.Enabled = true;
            btnBill.Enabled = true;
            btnClient.Enabled = true;
            btnStaff.Enabled = true;
            btnFilm.Enabled = false;
            btnFood.Enabled = true;

            Manage.ticketPanel.Visible = false;
            Manage.billPanel.Visible = false;
            Manage.clientPanel.Visible = false;
            Manage.staffPanel.Visible = false;
            Manage.filmPanel.Visible = true;
            Manage.foodPanel.Visible = false;
        }

        private void btnFood_Click(object sender, EventArgs e) {
            btnTicket.Enabled = true;
            btnBill.Enabled = true;
            btnClient.Enabled = true;
            btnStaff.Enabled = true;
            btnFilm.Enabled = true;
            btnFood.Enabled = false;

            Manage.ticketPanel.Visible = false;
            Manage.billPanel.Visible = false;
            Manage.clientPanel.Visible = false;
            Manage.staffPanel.Visible = false;
            Manage.filmPanel.Visible = false;
            Manage.foodPanel.Visible = true;
        }
    }
}
