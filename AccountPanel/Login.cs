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
using Project;

namespace Project {
    public partial class Login : UserControl {
        public Login() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            string connectionString = Program.connectionString;
            string query = "SELECT * FROM [dbo].[Thanhvien] WHERE taikhoan = @taikhoan AND matkhau = @matkhau";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@taikhoan", txtAccount.Text);
                    command.Parameters.AddWithValue("@matkhau", txtPassword.Text);
                    // Thêm các tham số và giá trị tương ứng cho các cột khác nếu cần
                    command.ExecuteNonQuery();
                    try {

                    } catch (Exception) {

                    } finally {

                    }
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        if (reader.Read()) {
                            if (Convert.ToBoolean(reader[6]) == true) {
                                Administrator();
                            } else {
                                User();
                            }
                        } else {
                            MessageBox.Show("Sai username or password");
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void Administrator() {
            TopPanel.btnTicket.Visible = true;
            TopPanel.btnClient.Visible = true;
            TopPanel.btnStaff.Visible = true;
            TopPanel.btnFilm.Visible = true;
            TopPanel.btnFood.Visible = true;

            LogIn();
        }

        public static void User() {
            TopPanel.btnTicket.Visible = true;
            TopPanel.btnClient.Visible = true;
            TopPanel.btnStaff.Visible = false;
            TopPanel.btnFilm.Visible = false;
            TopPanel.btnFood.Visible = false;

            LogIn();
        }

        public static void LogIn() {
            SideBar.buttonOrder.Visible = true;
            SideBar.buttonManage.Visible = true;

            TopSign.btnLogout.Enabled = true;
            TopSign.btnLogin.Visible = false;
            TopSign.btnLogin.Enabled = false;
            TopSign.btnInfo.Visible = true;
            TopSign.btnInfo.Enabled = false;
            TopSign.btnChange.Visible = true;
            TopSign.btnChange.Enabled = true;

            CenterSign.login.Visible = false;
            CenterSign.check.Visible = false;
            CenterSign.reset.Visible = false;
            CenterSign.accountInfo.Visible = true;

            AccountInfo.MemberInfo();
        }
        public static void LogOut() {
            SideBar.buttonOrder.Visible = false;
            SideBar.buttonManage.Visible = false;

            TopSign.btnLogout.Enabled = false;
            TopSign.btnLogin.Visible = true;
            TopSign.btnLogin.Enabled = false;
            TopSign.btnInfo.Visible = false;
            TopSign.btnInfo.Enabled = false;
            TopSign.btnChange.Visible = false;
            TopSign.btnChange.Enabled = false;

            CenterSign.login.Visible = true;
            CenterSign.check.Visible = false;
            CenterSign.reset.Visible = false;
            CenterSign.accountInfo.Visible = false;

            Login.txtAccount.Text = string.Empty;
            Login.txtPassword.Text = string.Empty;
        }
    }
}
