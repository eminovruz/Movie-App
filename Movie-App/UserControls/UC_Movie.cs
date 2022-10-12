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

namespace Movie_App.UserControls
{
    public partial class UC_Movie : UserControl
    {
        private Movie movie = new();

        public UC_Movie(Movie movie)
        {
            InitializeComponent();
            this.movie = movie;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 wiewMore = new Form2(movie);
            wiewMore.ShowDialog();
        }
    }
}
