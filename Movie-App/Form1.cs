using System.Text.Json;
using Movie_App.Models;

namespace Movie_App
{
    public partial class Form1 : Form
    {
        private List<string> filmNames = new();
        public List<Movie> films = new();
        const string _apikey = "751b1d2e";
        const string _url = $"http://www.omdbapi.com/?apikey={_apikey}&";
        private int lastIndex = 0;

        public Form1()
        {
            InitializeComponent();
            filmNames.Add("Run");
            filmNames.Add("Cars");
            filmNames.Add("Home");
            filmNames.Add("Hello");
            filmNames.Add("Car");
            filmNames.Add("Recep Ivedik");
            FillFilms();
        }


        private async void FillFilms()
        {
            foreach (var item in filmNames.Skip(lastIndex))
            {
                string search = $"{_url}t={item}";
                using HttpClient client = new();


                var jsonResult = await client.GetStringAsync(search);
                Movie movie = JsonSerializer.Deserialize<Models.Movie>(jsonResult);
                films.Add(movie);

                UserControls.UC_Movie movie_uc = new(movie);
                movie_uc.MoviePicture_pctbx.LoadAsync(movie?.Poster);
                panel1.Controls.Add(movie_uc);
                movie_uc.Dock = DockStyle.Left;

            }


        }
        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            search_box.Visible = !search_box.Visible;
            button1.Visible = !button1.Visible;

           
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string search = $"{_url}t={search_box.Text}";
            using HttpClient client = new();
            Random r = new();

            var jsonResult = await client.GetStringAsync(search);
            Movie movie = JsonSerializer.Deserialize<Models.Movie>(jsonResult);
            movie.Star = r.Next(1, 5);
            Form2 f = new Form2(movie);
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // this.BackColor = Color.FromArgb(21, 101, 192);
        }
    }
}