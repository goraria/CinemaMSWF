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
    public partial class Client : UserControl {
        public Client() {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e) {
            ClientReload();
        }
        public static void ClientReload() {
            string connectionString = Program.connectionString;
            string query = "SELECT * FROM [dbo].[Khachhang]";
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
                ClientInfo.txtID.Text = row.Cells[0].Value.ToString();
                ClientInfo.txtName.Text = row.Cells[1].Value.ToString();
                ClientInfo.txtBirth.Text = Convert.ToDateTime(row.Cells[2].Value.ToString()).ToString("yyyy-MM-dd");
                ClientInfo.txtAddress.Text = row.Cells[3].Value.ToString();
                ClientInfo.txtGender.Text = row.Cells[4].Value.ToString();
                ClientInfo.txtPhone.Text = row.Cells[5].Value.ToString();

                ClientCRUD.Editing();
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e) {
            if (dataGridView.SelectedRows.Count > 0) { // Kiểm tra xem có hàng được chọn không
                DataGridViewRow row = dataGridView.SelectedRows[0];

                // Lấy giá trị từ các ô trong hàng được chọn và hiển thị lên các TextBox
                ClientInfo.txtID.Text = row.Cells[0].Value.ToString();
                ClientInfo.txtName.Text = row.Cells[1].Value.ToString();
                ClientInfo.txtBirth.Text = Convert.ToDateTime(row.Cells[2].Value.ToString()).ToString("yyyy-MM-dd");
                ClientInfo.txtAddress.Text = row.Cells[3].Value.ToString();
                ClientInfo.txtGender.Text = row.Cells[4].Value.ToString();
                ClientInfo.txtPhone.Text = row.Cells[5].Value.ToString();

                ClientCRUD.Editing();
            }
        }

        public static bool CheckTextBox() {

            if (string.IsNullOrEmpty(ClientInfo.txtName.Text) || string.IsNullOrEmpty(ClientInfo.txtBirth.Text) ||
                string.IsNullOrEmpty(ClientInfo.txtAddress.Text) || string.IsNullOrEmpty(ClientInfo.txtGender.Text) || string.IsNullOrEmpty(ClientInfo.txtPhone.Text)) {
                return false;
            } else {
                return true;
            }

        }
    }
}
