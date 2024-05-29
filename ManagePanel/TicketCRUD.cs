using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project;

namespace Project
{
    public partial class TicketCRUD : UserControl
    {
        public TicketCRUD()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Ticket.TicketReload();
            ClearTextBox();
        }

        public static void ClearTextBox()
        {
            TicketInfo.txtIDTicket.Text = string.Empty;
            TicketInfo.txtIDFilm.Text = string.Empty;
            TicketInfo.txtIDRoom.Text = string.Empty;
            TicketInfo.txtIDClient.Text = string.Empty;
            TicketInfo.txtIDStaff.Text = string.Empty;
            TicketInfo.txtIDSlot.Text = string.Empty;
            TicketInfo.txtIDTime.Text = string.Empty;
            TicketInfo.txtDate.Text = string.Empty;
            TicketInfo.txtPrice.Text = string.Empty;
        }
    }
}
