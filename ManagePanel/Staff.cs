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
    public partial class Staff : UserControl {
        public Staff() {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e) {
            StaffReload();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) { // Kiểm tra nếu hàng được chọn có hợp lệ
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                // Lấy giá trị từ các ô trong hàng được chọn và hiển thị lên các TextBox
                StaffInfo.txtID.Text = row.Cells[0].Value.ToString();
                StaffInfo.txtName.Text = row.Cells[1].Value.ToString();
                StaffInfo.txtBirth.Text = Convert.ToDateTime(row.Cells[2].Value.ToString()).ToString("yyyy-MM-dd");
                StaffInfo.txtAddress.Text = row.Cells[3].Value.ToString();
                StaffInfo.txtGender.Text = row.Cells[4].Value.ToString();
                StaffInfo.txtPhone.Text = row.Cells[5].Value.ToString();
                StaffInfo.txtType.Text = row.Cells[6].Value.ToString();
                StaffInfo.txtUsername.Text = row.Cells[7].Value.ToString();
                StaffInfo.txtPassword.Text = row.Cells[8].Value.ToString();

                StaffCRUD.Editing();
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e) {
            if (dataGridView.SelectedRows.Count > 0) { // Kiểm tra xem có hàng được chọn không
                DataGridViewRow row = dataGridView.SelectedRows[0];

                // Lấy giá trị từ các ô trong hàng được chọn và hiển thị lên các TextBox
                StaffInfo.txtID.Text = row.Cells[0].Value.ToString();
                StaffInfo.txtName.Text = row.Cells[1].Value.ToString();
                StaffInfo.txtBirth.Text = Convert.ToDateTime(row.Cells[2].Value.ToString()).ToString("yyyy-MM-dd");
                StaffInfo.txtAddress.Text = row.Cells[3].Value.ToString();
                StaffInfo.txtGender.Text = row.Cells[4].Value.ToString();
                StaffInfo.txtPhone.Text = row.Cells[5].Value.ToString();
                StaffInfo.txtType.Text = row.Cells[6].Value.ToString();
                StaffInfo.txtUsername.Text = row.Cells[7].Value.ToString();
                StaffInfo.txtPassword.Text = row.Cells[8].Value.ToString();

                StaffCRUD.Editing();
            }
        }

        public static void StaffReload() {
            string connectionString = Program.connectionString;
            string query = "SELECT * FROM [dbo].[Thanhvien] WHERE loai_taikhoan = 0";
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
        public static bool CheckTextBox() {

            if (string.IsNullOrEmpty(StaffInfo.txtName.Text) || string.IsNullOrEmpty(StaffInfo.txtBirth.Text) || string.IsNullOrEmpty(StaffInfo.txtAddress.Text) ||
                string.IsNullOrEmpty(StaffInfo.txtPhone.Text) || string.IsNullOrEmpty(StaffInfo.txtGender.Text) || string.IsNullOrEmpty(StaffInfo.txtType.Text) ||
                string.IsNullOrEmpty(StaffInfo.txtUsername.Text) || string.IsNullOrEmpty(StaffInfo.txtPassword.Text)) {
                return false;
            } else {
                return true;
            }

        }
    }
}
