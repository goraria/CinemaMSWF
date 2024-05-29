using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project {
    internal class BillProcess {
        static private string connectionString = Program.connectionString;
        public BillProcess() {

        }
        static public void AddBill() {
            int count = 0;
            string counter = "SELECT COUNT(*) FROM [Cinema].[dbo].[Hoadon]";
            string query = "INSERT INTO [dbo].[Hoadon]([id_hoadon],[id_doan],[id_khachhang],[id_thanhvien],[soluong],[tonggia],[ngayban]) " +
                "VALUES(@id_hoadon,@id_doan,@id_khachhang,@id_thanhvien,@soluong,@tonggia,@ngayban)";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                foreach (List<string> item in FoodReview.foodList) {
                    using (SqlCommand command = new SqlCommand(counter, connection)) {
                        count = (int)command.ExecuteScalar();
                    }

                    using (SqlCommand command = new SqlCommand(query, connection)) {
                        command.Parameters.AddWithValue("@id_hoadon", "HD" + (count + 100000001).ToString().Substring(1));
                        command.Parameters.AddWithValue("@id_doan", item[0]);
                        command.Parameters.AddWithValue("@id_khachhang", ChooseClient.id_khachhang);
                        command.Parameters.AddWithValue("@id_thanhvien", AccountInfo.lblID.Text.Substring(4));
                        command.Parameters.AddWithValue("@soluong", item[3]);
                        command.Parameters.AddWithValue("@tonggia", item[4]);
                        command.Parameters.AddWithValue("@ngayban", item[5]);

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("add thanh cong");
                connection.Close();
            }
        }
    }
}
