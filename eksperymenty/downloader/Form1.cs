using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace downloader
{
    public partial class Form1 : Form
    {
        // Create a YoutubeClient instance
        private YoutubeClient youtubeClient = new YoutubeClient();

        public Form1()
        {
            InitializeComponent();
        }

        // Button click event to start the download
        private async void button1_Click(object sender, EventArgs e)
        {
            // Get the video URL from the textbox
            string videoUrl = textBox1.Text;

            // Check if the URL is not empty
            if (string.IsNullOrEmpty(videoUrl))
            {
                MessageBox.Show("Please enter a YouTube video URL.");
                return;
            }

            try
            {
                // Update status label
                label1.Text = "Fetching video information...";

                // Fetch video information
                var video = await youtubeClient.Videos.GetAsync(videoUrl);
                label1.Text = $"Downloading: {video.Title}";

                // Get available streams for the video (audio + video combined)
                var streamManifest = await youtubeClient.Videos.Streams.GetManifestAsync(video.Id);
                var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

                // If no stream available, show error
                if (streamInfo == null)
                {
                    MessageBox.Show("Unable to retrieve stream information.");
                    return;
                }

                // Define where to save the video (My Videos folder)
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos), $"{video.Title}.mp4");

                // Initialize progress bar
                progressBar1.Value = 0;
                progressBar1.Visible = true;

                // Download the video with progress reporting
                using (var progress = new Progress<double>(p =>
                {
                    progressBar1.Value = (int)(p * 100); // Update progress bar
                }))
                {
                    await youtubeClient.Videos.Streams.DownloadAsync(streamInfo, filePath, progress);
                }

                // Update status after download completes
                label1.Text = "Download Complete!";
                MessageBox.Show($"Download complete. Video saved to {filePath}");
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the download
                label1.Text = "Download failed.";
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
