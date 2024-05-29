using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project {
    internal class FilmProcess {
        public FilmProcess() {

        }

        static string connectionString = Program.connectionString;

        static public void AddFilm() {
            int count = 0;
            string counter = "SELECT COUNT(*) FROM [Cinema].[dbo].[Phim]";
            string query = "INSERT INTO [dbo].[Phim]([id_phim],[tenphim],[quocgia],[theloai],[sove],[thoiluong],[hanglamphim],[ngayramat]) " +
                "VALUES(@id_phim,@tenphim,@quocgia,@theloai,@sove,@thoiluong,@hanglamphim,@ngayramat)";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                using (SqlCommand command = new SqlCommand(counter, connection)) {
                    count = (int)command.ExecuteScalar();
                }
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@id_phim", "PM" + (count + 100000001).ToString().Substring(1));
                    command.Parameters.AddWithValue("@tenphim", FilmInfo.txtName.Text);
                    command.Parameters.AddWithValue("@quocgia", FilmInfo.txtCountry.Text);
                    command.Parameters.AddWithValue("@theloai", FilmInfo.txtGenre.Text);
                    command.Parameters.AddWithValue("@sove", 0);
                    command.Parameters.AddWithValue("@thoiluong", Convert.ToInt32(FilmInfo.txtTime.Text));
                    command.Parameters.AddWithValue("@hanglamphim", FilmInfo.txtStudio.Text);
                    command.Parameters.AddWithValue("@ngayramat", FilmInfo.txtDate.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("add thanh cong");
                }
                connection.Close();
            }
            FilmCRUD.ClearTextBox();
        }

        public static void DelFilm() {
            FilmCRUD.ClearTextBox();
        }

        public static void EditFilm() {
            FilmCRUD.ClearTextBox();
        }

        static public void UpdateFilm() {
            string query = "UPDATE [dbo].[Phim] " +
                "SET [tenphim] = @tenphim,[quocgia] = @quocgia,[theloai] = @theloai,[thoiluong] = @thoiluong,[hanglamphim] = @hanglamphim,[ngayramat] = @ngayramat " +
                "WHERE id_phim = @id_phim ";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@id_phim", FilmInfo.txtID.Text);
                    command.Parameters.AddWithValue("@tenphim", FilmInfo.txtName.Text);
                    command.Parameters.AddWithValue("@quocgia", FilmInfo.txtCountry.Text);
                    command.Parameters.AddWithValue("@theloai", FilmInfo.txtGenre.Text);
                    command.Parameters.AddWithValue("@thoiluong", Convert.ToInt32(FilmInfo.txtTime.Text));
                    command.Parameters.AddWithValue("@hanglamphim", FilmInfo.txtStudio.Text);
                    command.Parameters.AddWithValue("@ngayramat", FilmInfo.txtDate.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("update thanh cong");
                }
                connection.Close();
            }
            FilmCRUD.ClearTextBox();
        }
    }
}
