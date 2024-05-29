using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project {
    public partial class ChooseTime : UserControl {
        public ChooseTime() {
            InitializeComponent();
        }

        public static string cachieu = "";
        public static string id_cachieu = "";
        public static List<string> id_cachieuList = new List<string>();

        private void ChooseTime_Load(object sender, EventArgs e) {
            string connectionString = Program.connectionString;
            string query = "SELECT * FROM [dbo].[Cachieu]";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.ExecuteNonQuery();
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        Label[] lblName = new Label[] { label1, label2, label3, label4 };
                        Label[] lblTime = new Label[] { label5, label6, label7, label8 };
                        int index = 0;
                        while (reader.Read()) {
                            id_cachieuList.Add(reader[0].ToString());
                            lblName[index].Text = reader[1].ToString();
                            lblTime[index].Text = reader[2].ToString() + " - " + reader[3].ToString();
                            index++;
                        }
                    }
                }
                connection.Close();
            }
        }

        private void btnNext_Click(object sender, EventArgs e) {
            if (cachieu != "" && id_cachieu != "") {
                Order.chooseFilm.Visible = false;
                Order.chooseClient.Visible = false;
                Order.chooseTime.Visible = false;
                Order.chooseSlot.Visible = true;
                Order.chooseFood.Visible = false;
                Order.final.Visible = false;

                ChooseSlot.ReloadAllButton();
                ChooseSlot.Ordered();
            } else {
                MessageBox.Show("Please select a time of show");
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e) {
            Order.chooseFilm.Visible = false;
            Order.chooseClient.Visible = true;
            Order.chooseTime.Visible = false;
            Order.chooseSlot.Visible = false;
            Order.chooseFood.Visible = false;
            Order.final.Visible = false;

            EnabledAllButton();
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            EnabledAllButton();
        }

        private void button1_Click(object sender, EventArgs e) {
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            cachieu = label1.Text;
            id_cachieu = id_cachieuList[0];
            TicketReview.lblTime.Text = $"Ca chiếu ({label1.Text}): {label5.Text}";

            //int index = 0;
            //cachieu = lblName[index].Text;
            //TicketReview.lblDate.Text = lblTime[index].Text;
        }

        private void button2_Click(object sender, EventArgs e) {
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;

            cachieu = label2.Text;
            id_cachieu = id_cachieuList[1];
            TicketReview.lblTime.Text = $"Ca chiếu ({label2.Text}): {label6.Text}";

            //int index = 1;
            //cachieu = lblName[index].Text;
            //TicketReview.lblDate.Text = lblTime[index].Text;
        }

        private void button3_Click(object sender, EventArgs e) {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;

            cachieu = label3.Text;
            id_cachieu = id_cachieuList[2];
            TicketReview.lblTime.Text = $"Ca chiếu ({label3.Text}): {label7.Text}";

            //int index = 2;
            //cachieu = lblName[index].Text;
            //TicketReview.lblDate.Text = lblTime[index].Text;
        }

        private void button4_Click(object sender, EventArgs e) {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;

            cachieu = label4.Text;
            id_cachieu = id_cachieuList[3];
            TicketReview.lblTime.Text = $"Ca chiếu ({label4.Text}): {label8.Text}";

            //int index = 3;
            //cachieu = lblName[index].Text;
            //TicketReview.lblDate.Text = lblTime[index].Text;
        }

        public static List<string> disabledButtons = new List<string>();
        private void CheckDisabledButtons() {
            foreach (Control control in Controls) {
                if (control is Button button && !button.Enabled) {
                    disabledButtons.Add(button.Text);
                }
            }
        }

        public static void EnabledAllButton() {
            foreach (Control control in tableLayoutPanel.Controls) {
                if (control is Button button) {
                    button.Enabled = true;
                }
            }

            disabledButtons.Clear();
            id_cachieu = "";
        }

        //private void Checked(object sender, EventArgs e) {
        //    Button clickedButton = (Button)sender;
        //    clickedButton.Enabled = false;
        //}
    }
}
