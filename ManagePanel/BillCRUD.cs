using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class BillCRUD : UserControl
    {
        public BillCRUD()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Bill.BillReload();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Bill.BillReload();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Bill.BillReload();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Bill.BillReload();
            ClearTextBox();
        }

        public static void ClearTextBox()
        {
            BillInfo.txtIDBill.Text = string.Empty;
            BillInfo.txtIDFood.Text = string.Empty;
            BillInfo.txtIDClient.Text = string.Empty;
            BillInfo.txtIDStaff.Text = string.Empty;
            BillInfo.txtQuantity.Text = string.Empty;
            BillInfo.txtPrice.Text = string.Empty;
            BillInfo.txtDate.Text = string.Empty;
        }
    }
}
