using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project {
    public partial class ChooseFood : UserControl {

        static public DataTable foodTable;
        static public int counter = 0;
        public ChooseFood() {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e) {
            Order.chooseFilm.Visible = false;
            Order.chooseClient.Visible = false;
            Order.chooseTime.Visible = false;
            Order.chooseSlot.Visible = false;
            Order.chooseFood.Visible = false;
            Order.final.Visible = true;
        }

        private void btnPrevious_Click(object sender, EventArgs e) {
            Order.chooseFilm.Visible = false;
            Order.chooseClient.Visible = false;
            Order.chooseTime.Visible = false;
            Order.chooseSlot.Visible = true;
            Order.chooseFood.Visible = false;
            Order.final.Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            ClearChooseFood();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) { // Kiểm tra nếu hàng được chọn có hợp lệ
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                txtName.Text = row.Cells[1].Value.ToString();
                txtQuantity.Text = row.Cells[5].Value.ToString();
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e) {
            if (dataGridView.SelectedRows.Count > 0) {
                DataGridViewRow row = dataGridView.SelectedRows[0];

                txtName.Text = row.Cells[1].Value.ToString();
                txtQuantity.Text = row.Cells[5].Value.ToString();
            }
        }

        private void ChooseFood_Load(object sender, EventArgs e) {

            ChooseFoodLoading();
        }
        public static void ChooseFoodLoading() {
            string connectionString = Program.connectionString;
            string query = "SELECT * FROM [dbo].[Doan]";
            //int counter = 0;
            string count = "SELECT COUNT(*) FROM [dbo].[Doan]";
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                using (SqlCommand commanda = new SqlCommand(count, connection)) {
                    counter = Convert.ToInt32(commanda.ExecuteScalar());
                }

                // Truy vấn dữ liệu
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);
                //dataTable.Columns.Remove("id_doan");
                dataTable.Columns.Add("Chon", typeof(int));
                // Gán dữ liệu cho DataGridView
                dataGridView.DataSource = dataTable;

                addNewChooseColumn(counter);
                foodTable = dataTable;
            }
        }
        static public void addNewChooseColumn(int counter) {

            for (int i = 0; i < counter; i++) {
                DataGridViewRow row = dataGridView.Rows[i];
                row.Cells[5].Value = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            int selectIndex = dataGridView.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView.Rows[selectIndex];

            row.Cells[5].Value = Convert.ToInt32(row.Cells[5].Value) + 1;
            txtQuantity.Text = row.Cells[5].Value.ToString();
            if (Convert.ToInt32(row.Cells[5].Value) == 200) {
                button2.Enabled = false;
            }
            //if (e.RowIndex >= 0)
            //{ // Kiểm tra nếu hàng được chọn có hợp lệ
            //    DataGridViewRow row = dataGridView.Rows[e.RowIndex];

            //    txtName.Text = row.Cells[0].Value.ToString();
            //    txtQuantity.Text = row.Cells[5].Value.ToString();
            //}
        }

        private void button1_Click(object sender, EventArgs e) {
            int selectIndex = dataGridView.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView.Rows[selectIndex];
            row.Cells[5].Value = Convert.ToInt32(row.Cells[5].Value) - 1;
            txtQuantity.Text = row.Cells[5].Value.ToString();
            if (Convert.ToInt32(row.Cells[5].Value) == 0) {
                button1.Enabled = false;
            }
        }

        public static void ClearChooseFood() {
            txtQuantity.Text = "";
            txtName.Text = "";
            ChooseFoodLoading();
            addNewChooseColumn(counter);
        }
    }
}
