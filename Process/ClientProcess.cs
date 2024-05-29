using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project;

namespace Project {
    internal class ClientProcess {
        public ClientProcess() {

        }

        static string connectionString = Program.connectionString;

        public static void AddClient() {
            int count = 0;
            string counter = "SELECT COUNT(*) FROM [Cinema].[dbo].[Khachhang]";
            string query = "INSERT INTO [dbo].[Khachhang]([id_khachhang],[hoten],[ngaysinh],[diachi],[gioitinh],[sodienthoai]) " +
                "VALUES(@id_khachhang,@hoten,@ngaysinh,@diachi,@gioitinh,@sodienthoai)";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                using (SqlCommand command = new SqlCommand(counter, connection)) {
                    count = (int)command.ExecuteScalar();
                }
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@id_khachhang", "KH" + (count + 100000001).ToString().Substring(1));
                    command.Parameters.AddWithValue("@hoten", ClientInfo.txtName.Text);
                    command.Parameters.AddWithValue("@ngaysinh", ClientInfo.txtBirth.Text);
                    command.Parameters.AddWithValue("@diachi", ClientInfo.txtAddress.Text);
                    command.Parameters.AddWithValue("@gioitinh", ClientInfo.txtGender.Text);
                    command.Parameters.AddWithValue("@sodienthoai", ClientInfo.txtPhone.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("add thanh cong");
                }
                connection.Close();
            }
            ClientCRUD.ClearTextBox();
        }

        public static void RemoveClient() {
            string query = "UPDATE [dbo].[Khachhang] " +
                " SET hoten = '',ngaysinh = '',diachi = '',gioitinh = '',sodienthoai = '' " +
                "WHERE id_khachhang = @id_khachhang";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@id_khachhang", ClientInfo.txtID.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sua thanh cong");
                }
                connection.Close();
            }
            ClientCRUD.ClearTextBox();
        }

        public static void DeleteClient() {
            string query = "DELETE FROM [dbo].[Khachhang] WHERE id_khachhang = @id_khachhang";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@id_khachhang", ClientInfo.txtID.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("xoa thanh cong");
                }
                connection.Close();
            }
            ClientCRUD.ClearTextBox();
        }

        public static void UpdateClient() {
            string query = "UPDATE [dbo].[Khachhang] " +
                " SET hoten = @hoten, ngaysinh = @ngaysinh, diachi = @diachi, gioitinh = @gioitinh, sodienthoai = @sodienthoai " +
                "WHERE id_khachhang = @id_khachhang";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@hoten", ClientInfo.txtName.Text);
                    command.Parameters.AddWithValue("@ngaysinh", ClientInfo.txtBirth.Text);
                    command.Parameters.AddWithValue("@diachi", ClientInfo.txtAddress.Text);
                    command.Parameters.AddWithValue("@gioitinh", ClientInfo.txtGender.Text);
                    command.Parameters.AddWithValue("@sodienthoai", ClientInfo.txtPhone.Text);
                    command.Parameters.AddWithValue("@id_khachhang", ClientInfo.txtID.Text);
                    
                    command.ExecuteNonQuery();
                    MessageBox.Show("Update thanh cong");
                }
                connection.Close();
            }
            ClientCRUD.ClearTextBox();
        }
    }
}
