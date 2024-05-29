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
    public partial class TopHome : UserControl {
        public TopHome() {
            InitializeComponent();
        }

        private void btnHot_Click(object sender, EventArgs e) {
            btnHot.Enabled = false;
            btnNew.Enabled = true;

            Home.filmHot.Visible = true;
            Home.filmNew.Visible = false;

            FilmHot.FilmHotReload();
        }

        private void btnNew_Click(object sender, EventArgs e) {
            btnHot.Enabled = true;
            btnNew.Enabled = false;

            Home.filmHot.Visible = false;
            Home.filmNew.Visible = true;

            FilmNew.FilmNewReload();
        }
    }
}
