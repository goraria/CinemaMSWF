using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project;

namespace Project {
    public partial class FoodCRUD : UserControl {
        public FoodCRUD() {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (Food.CheckTextBox())
            {
                FoodProcess.AddFood();
                Food.Foodreload();

                ClearTextBox();
            }else
            {
                MessageBox.Show("Nhập thiếu");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            FoodProcess.UpdateFood();
            Food.Foodreload();
            ClearTextBox();
        }

        private void btnDel_Click(object sender, EventArgs e) {
            FoodProcess.RemoveFood();
            Food.Foodreload();
            ClearTextBox();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            Editing();
            Food.Foodreload();
            ClearTextBox();
        }

        public static void ClearTextBox() {
            FoodInfo.txtID.Text = string.Empty;
            FoodInfo.txtName.Text = string.Empty;
            FoodInfo.txtPrice.Text = string.Empty;
            FoodInfo.txtQuantity.Text = string.Empty;
            FoodInfo.txtType.Text = string.Empty;

            Adding();
        }

        public static void Editing() {
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            btnUpdate.Enabled = true;
        }

        public static void Adding() {
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnUpdate.Enabled = true;
        }
    }
}
