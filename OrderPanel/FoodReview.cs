using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project {
    public partial class FoodReview : UserControl {
        public static DataTable dt = new DataTable();
        static public List<List<string>> foodList = new List<List<string>>();
        static public int foodTotal = 0;
        static public int summary = 0;

        public FoodReview() {
            InitializeComponent();
        }

        private void FoodReview_Load(object sender, EventArgs e) {
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("ten", typeof(string));
            dt.Columns.Add("loai", typeof(string));
            dt.Columns.Add("gia", typeof(int));
            dt.Columns.Add("Chon", typeof(int));

            addRow();
            dataGridView.DataSource = dt;
        }

        public static void addRow() {
            for (int i = 0; i < ChooseFood.counter; i++) {
                DataGridViewRow row = ChooseFood.dataGridView.Rows[i];

                if (Convert.ToInt32(row.Cells[5].Value) > 0) {
                    foodTotal = 0;
                    List<String> item = new List<string>();
                    DataRow dr = dt.NewRow();
                    dr[0] = row.Cells[0].Value;
                    dr[1] = row.Cells[1].Value;
                    dr[2] = row.Cells[2].Value;
                    dr[3] = row.Cells[4].Value;
                    dr[4] = row.Cells[5].Value;
                    dt.Rows.Add(dr);
                    foodTotal = Convert.ToInt32(dr[4]) * Convert.ToInt32(dr[3]);
                    summary += foodTotal;

                    item.Add(dr[0].ToString());
                    item.Add(ChooseClient.id_khachhang);
                    item.Add(AccountInfo.lblID.Text);
                    item.Add(dr[4].ToString());
                    item.Add(foodTotal.ToString());
                    item.Add(Program.dateString);

                    foodList.Add(item);
                }
            }
            //DataRow row =  dt.NewRow();
        }
    }
}
