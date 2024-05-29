using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project;

namespace Project {
    public partial class Final : UserControl {
        public Final() {
            InitializeComponent();
        }

        private void Final_Load(object sender, EventArgs e) {
            FinalReload();
        }

        private void btnPrevious_Click(object sender, EventArgs e) {
            Order.chooseFilm.Visible = false;
            Order.chooseClient.Visible = false;
            Order.chooseTime.Visible = false;
            Order.chooseSlot.Visible = false;
            Order.chooseFood.Visible = true;
            Order.final.Visible = false;
        }

        private void btnDiscard_Click(object sender, EventArgs e) {
            DiscardAllSelected();
        }

        private void btnOrder_Click(object sender, EventArgs e) {
            TicketProcess.AddTicket();
            FoodProcess.UpdateFoodQuantity();
            BillProcess.AddBill();
            ChooseFood.ClearChooseFood();
            MessageBox.Show($"Giá: ${TicketProcess.summary + FoodReview.summary}");

            DiscardAllSelected();
        }

        private void btnTicket_Click(object sender, EventArgs e) {
            ticketReview.Visible = true;
            foodReview.Visible = false;

            btnTicket.Enabled = false;
            btnFood.Enabled = true;

            FinalReload();
        }

        private void btnFood_Click(object sender, EventArgs e) {
            ticketReview.Visible = false;
            foodReview.Visible = true;

            btnTicket.Enabled = true;
            btnFood.Enabled = false;

            FinalReload();
        }

        public static void DiscardAllSelected() {
            Order.chooseFilm.Visible = true;
            Order.chooseClient.Visible = false;
            Order.chooseTime.Visible = false;
            Order.chooseSlot.Visible = false;
            Order.chooseFood.Visible = false;
            Order.final.Visible = false;

            TicketProcess.summary = 0;
            FoodReview.summary = 0;
        }

        public static void FinalReload() {
            TicketProcess.RoomCheck();
            TicketReview.lblSlot.Text = "Slot: ";
            foreach (string item in ChooseSlot.disabledButtons) {
                TicketProcess.SlotCheck(item);
                TicketReview.lblSlot.Text += $"{item}, ";
            }
            TicketReview.lblRoom.Text = $"Phòng {TicketProcess.id_room}";
            TicketReview.lblDate.Text = Program.dateString;

            labelPrice.Text = $"Giá: ${TicketProcess.summary + FoodReview.summary}";
        }
    }
}
