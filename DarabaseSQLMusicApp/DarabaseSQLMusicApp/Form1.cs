using System.Diagnostics;
using System.Windows.Forms;

namespace DarabaseSQLMusicApp
{
    public partial class Form1 : Form
    {
        BindingSource albumBindingSource = new BindingSource();
        BindingSource trackBindingSource = new BindingSource();
        List<Album> albums = new List<Album>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            albums = albumsDAO.getAllAlbums();

            albumBindingSource.DataSource = albums;

            dataGridView1.DataSource = albumBindingSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            albumBindingSource.DataSource = albumsDAO.searchTitles(textBox1.Text);

            dataGridView1.DataSource = albumBindingSource;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int row = dataGridView.CurrentRow.Index;

            string imageURL = dataGridView.Rows[row].Cells[4].Value.ToString();

            pictureBox1.Load(imageURL);

            //AlbumsDAO albumsDAO = new AlbumsDAO();
            //trackBindingSource.DataSource = albumsDAO.getTracksUsingJoin((int)dataGridView.Rows[row].Cells[0].Value);
            trackBindingSource.DataSource = albums[row].Tracks;
            dataGridView2.DataSource = trackBindingSource;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Album album = new Album
            {
                AlbumName = txt_name.Text,
                ArtistName = txt_artist.Text,
                Year = Int32.Parse(txt_year.Text),
                ImageURL = txt_imageURL.Text,
                Description = txt_description.Text
            };

            AlbumsDAO albumDAO = new AlbumsDAO();
            int res = albumDAO.addOneAlbum(album);

            MessageBox.Show(res.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int row = dataGridView2.CurrentRow.Index;
            int trackId = (int)dataGridView2.Rows[row].Cells[0].Value;

            AlbumsDAO albumsDAO = new AlbumsDAO();
            int res = albumsDAO.deleteTrack(trackId);

            dataGridView2.DataSource = null;
            albums = albumsDAO.getAllAlbums();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;
            int row2 = dataGridView2.CurrentRow.Index;
            int trackId = (int)dataGridView2.Rows[row2].Cells[0].Value;
            List<Track> tracks = albums[row].Tracks;
            Track track = tracks[row2];
            string video_url = track.VideoURL;
            webView21.EnsureCoreWebView2Async();

            webView21.NavigateToString(video_url);

        }
    }
}
