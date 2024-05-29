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
    public partial class ChooseClient : UserControl {
        public ChooseClient() {
            InitializeComponent();
        }

        private void btnPrevious_Click(object sender, EventArgs e) {
            Order.chooseFilm.Visible = true;
            Order.chooseClient.Visible = false;
            Order.chooseTime.Visible = false;
            Order.chooseSlot.Visible = false;
            Order.chooseFood.Visible = false;
            Order.final.Visible = false;

            ClearTexBox();
        }

        private void btnNext_Click(object sender, EventArgs e) {
            if (id_khachhang != "") {
                Order.chooseFilm.Visible = false;
                Order.chooseClient.Visible = false;
                Order.chooseTime.Visible = true;
                Order.chooseSlot.Visible = false;
                Order.chooseFood.Visible = false;
                Order.final.Visible = false;

                ChooseTime.EnabledAllButton();
            } else {
                MessageBox.Show("Please select a customer");
            }
        }

        public static string id_khachhang = "";

        private void ChooseClient_Load(object sender, EventArgs e) {
            ClientReload();
        }

        public static void ClientReload()
        {
            string connectionString = Program.connectionString;
            string query = "SELECT * FROM [dbo].[Khachhang]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Truy vấn dữ liệu
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                //dataTable.Columns.Remove("id_khachhang");

                // Gán dữ liệu cho DataGridView
                dataGridView.DataSource = dataTable;
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                txtName.Text = row.Cells[1].Value.ToString();
                txtBirthday.Text = Convert.ToDateTime(row.Cells[2].Value.ToString()).ToString("yyyy-MM-dd");
                txtAddress.Text = row.Cells[3].Value.ToString();
                txtGender.Text = row.Cells[4].Value.ToString();
                txtPhone.Text = row.Cells[5].Value.ToString();

                id_khachhang = row.Cells[0].Value.ToString();
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e) {
            if (dataGridView.SelectedRows.Count > 0) {
                DataGridViewRow row = dataGridView.SelectedRows[0];

                txtName.Text = row.Cells[1].Value.ToString();
                txtBirthday.Text = Convert.ToDateTime(row.Cells[2].Value.ToString()).ToString("yyyy-MM-dd");
                txtAddress.Text = row.Cells[3].Value.ToString();
                txtGender.Text = row.Cells[4].Value.ToString();
                txtPhone.Text = row.Cells[5].Value.ToString();
                id_khachhang = row.Cells[0].Value.ToString();
            }
        }

        public static void ClearTexBox() {
            txtName.Text = string.Empty;
            txtBirthday.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtGender.Text = string.Empty;
            txtPhone.Text = string.Empty;

            id_khachhang = "";
        }
    }
}
