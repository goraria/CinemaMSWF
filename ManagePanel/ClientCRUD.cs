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
    public partial class ClientCRUD : UserControl {
        public ClientCRUD() {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (Client.CheckTextBox() == true)
            {
                ClientProcess.AddClient();
                Client.ClientReload();
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Nhập còn thiếu");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            ClientProcess.UpdateClient();
            Client.ClientReload();

            ClearTextBox();
        }

        private void btnDel_Click(object sender, EventArgs e) {
            ClientProcess.RemoveClient();
            Client.ClientReload();

            ClearTextBox();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            Adding();
            Client.ClientReload();
            ClearTextBox();
        }

        public static void ClearTextBox() {
            ClientInfo.txtID.Text = string.Empty;
            ClientInfo.txtName.Text = string.Empty;
            ClientInfo.txtBirth.Text = string.Empty;
            ClientInfo.txtAddress.Text = string.Empty;
            ClientInfo.txtGender.Text = string.Empty;
            ClientInfo.txtPhone.Text = string.Empty;

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
