using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project {
    public partial class ChooseFilm : UserControl {
        public ChooseFilm() {
            InitializeComponent();
        }

        private void ChooseFilm_Load(object sender, EventArgs e) {
            string connectionString = Program.connectionString;
            string query = "SELECT [id_phim], [tenphim] FROM [dbo].[Phim]";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();

                // Truy vấn dữ liệu
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Gán dữ liệu cho DataGridView
                dataGridView.DataSource = dataTable;
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                string selected = row.Cells[1].Value.ToString();
                id_phim = row.Cells[0].Value.ToString();

                TicketReview.lblFilm.Text = $"Phim: {selected}";
                SelectedElement(id_phim);
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e) {
            if (dataGridView.SelectedRows.Count > 0) {
                DataGridViewRow row = dataGridView.SelectedRows[0];
                string selected = row.Cells[1].Value.ToString();
                id_phim = row.Cells[0].Value.ToString();

                TicketReview.lblFilm.Text = $"Phim: {selected}";
                SelectedElement(id_phim);
            }
        }

        private void btnNext_Click(object sender, EventArgs e) {
            if (lblName.Text != "Unknown" && lblCountry.Text != "Unknown" && lblGenre.Text != "Unknown" && lblStudio.Text != "Unknown" && lblTime.Text != "Unknown" && lblDate.Text != "Unknown") {
                Order.chooseFilm.Visible = false;
                Order.chooseClient.Visible = true;
                Order.chooseTime.Visible = false;
                Order.chooseSlot.Visible = false;
                Order.chooseFood.Visible = false;
                Order.final.Visible = false;

                ChooseClient.ClientReload();
                ChooseClient.ClearTexBox();
            } else {
                MessageBox.Show("Please Choose some film");
            }
        }

        public static string id_phim = "";

        private void SelectedElement(string id) {
            string connectionString = Program.connectionString;
            string query = "SELECT * FROM [dbo].[Phim] WHERE [id_phim] = @id_phim";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@id_phim", id);
                    command.ExecuteNonQuery();
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        if (reader.Read()) {
                            id_phim = reader[0].ToString();
                            lblName.Text = reader[1].ToString();
                            lblCountry.Text = reader[2].ToString();
                            lblGenre.Text = reader[3].ToString();
                            lblStudio.Text = reader[6].ToString();
                            lblTime.Text = reader[5].ToString();
                            lblDate.Text = reader[7].ToString();
                            pictureBox.ImageLocation = Home.ImagePath(reader[0].ToString());
                        } else {
                            lblName.Text = "Unknown";
                            lblCountry.Text = "Unknown";
                            lblGenre.Text = "Unknown";
                            lblStudio.Text = "Unknown";
                            lblTime.Text = "Unknown";
                            lblDate.Text = "Unknown";
                            pictureBox.ImageLocation = Home.ImagePath("Unknown");
                        }
                    }
                }
                connection.Close();
            }
        }
    }
}
