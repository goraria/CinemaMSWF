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
    public partial class AccountInfo : UserControl {
        public AccountInfo() {
            InitializeComponent();
        }

        private void AccountInfo_Load(object sender, EventArgs e) {
            MemberInfo();
        }

        static public void MemberInfo() {
            string connectionString = Program.connectionString;
            string query = "SELECT * FROM [dbo].[Thanhvien] WHERE taikhoan = @taikhoan AND matkhau = @matkhau";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@taikhoan", Login.txtAccount.Text);
                    command.Parameters.AddWithValue("@matkhau", Login.txtPassword.Text);
                    command.ExecuteNonQuery();
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        if (reader.Read()) {
                            lblID.Text = "ID: " + reader[0].ToString();
                            lblName.Text = "Name: " + reader[1].ToString();
                            lblBirth.Text = "Birthday: " + Convert.ToDateTime(reader[2].ToString()).ToString("yyyy-MM-dd");
                            lblAddress.Text = "Address: " + reader[3].ToString();
                            lblGender.Text = "Gender: " + reader[4].ToString();
                            lblPhone.Text = "Phone: " + reader[5].ToString();
                        } else {
                            lblID.Text = "Unknown";
                            lblName.Text = "Unknown";
                            lblBirth.Text = "Unknown";
                            lblAddress.Text = "Unknown";
                            lblGender.Text = "Unknown";
                            lblPhone.Text = "Unknown";
                        }
                    }
                    connection.Close();
                }
            }
        }
    }
}
