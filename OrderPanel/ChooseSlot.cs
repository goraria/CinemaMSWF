using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project {
    public partial class ChooseSlot : UserControl {
        public ChooseSlot() {
            InitializeComponent();
        }

        private void ChooseSlot_Load(object sender, EventArgs e) {
            ReloadAllButton();
            Ordered();
        }

        private void btnNext_Click(object sender, EventArgs e) {
            //CheckDisabledButtons();
            Ordered();
            if (disabledButtons.Count > 0) {
                Order.chooseFilm.Visible = false;
                Order.chooseClient.Visible = false;
                Order.chooseTime.Visible = false;
                Order.chooseSlot.Visible = false;
                Order.chooseFood.Visible = true;
                Order.final.Visible = false;
            } else {
                MessageBox.Show("Please select slot");
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e) {
            Order.chooseFilm.Visible = false;
            Order.chooseClient.Visible = false;
            Order.chooseTime.Visible = true;
            Order.chooseSlot.Visible = false;
            Order.chooseFood.Visible = false;
            Order.final.Visible = false;

            ReloadAllButton();
            //Ordered();
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            ReloadAllButton();
            Ordered();
        }

        public static void ReloadAllButton() {
            foreach (Control control in tableLayoutPanel.Controls) {
                //foreach (string item in disabledButtons) {
                //    if (control is Button button && button.Text == item) {
                //        button.Enabled = true;
                //    }
                //}
                if (control is Button button) {
                    button.Enabled = true;
                }
            }
        }

        public static List<string> disabledButtons = new List<string>();
        public static void CheckDisabledButtons() {
            disabledButtons.Clear();
            foreach (Control control in tableLayoutPanel.Controls) {
                if (control is Button button && button.Enabled == false && !orderedButtons.Contains(button.Text)) {
                    disabledButtons.Add(button.Text);
                    //foreach (string item in orderedButtons) {
                        //if (!orderedButtons.Contains(item)) {
                        //}
                    //}
                }
            }
        }

        public static List<string> orderedButtons = new List<string>();
        public static void Ordered() {
            orderedButtons.Clear();
            TicketProcess.RoomCheck();
            string connectionString = Program.connectionString;
            //string query = "SELECT * FROM [dbo].[Ghe] WHERE [id_phong] = @id_phong AND [trangthai] = @trangthai";
            string query = "SELECT [tenghe] FROM [dbo].[Ghe] WHERE [id_phong] = @id_phong AND [trangthai] = @trangthai";
            string check = "" +
                "SELECT [Ve].[id_ghe], [Ghe].[tenghe] " +
                "FROM [dbo].[Ve] INNER JOIN [dbo].[Ghe] ON [Ve].[id_ghe] = [Ghe].[id_ghe]" +
                "WHERE [Ve].[id_phong] = @id_phong AND [Ve].[id_cachieu] = @id_cachieu AND [Ve].[ngayban] = @ngayban" +
            "";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                using (SqlCommand command = new SqlCommand(check, connection)) {
                    command.Parameters.AddWithValue("@id_phong", TicketProcess.id_room);
                    //command.Parameters.AddWithValue("@id_ghe", item);
                    command.Parameters.AddWithValue("@id_cachieu", ChooseTime.id_cachieu);
                    command.Parameters.AddWithValue("@ngayban", Program.dateString);
                    command.ExecuteNonQuery();
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            foreach (Control control in tableLayoutPanel.Controls) {
                                if (control is Button button) { //!
                                    if (button.Text == reader[1].ToString()) {
                                        button.Enabled = false;
                                        orderedButtons.Add(reader[1].ToString());
                                    }
                                }
                            }
                        }
                    }
                }
                //using (SqlCommand command = new SqlCommand(query, connection)) {
                //    command.Parameters.AddWithValue("@id_phong", TicketProcess.id_room);
                //    command.Parameters.AddWithValue("@trangthai", 1);
                //    command.ExecuteNonQuery();
                //    using (SqlDataReader reader = command.ExecuteReader()) {
                //        List<List<string>> list = new List<List<string>>();
                //        while (reader.Read()) {
                //            List<string> item = new List<string>();
                //            for (int i = 0; i < reader.FieldCount; i++) {
                //                item.Add(reader[i].ToString());
                //            }
                //            list.Add(item);
                //        }

                //        foreach (Control control in tableLayoutPanel.Controls) {
                //            if (control is Button button) { //!
                //                foreach (List<string> item in list) {
                //                    if (button.Text == item[2]) {
                //                        button.Enabled = false;
                //                    }
                //                }
                //            }
                //        }
                //    }
                //}
                connection.Close();
            }
            CheckDisabledButtons();
        }

        private void Checked(object sender, EventArgs e) {
            Button clickedButton = (Button)sender;
            clickedButton.Enabled = false;
        }

        private void Unchecked(object sender, EventArgs e) {
            //Button clickedButton = (Button)sender;
            //if (!clickedButton.Enabled) {
            //    clickedButton.Enabled = true;
            //}
        }
    }
}
