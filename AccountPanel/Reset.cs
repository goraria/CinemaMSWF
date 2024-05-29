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
    public partial class Reset : UserControl {
        public Reset() {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e) {
            string connectionString = Program.connectionString;
            string query = "UPDATE [dbo].[Thanhvien] SET matkhau = @matkhau WHERE id_thanhvien = @id_thanhvien AND taikhoan = @taikhoan";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    try {
                        if (txtNewPassword.Text == txtRePassword.Text) {
                            command.Parameters.AddWithValue("@matkhau", txtNewPassword.Text);
                            command.Parameters.AddWithValue("@id_thanhvien", Check.txtID.Text);
                            command.Parameters.AddWithValue("@taikhoan", Check.txtAccount.Text);
                            command.ExecuteNonQuery();

                            PreviousStep();

                            MessageBox.Show("Password is changed");
                        } else {
                            MessageBox.Show("Password is not match");
                        }
                    } catch (Exception ex) {
                        MessageBox.Show("Something went wrong");
                    }
                }
                connection.Close();
            }
        }

        private void PreviousStep() {
            Check.txtAccount.Text = string.Empty;
            Check.txtID.Text = string.Empty;

            Reset.txtNewPassword.Text = string.Empty;
            Reset.txtRePassword.Text = string.Empty;

            TopSign.btnLogin.Enabled = false;
            TopSign.btnChange.Enabled = true;
            TopSign.btnInfo.Enabled = false;

            CenterSign.login.Visible = false;
            CenterSign.check.Visible = false;
            CenterSign.reset.Visible = false;
            CenterSign.accountInfo.Visible = true;
        }
    }
}
