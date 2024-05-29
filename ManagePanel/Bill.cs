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

namespace Project
{
    public partial class Bill : UserControl
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            BillReload();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            { // Kiểm tra nếu hàng được chọn có hợp lệ
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                // Lấy giá trị từ các ô trong hàng được chọn và hiển thị lên các TextBox
                BillInfo.txtIDBill.Text = row.Cells[0].Value.ToString();
                BillInfo.txtIDFood.Text = row.Cells[1].Value.ToString();
                BillInfo.txtIDClient.Text = row.Cells[2].Value.ToString();
                BillInfo.txtIDStaff.Text = row.Cells[3].Value.ToString();
                BillInfo.txtQuantity.Text = row.Cells[4].Value.ToString();
                BillInfo.txtPrice.Text = row.Cells[5].Value.ToString();
                BillInfo.txtDate.Text = Convert.ToDateTime(row.Cells[6].Value.ToString()).ToString("yyyy-MM-dd");
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            { // Kiểm tra xem có hàng được chọn không
                DataGridViewRow row = dataGridView.SelectedRows[0];

                // Lấy giá trị từ các ô trong hàng được chọn và hiển thị lên các TextBox
                BillInfo.txtIDBill.Text = row.Cells[0].Value.ToString();
                BillInfo.txtIDFood.Text = row.Cells[1].Value.ToString();
                BillInfo.txtIDClient.Text = row.Cells[2].Value.ToString();
                BillInfo.txtIDStaff.Text = row.Cells[3].Value.ToString();
                BillInfo.txtQuantity.Text = row.Cells[4].Value.ToString();
                BillInfo.txtPrice.Text = row.Cells[5].Value.ToString();
                BillInfo.txtDate.Text = Convert.ToDateTime(row.Cells[6].Value.ToString()).ToString("yyyy-MM-dd");
            }
        }

        public static void BillReload()
        {
            string connectionString = Program.connectionString;
            string query = "SELECT * FROM [dbo].[Hoadon]";
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
