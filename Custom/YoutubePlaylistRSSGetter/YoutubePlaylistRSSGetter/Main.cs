using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubePlaylistRSSGetter
{
    public partial class Main : Form
    {
        TextBox textBoxObj;
        public Main()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBoxObj = (TextBox)sender;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void activate_Click(object sender, EventArgs e)
        {
            StringBuilder rssFeed = new StringBuilder();
            rssFeed.Append(@"http://gdata.youtube.com/feeds/api/playlists/");
            try
            {
                string inputURL = textBoxObj.Text;
                string playlistID = inputURL.Substring(inputURL.IndexOf("list=PL") + 7);
                rssFeed.Append(playlistID);
                Clipboard.SetDataObject(rssFeed.ToString(), true);
                MessageBox.Show("RSS Feed has been copied to the clipboard.", "Success!");
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid URL!", "Error!");
            }
        }
    }
}
