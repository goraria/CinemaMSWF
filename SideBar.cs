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
    public partial class SideBar : UserControl {
        public SideBar() {
            InitializeComponent();
        }

        private void buttonHome_Click(object sender, EventArgs e) {
            buttonHome.Enabled = false;
            buttonOrder.Enabled = true;
            buttonManage.Enabled = true;
            buttonAccount.Enabled = true;

            ContentBar.homePanel.Visible = true;
            ContentBar.orderPanel.Visible = false;
            ContentBar.managePanel.Visible = false;
            ContentBar.accountPanel.Visible = false;
        }

        private void buttonOrder_Click(object sender, EventArgs e) {
            buttonHome.Enabled = true;
            buttonOrder.Enabled = false;
            buttonManage.Enabled = true;
            buttonAccount.Enabled = true;

            ContentBar.homePanel.Visible = false;
            ContentBar.orderPanel.Visible = true;
            ContentBar.managePanel.Visible = false;
            ContentBar.accountPanel.Visible = false;
        }

        private void buttonManage_Click(object sender, EventArgs e) {
            buttonHome.Enabled = true;
            buttonOrder.Enabled = true;
            buttonManage.Enabled = false;
            buttonAccount.Enabled = true;

            ContentBar.homePanel.Visible = false;
            ContentBar.orderPanel.Visible = false;
            ContentBar.managePanel.Visible = true;
            ContentBar.accountPanel.Visible = false;
        }

        private void buttonAccount_Click(object sender, EventArgs e) {
            buttonHome.Enabled = true;
            buttonOrder.Enabled = true;
            buttonManage.Enabled = true;
            buttonAccount.Enabled = false;

            ContentBar.homePanel.Visible = false;
            ContentBar.orderPanel.Visible = false;
            ContentBar.managePanel.Visible = false;
            ContentBar.accountPanel.Visible = true;
        }
    }
}
