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
    public partial class Home : UserControl {
        public Home() {
            InitializeComponent();
            Processing();
        }

        public static string ImagePath(string filename) {
            filename += ".jpg";
            try {
                // Lấy đường dẫn thư mục gốc của ứng dụng (thường là thư mục chứa tập tin exe của ứng dụng)
                //string rootDirectory = AppDomain.CurrentDomain.BaseDirectory;
                //string rootDirectory = Directory.GetCurrentDirectory();
                string rootDirectory = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())));
                // Xây dựng đường dẫn tương đối tới tập tin mong muốn
                string relativePath = Path.Combine("img", filename);
                // Kết hợp đường dẫn thư mục gốc với đường dẫn tương đối để tạo đường dẫn hoàn chỉnh
                string fullPath = Path.Combine(rootDirectory, relativePath);

                // Sử dụng đường dẫn hoàn chỉnh để thực hiện các thao tác với tập tin
                if (File.Exists(fullPath)) {
                    return fullPath;
                } else {
                    return "";
                }
            } catch (Exception ex) {
                return "";
            }
        }

        public static List<List<string>> selectionHotest = new List<List<string>>();
        public static List<List<string>> selectionNewest = new List<List<string>>();

        public static void Processing() {
            string connectionString = Program.connectionString;
            string queryHotest = "" +
                "SELECT TOP 10 *" +
                "FROM (" +
                    "SELECT *," +
                        "ROW_NUMBER() OVER (ORDER BY [sove] DESC) AS [row_num] " +
                    "FROM [Cinema].[dbo].[Phim] " +
                    "WHERE [ngayramat] >= DATEADD(DAY, -60, GETDATE()) AND [ngayramat] <= GETDATE()" +
                ") AS subquery " +
                "WHERE [row_num] <= 10 " +
                "ORDER BY [row_num] ASC;" +
            "";
            string queryNewest = "" +
                "SELECT TOP 10 *" +
                "FROM (" +
                    "SELECT *," +
                        "ROW_NUMBER() OVER (ORDER BY [ngayramat] DESC) AS [row_num] " +
                    "FROM [Cinema].[dbo].[Phim] " +
                    "WHERE [ngayramat] >= DATEADD(DAY, -60, GETDATE()) AND [ngayramat] <= GETDATE()" +
                ") AS subquery " +
                "WHERE [row_num] <= 10 " +
                "ORDER BY [ngayramat] DESC;" +
            "";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                using (SqlCommand command = new SqlCommand(queryHotest, connection)) {
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            List<string> list = new List<string>();
                            for (int i = 0; i < reader.FieldCount; i++) {
                                list.Add(reader[i].ToString());
                            }
                            selectionHotest.Add(list);
                        }
                    }
                }
                using (SqlCommand command = new SqlCommand(queryNewest, connection)) {
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            List<string> list = new List<string>();
                            for (int i = 0; i < reader.FieldCount; i++) {
                                list.Add(reader[i].ToString());
                            }
                            selectionNewest.Add(list);
                        }
                    }
                }
                connection.Close();
            }

            //filmIcon1.label.Text = "PM00000001";
            //filmIcon2.label.Text = "PM00000002";
            //filmIcon3.label.Text = "PM00000003";
            //filmIcon4.label.Text = "PM00000004";
            //filmIcon5.label.Text = "PM00000005";
            //filmIcon6.label.Text = "PM00000006";
            //filmIcon7.label.Text = "PM00000007";
            //filmIcon8.label.Text = "PM00000008";
            //filmIcon9.label.Text = "PM00000009";
            //filmIcon0.label.Text = "PM00000010";

            //filmIcon1.pictureBox.ImageLocation = Home.ImagePath(filmIcon1.label.Text + ".jpg");
            //filmIcon2.pictureBox.ImageLocation = Home.ImagePath(filmIcon2.label.Text + ".jpg");
            //filmIcon3.pictureBox.ImageLocation = Home.ImagePath(filmIcon3.label.Text + ".jpg");
            //filmIcon4.pictureBox.ImageLocation = Home.ImagePath(filmIcon4.label.Text + ".jpg");
            //filmIcon5.pictureBox.ImageLocation = Home.ImagePath(filmIcon5.label.Text + ".jpg");
            //filmIcon6.pictureBox.ImageLocation = Home.ImagePath(filmIcon6.label.Text + ".jpg");
            //filmIcon7.pictureBox.ImageLocation = Home.ImagePath(filmIcon7.label.Text + ".jpg");
            //filmIcon8.pictureBox.ImageLocation = Home.ImagePath(filmIcon8.label.Text + ".jpg");
            //filmIcon9.pictureBox.ImageLocation = Home.ImagePath(filmIcon9.label.Text + ".jpg");
            //filmIcon0.pictureBox.ImageLocation = Home.ImagePath(filmIcon0.label.Text + ".jpg");

            //FilmIcon[] filmIcon = new FilmIcon[] {
            //    filmIcon1,
            //    filmIcon2,
            //    filmIcon3,
            //    filmIcon4,
            //    filmIcon5,
            //    filmIcon6,
            //    filmIcon7,
            //    filmIcon8,
            //    filmIcon9,
            //    filmIcon0
            //};

            //for (int index = 0; index < filmIcon.Length; index++) {
            //    filmIcon[index].label.Text = Home.selection[index, 1];
            //    filmIcon[index].pictureBox.ImageLocation = Home.ImagePath(Home.selection[index, 0] + ".jpg");
            //}

            //int index = 0;
            //foreach (List<string> selected in Home.selectionNewest) {
            //    foreach (string str in selected) {
            //        filmIcon[index].label.Text = selected[0];
            //        filmIcon[index].pictureBox.ImageLocation = Home.ImagePath(str + ".jpg");
            //    }

            //    index++;
            //}
        }

        //private void ResizeImage(string inputImagePath, string outputImagePath, int newWidth, int newHeight) {
        //    using (Image inputImage = Image.FromFile(inputImagePath)) {
        //        using (Bitmap outputImage = new Bitmap(newWidth, newHeight)) {
        //            using (Graphics graphics = Graphics.FromImage(outputImage)) {
        //                graphics.DrawImage(inputImage, 0, 0, newWidth, newHeight);
        //            }

        //            outputImage.Save(outputImagePath);
        //        }
        //    }
        //} // ResizeImage("input.jpg", "output.jpg", 300, 200);
    }
}
