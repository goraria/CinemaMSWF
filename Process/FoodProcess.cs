using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project {
    internal class FoodProcess {
        public FoodProcess() {

        }

        static string connectionString = Program.connectionString;

        public static void AddFood() {
            int count = 0;
            string counter = "SELECT COUNT(*) FROM [Cinema].[dbo].[Doan]";
            string query = "INSERT INTO [dbo].[Doan] ([id_doan],[ten],[loai],[soluong],[gia]) " +
                " VALUES(@id_Doan,@ten,@loai,@soluong,@gia)";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                using (SqlCommand command = new SqlCommand(counter, connection)) {
                    count = (int)command.ExecuteScalar();
                }
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@id_Doan", "DA" + (count + 100000001).ToString().Substring(1));
                    command.Parameters.AddWithValue("@ten", FoodInfo.txtName.Text);
                    command.Parameters.AddWithValue("@loai", FoodInfo.txtType.Text);
                    command.Parameters.AddWithValue("@soluong", Convert.ToInt32(FoodInfo.txtQuantity.Text));
                    command.Parameters.AddWithValue("@gia", Convert.ToInt32(FoodInfo.txtPrice.Text));

                    command.ExecuteNonQuery();
                    MessageBox.Show("add thanh cong");
                }
                connection.Close();
            }
            FoodCRUD.ClearTextBox();
        }

        public static void RemoveFood() {
            string query = "UPDATE [dbo].[Doan] " +
                " SET ten = '',loai = '',soluong = 0 ,gia = 0  " +
                "WHERE id_Doan = @id_Doan";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@id_Doan", FoodInfo.txtID.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("xoa thanh cong");
                }
                connection.Close();
            }
            FoodCRUD.ClearTextBox();
        }

        public static void DeleteFood() {
            string query = "DELETE FROM [dbo].[Doan] " +
                " WHERE id_Doan = @id_Doan";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@id_Doan", FoodInfo.txtID.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("xoa thanh cong");
                }
                connection.Close();
            }
            FoodCRUD.ClearTextBox();
        }

        public static void UpdateFood() {
            string query = "UPDATE [dbo].[Doan] " +
                " SET ten = @ten ,loai = @loai ,soluong = @soluong ,gia = @gia  " +
                "WHERE id_Doan = @id_Doan";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@ten", FoodInfo.txtName.Text);
                    command.Parameters.AddWithValue("@loai", FoodInfo.txtType.Text);
                    command.Parameters.AddWithValue("@soluong", Convert.ToInt32(FoodInfo.txtQuantity.Text));
                    command.Parameters.AddWithValue("@gia", Convert.ToInt32(FoodInfo.txtPrice.Text));
                    command.Parameters.AddWithValue("@id_Doan", FoodInfo.txtID.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("update thanh cong");
                }
                connection.Close();
            }
            FoodCRUD.ClearTextBox();
        }

        public static void UpdateFoodQuantity() {
            string query = "UPDATE [dbo].[Doan] " +
                " SET soluong = soluong - @soluong  " +
                "WHERE id_Doan = @id_Doan";

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                foreach (List<string> item in FoodReview.foodList) {
                    using (SqlCommand command = new SqlCommand(query, connection)) {
                        command.Parameters.AddWithValue("@soluong", Convert.ToInt32(item[3]));
                        command.Parameters.AddWithValue("@id_Doan", item[0]);
                        command.ExecuteNonQuery();

                    }
                }
                connection.Close();
            }
            FoodCRUD.ClearTextBox();
        }
    }
}
