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
    public partial class Check : UserControl {
        public Check() {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e) {
            string connectionString = Program.connectionString;
            string query = "SELECT * FROM [dbo].[Thanhvien] WHERE taikhoan = @taikhoan AND id_thanhvien = @id_thanhvien";
            if (Login.txtAccount.Text == txtAccount.Text)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@taikhoan", txtAccount.Text);
                        command.Parameters.AddWithValue("@id_thanhvien", txtID.Text);
                        // Thêm các tham số và giá trị tương ứng cho các cột khác nếu cần
                        command.ExecuteNonQuery();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                NextStep();
                            }
                            else
                            {
                                MessageBox.Show("Sai username or id", "Notify", MessageBoxButtons.OK);
                            }
                        }
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Ban khong phai chu tai khoan nay", "Notify", MessageBoxButtons.OK);
            }
        }

        private void NextStep() {
            CenterSign.check.Visible = false;
            CenterSign.reset.Visible = true;
        }
    }
}
