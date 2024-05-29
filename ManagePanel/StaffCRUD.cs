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

namespace Project
{
    public partial class StaffCRUD : UserControl
    {
        public StaffCRUD()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Staff.CheckTextBox())
            {
                StaffProcess.AddStaff();
                Staff.StaffReload();
                StaffCRUD.ClearTextBox();
            }
            else
            {
                MessageBox.Show("Nhập thiếu");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            StaffProcess.UpdateStaff();
            Staff.StaffReload();
            StaffCRUD.ClearTextBox();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            StaffProcess.RemoveStaff();
            Staff.StaffReload();
            StaffCRUD.ClearTextBox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Adding();
            Staff.StaffReload();
            StaffCRUD.ClearTextBox();
        }

        public static void ClearTextBox()
        {
            StaffInfo.txtID.Text = string.Empty;
            StaffInfo.txtName.Text = string.Empty;
            StaffInfo.txtBirth.Text = string.Empty;
            StaffInfo.txtAddress.Text = string.Empty;
            StaffInfo.txtGender.Text = string.Empty;
            StaffInfo.txtPhone.Text = string.Empty;
            StaffInfo.txtType.Text = string.Empty;
            StaffInfo.txtUsername.Text = string.Empty;
            StaffInfo.txtPassword.Text = string.Empty;

            Adding();
        }

        public static void Editing()
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            btnUpdate.Enabled = true;
        }

        public static void Adding()
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnUpdate.Enabled = true;
        }
    }
}
