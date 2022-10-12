using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Movie_App.Models;
using Movie_App.UserControls;

namespace Movie_App
{
    public partial class Form2 : Form
    {
        public Form2(Movie movie)
        {
            InitializeComponent();
            FillLabels(movie);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void FillLabels(Movie mov)
        {
            Author_lbl.Text += mov.Title;
            leanguage_lbl.Text += mov.Language;
            IMBD_lbl.Text += mov.imdbID;
            Website_lbl.Text += mov.Website;
            Awards.Text += mov.Awards;
            pictureBox1.LoadAsync(mov.Poster);

            for (int i = 0; i < mov.Star; i++)
            {
                UC_star star = new UC_star();
                star.Dock = DockStyle.Left;
                Starts_panel.Controls.Add(star);

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
