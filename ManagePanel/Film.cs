using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project {
    public partial class Film : UserControl {
        public Film() {
            InitializeComponent();
        }

        private void Film_Load(object sender, EventArgs e) {
            FilmReload();
        }
        public static void FilmReload() {
            string connectionString = Program.connectionString;
            string query = "SELECT * FROM [dbo].[Phim]";
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
            if (e.RowIndex >= 0) { // Kiểm tra nếu hàng được chọn có hợp lệ
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                // Lấy giá trị từ các ô trong hàng được chọn và hiển thị lên các TextBox
                FilmInfo.txtID.Text = row.Cells[0].Value.ToString();
                FilmInfo.txtName.Text = row.Cells[1].Value.ToString();
                FilmInfo.txtCountry.Text = row.Cells[2].Value.ToString();
                FilmInfo.txtGenre.Text = row.Cells[3].Value.ToString();
                FilmInfo.txtCounter.Text = row.Cells[4].Value.ToString();
                FilmInfo.txtTime.Text = row.Cells[5].Value.ToString();
                FilmInfo.txtStudio.Text = row.Cells[6].Value.ToString();
                FilmInfo.txtDate.Text = Convert.ToDateTime(row.Cells[7].Value.ToString()).ToString("yyyy-MM-dd");

                FilmCRUD.Editing();
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e) {
            if (dataGridView.SelectedRows.Count > 0) { // Kiểm tra xem có hàng được chọn không
                DataGridViewRow row = dataGridView.SelectedRows[0];

                // Lấy giá trị từ các ô trong hàng được chọn và hiển thị lên các TextBox
                FilmInfo.txtID.Text = row.Cells[0].Value.ToString();
                FilmInfo.txtName.Text = row.Cells[1].Value.ToString();
                FilmInfo.txtCountry.Text = row.Cells[2].Value.ToString();
                FilmInfo.txtGenre.Text = row.Cells[3].Value.ToString();
                FilmInfo.txtCounter.Text = row.Cells[4].Value.ToString();
                FilmInfo.txtTime.Text = row.Cells[5].Value.ToString();
                FilmInfo.txtStudio.Text = row.Cells[6].Value.ToString();
                FilmInfo.txtDate.Text = Convert.ToDateTime(row.Cells[7].Value.ToString()).ToString("yyyy-MM-dd");

                FilmCRUD.Editing();
            }
        }
        public static bool CheckTextBox() {

            if (string.IsNullOrEmpty(FilmInfo.txtCountry.Text) || string.IsNullOrEmpty(FilmInfo.txtName.Text) || string.IsNullOrEmpty(FilmInfo.txtGenre.Text) ||
                string.IsNullOrEmpty(FilmInfo.txtCounter.Text) || string.IsNullOrEmpty(FilmInfo.txtTime.Text) || string.IsNullOrEmpty(FilmInfo.txtStudio.Text) || string.IsNullOrEmpty(FilmInfo.txtDate.Text)) {
                return false;
            } else {
                return true;
            }

        }
    }
}
