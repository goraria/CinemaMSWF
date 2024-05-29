using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project;

namespace Project {
    internal class StaffProcess {
        public StaffProcess() {

        }

        static string connectionString = Program.connectionString;

        public static void AddStaff() {
            int count = 0;
            string counter = "SELECT COUNT(*) FROM [Cinema].[dbo].[Thanhvien]";
            string query = "INSERT INTO [dbo].[Thanhvien] ([id_thanhvien],[hoten],[ngaysinh],[diachi],[gioitinh],[sodienthoai],[loai_taikhoan],[taikhoan],[matkhau]) " +
                " VALUES(@id_thanhvien,@hoten,@ngaysinh,@diachi,@gioitinh,@sodienthoai,@loai_taikhoan,@taikhoan,@matkhau)";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                using (SqlCommand command = new SqlCommand(counter, connection)) {
                    count = (int)command.ExecuteScalar();
                }
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@id_thanhvien", "NV" + (count + 100000001).ToString().Substring(1));
                    command.Parameters.AddWithValue("@hoten", StaffInfo.txtName.Text);
                    command.Parameters.AddWithValue("@ngaysinh", StaffInfo.txtBirth.Text);
                    command.Parameters.AddWithValue("@diachi", StaffInfo.txtAddress.Text);
                    command.Parameters.AddWithValue("@gioitinh", StaffInfo.txtGender.Text);
                    command.Parameters.AddWithValue("@sodienthoai", StaffInfo.txtPhone.Text);
                    command.Parameters.AddWithValue("@loai_taikhoan", 0);
                    command.Parameters.AddWithValue("@taikhoan", StaffInfo.txtUsername.Text);
                    command.Parameters.AddWithValue("@matkhau", StaffInfo.txtPassword.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("add thanh cong");
                }
                connection.Close();
            }
            ClientCRUD.ClearTextBox();
        }

        public static void DeleteStaff() {
            string query = "DELETE FROM [dbo].[Thanhvien] " +
                " WHERE id_thanhvien = @id_thanhvien";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@id_thanhvien", StaffInfo.txtID.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("xoa thanh cong");
                }
                connection.Close();
            }
            StaffCRUD.ClearTextBox();
        }

        public static void RemoveStaff() {
            string query = "UPDATE [dbo].[Khachhang] " +
                " SET hoten = '',ngaysinh = '',diachi = '',gioitinh = '',sodienthoai = '', taikhoan = '', matkhau= '' " +
                "WHERE id_khachhang = @id_khachhang";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@id_thanhvien", StaffInfo.txtID.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("xoa thanh cong");
                }
                connection.Close();
            }
            StaffCRUD.ClearTextBox();
        }

        public static void UpdateStaff() {
            string query = "UPDATE [dbo].[Thanhvien] " +
                " SET hoten = @hoten, ngaysinh = @ngaysinh, diachi = @diachi, gioitinh = @gioitinh, sodienthoai = @sodienthoai ,taikhoan = @taikhoan, matkhau= @matkhau " +
                "WHERE id_thanhvien = @id_thanhvien";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@hoten", StaffInfo.txtName.Text);
                    command.Parameters.AddWithValue("@ngaysinh", StaffInfo.txtBirth.Text);
                    command.Parameters.AddWithValue("@diachi", StaffInfo.txtAddress.Text);
                    command.Parameters.AddWithValue("@gioitinh", StaffInfo.txtGender.Text);
                    command.Parameters.AddWithValue("@sodienthoai", StaffInfo.txtPhone.Text);
                    command.Parameters.AddWithValue("@taikhoan", StaffInfo.txtUsername.Text);
                    command.Parameters.AddWithValue("@matkhau", StaffInfo.txtPassword.Text);
                    command.Parameters.AddWithValue("@id_thanhvien", StaffInfo.txtID.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("update thanh cong");
                }
                connection.Close();
            }
            StaffCRUD.ClearTextBox();
        }
    }
}
