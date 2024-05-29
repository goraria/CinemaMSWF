using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project {
    internal class TicketProcess {
        public TicketProcess() {

        }

        static string connectionString = Program.connectionString;
        public static List<List<string>> roomList = new List<List<string>>();
        public static string id_room = "";
        public static string id_ghe = "";
        public static int summary = 0;
        public static int price = 0;

        static public void AddTicket() {
            int count = 0;
            //int summary = 0;
            string counter = "SELECT COUNT(*) FROM [Cinema].[dbo].[Ve]";
            string query = "INSERT INTO [dbo].[Ve]([id_ve],[id_phim],[id_phong],[id_ghe],[id_khachhang],[id_nhanvien],[id_cachieu],[ngayban],[giave]) " +
                " VALUES(@id_ve,@id_phim,@id_phong,@id_ghe,@id_khachhang,@id_nhanvien,@id_cachieu,@ngayban,@giave)";
            string filmUpdate = "UPDATE [dbo].[Phim] SET sove = sove + 1 WHERE id_phim = @id_phim";
            string slotUpdate = "UPDATE [dbo].[Ghe] SET trangthai = 1 WHERE id_ghe = @id_ghe";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                foreach (string item in ChooseSlot.disabledButtons) {
                    SlotCheck(item);
                    using (SqlCommand command = new SqlCommand(counter, connection)) {
                        count = (int)command.ExecuteScalar();
                    }
                    using (SqlCommand command = new SqlCommand(query, connection)) {
                        command.Parameters.AddWithValue("@id_ve", "VE" + (count + 100000001).ToString().Substring(1));
                        command.Parameters.AddWithValue("@id_phim", ChooseFilm.id_phim);
                        command.Parameters.AddWithValue("@id_phong", id_room);
                        command.Parameters.AddWithValue("@id_ghe", id_ghe);
                        command.Parameters.AddWithValue("@id_khachhang", ChooseClient.id_khachhang);
                        command.Parameters.AddWithValue("@id_nhanvien", AccountInfo.lblID.Text.Substring(4));
                        command.Parameters.AddWithValue("@id_cachieu", ChooseTime.id_cachieu);
                        command.Parameters.AddWithValue("@ngayban", Program.dateString);
                        command.Parameters.AddWithValue("@giave", price);

                        command.ExecuteNonQuery();
                    }
                    using (SqlCommand command = new SqlCommand(filmUpdate, connection)) {
                        command.Parameters.AddWithValue("@id_phim", ChooseFilm.id_phim);
                        command.ExecuteNonQuery();
                    }
                    using (SqlCommand command = new SqlCommand(slotUpdate, connection)) {
                        command.Parameters.AddWithValue("@id_ghe", id_ghe);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Order Successful");
                connection.Close();
            }
        }

        private static void RoomList() {
            foreach (List<string> item in Home.selectionNewest) {
                List<string> list = new List<string>();
                list.Add(item[0].ToString());
                if (Convert.ToInt32(item[8]) < 10) {
                    list.Add($"PH00{item[8].ToString()}");
                } else {
                    list.Add("PH000");
                }
                roomList.Add(list);
            }
        }

        public static void RoomCheck() {
            id_room = "";
            summary = 0;
            price = 0;
            RoomList();
            foreach (List<string> item in roomList) {
                if (item[0] == ChooseFilm.id_phim) {
                    id_room = item[1];
                    if (item[1] == "PH000") {
                        price = 5;
                    } else {
                        price = 3;
                    }
                }
            }
            if (id_room == "") {
                id_room = "PH000";
                price = 5;
            }

            foreach (string item in ChooseSlot.disabledButtons) {
                summary += price;
            }
        }

        public static void SlotCheck(string tenghe) {
            RoomCheck();
            string connectionString = Program.connectionString;
            string query = "SELECT id_ghe FROM [dbo].[Ghe] WHERE tenghe = @tenghe AND id_phong = @id_phong";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@tenghe", tenghe);
                    command.Parameters.AddWithValue("@id_phong", id_room);
                    command.ExecuteNonQuery();
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            for (int i = 0; i < reader.FieldCount; i++) {
                                id_ghe = reader[i].ToString();
                            }
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void DelTicket() { 
        
        }

        public static void UpdateTicket() { 
            TicketCRUD.ClearTextBox();
        }
    }
}
