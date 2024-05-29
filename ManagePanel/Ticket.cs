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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Project;

namespace Project
{
    public partial class Ticket : UserControl
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            TicketReload();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            { // Kiểm tra nếu hàng được chọn có hợp lệ
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                // Lấy giá trị từ các ô trong hàng được chọn và hiển thị lên các TextBox
                TicketInfo.txtIDTicket.Text = row.Cells[0].Value.ToString();
                TicketInfo.txtIDFilm.Text = row.Cells[1].Value.ToString();
                TicketInfo.txtIDRoom.Text = row.Cells[2].Value.ToString();
                TicketInfo.txtIDSlot.Text = row.Cells[3].Value.ToString();
                TicketInfo.txtIDClient.Text = row.Cells[4].Value.ToString();
                TicketInfo.txtIDStaff.Text = row.Cells[5].Value.ToString();
                TicketInfo.txtIDTime.Text = row.Cells[6].Value.ToString();
                TicketInfo.txtDate.Text = Convert.ToDateTime(row.Cells[7].Value.ToString()).ToString("yyyy-MM-dd");
                TicketInfo.txtPrice.Text = row.Cells[8].Value.ToString();
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            { // Kiểm tra xem có hàng được chọn không
                DataGridViewRow row = dataGridView.SelectedRows[0];

                // Lấy giá trị từ các ô trong hàng được chọn và hiển thị lên các TextBox
                TicketInfo.txtIDTicket.Text = row.Cells[0].Value.ToString();
                TicketInfo.txtIDFilm.Text = row.Cells[1].Value.ToString();
                TicketInfo.txtIDRoom.Text = row.Cells[2].Value.ToString();
                TicketInfo.txtIDSlot.Text = row.Cells[3].Value.ToString();
                TicketInfo.txtIDClient.Text = row.Cells[4].Value.ToString();
                TicketInfo.txtIDStaff.Text = row.Cells[5].Value.ToString();
                TicketInfo.txtIDTime.Text = row.Cells[6].Value.ToString();
                TicketInfo.txtDate.Text = Convert.ToDateTime(row.Cells[7].Value.ToString()).ToString("yyyy-MM-dd");
                TicketInfo.txtPrice.Text = row.Cells[8].Value.ToString();
            }
        }

        public static void TicketReload()
        {
            string connectionString = Program.connectionString;
            string query = "SELECT * FROM [dbo].[Ve]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Truy vấn dữ liệu
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Gán dữ liệu cho DataGridView
                dataGridView.DataSource = dataTable;
            }
        }
    }
}
