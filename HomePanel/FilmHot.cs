using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project;

namespace Project {
    public partial class FilmHot : UserControl {
        public FilmHot() {
            InitializeComponent();
        }

        private void FilmHot_Load(object sender, EventArgs e) {
            FilmHotReload();
        }

        public static void FilmHotReload()
        {
            FilmIcon[] filmIcon = new FilmIcon[] {
                filmIcon1,
                filmIcon2,
                filmIcon3,
                filmIcon4,
                filmIcon5,
                filmIcon6,
                filmIcon7,
                filmIcon8,
                filmIcon9,
                filmIcon0
            };

            int index = 0;
            foreach (List<string> selected in Home.selectionHotest) {
                filmIcon[index].label.Text = selected[1];
                filmIcon[index].pictureBox.ImageLocation = Home.ImagePath(selected[0]);

                index++;
            }
        }
    }
}
