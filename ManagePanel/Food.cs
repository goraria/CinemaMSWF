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
    public partial class Food : UserControl {
        public Food() {
            InitializeComponent();
        }

        private void Food_Load(object sender, EventArgs e) {
            Foodreload();
        }
        public static void Foodreload() {
            string connectionString = Program.connectionString;
            string query = "SELECT * FROM [dbo].[Doan]";
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
                FoodInfo.txtID.Text = row.Cells[0].Value.ToString();
                FoodInfo.txtName.Text = row.Cells[1].Value.ToString();
                FoodInfo.txtType.Text = row.Cells[2].Value.ToString();
                FoodInfo.txtQuantity.Text = row.Cells[3].Value.ToString();
                FoodInfo.txtPrice.Text = row.Cells[4].Value.ToString();

                FoodCRUD.Editing();
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e) {
            if (dataGridView.SelectedRows.Count > 0) { // Kiểm tra xem có hàng được chọn không
                DataGridViewRow row = dataGridView.SelectedRows[0];

                // Lấy giá trị từ các ô trong hàng được chọn và hiển thị lên các TextBox
                FoodInfo.txtID.Text = row.Cells[0].Value.ToString();
                FoodInfo.txtName.Text = row.Cells[1].Value.ToString();
                FoodInfo.txtType.Text = row.Cells[2].Value.ToString();
                FoodInfo.txtQuantity.Text = row.Cells[3].Value.ToString();
                FoodInfo.txtPrice.Text = row.Cells[4].Value.ToString();

                FoodCRUD.Editing();
            }
        }
        public static bool CheckTextBox() {

            if (string.IsNullOrEmpty(FoodInfo.txtID.Text) || string.IsNullOrEmpty(FoodInfo.txtName.Text) || string.IsNullOrEmpty(FoodInfo.txtType.Text) ||
                string.IsNullOrEmpty(FoodInfo.txtQuantity.Text) || string.IsNullOrEmpty(FoodInfo.txtPrice.Text)) {
                return false;
            } else {
                return true;
            }

        }
    }
}
