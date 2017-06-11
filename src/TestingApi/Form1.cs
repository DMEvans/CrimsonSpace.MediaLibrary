namespace TestingApi
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private const string TMDb_ApiKey = "03b6ba3883e72348e93c1f2f9d0b8bec";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            //var genreApi = new GenreApi(TMDb_ApiKey);

            //var genres = genreApi.GetMovieGenres();

            //foreach (var genre in genres)
            //{
            //    var listViewItemStrings = new string[] { genre.Id.ToString(), genre.Name };
            //    var listViewItem = new ListViewItem(listViewItemStrings);
            //    listView1.Items.Add(listViewItem);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var movieApi = new MovieApi(TMDb_ApiKey);

            //var movieSearchResult = movieApi.SearchMovies(textBox1.Text, 1);

            //foreach (var movie in movieSearchResult.Results)
            //{
            //    var listViewItemStrings = new string[] { movie.Title, movie.ReleaseDate.ToDateTime().Year.ToString() };
            //    var listViewItem = new ListViewItem(listViewItemStrings);
            //    listViewItem.Tag = movie.Id;
            //    listView2.Items.Add(listViewItem);
            //}
        }
    }
}