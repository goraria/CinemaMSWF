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
    public partial class FilmCRUD : UserControl {
        public FilmCRUD() {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (Film.CheckTextBox()) {
                FilmProcess.AddFilm();
                Film.FilmReload();
                ClearTextBox();
            } else {
                MessageBox.Show("Nhập còn thiếu");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            FilmProcess.UpdateFilm();
            Film.FilmReload();
            ClearTextBox();
        }

        private void btnDel_Click(object sender, EventArgs e) {
            //FilmProcess()
            Film.FilmReload();
            ClearTextBox();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            Adding();
            Film.FilmReload();
            ClearTextBox();
        }

        public static void ClearTextBox() {
            FilmInfo.txtID.Text = string.Empty;
            FilmInfo.txtDate.Text = string.Empty;
            FilmInfo.txtStudio.Text = string.Empty;
            FilmInfo.txtTime.Text = string.Empty;
            FilmInfo.txtCounter.Text = string.Empty;
            FilmInfo.txtGenre.Text = string.Empty;
            FilmInfo.txtCountry.Text = string.Empty;
            FilmInfo.txtName.Text = string.Empty;

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
