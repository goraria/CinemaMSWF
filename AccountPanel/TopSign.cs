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
    public partial class TopSign : UserControl {
        public TopSign() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            btnLogin.Enabled = false;
            btnChange.Enabled = false;
            btnInfo.Enabled = false;

            CenterSign.login.Visible = true;
            CenterSign.check.Visible = false;
            CenterSign.reset.Visible = false;
            CenterSign.accountInfo.Visible = false;
        }

        private void btnChange_Click(object sender, EventArgs e) {
            btnLogin.Enabled = false;
            btnChange.Enabled = false;
            btnInfo.Enabled = true;

            CenterSign.login.Visible = false;
            CenterSign.check.Visible = true;
            CenterSign.reset.Visible = false;
            CenterSign.accountInfo.Visible = false;
        }

        private void btnInfo_Click(object sender, EventArgs e) {
            btnLogin.Enabled = false;
            btnChange.Enabled = true;
            btnInfo.Enabled = false;

            CenterSign.login.Visible = false;
            CenterSign.check.Visible = false;
            CenterSign.reset.Visible = false;
            CenterSign.accountInfo.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e) {
            Login.LogOut();
        }
    }
}
