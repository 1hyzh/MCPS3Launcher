using MCPS3L;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;

namespace MCPS3Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        async Task downloadClient()
        {
            string remoteUrl = "https://mcps3cdn.hyzh.uk/client.zip";
            string localFolder = @"C:\MCPS3\";

            var progress = new Progress<double>(percent =>
            {
                pbDownload.Value = (int)percent;
                lblStatus.Text = $"Downloading: {percent:0}%";
            });

            
            await FileDownloader.DownloadFileWithProgressAsync(remoteUrl, localFolder, progress);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            pbDownload.Visible = true;
            lblStatus.Visible = true;
            string installPath = @"C:\MCPS3\";
            string exePath = Path.Combine(installPath, "MinecraftClient.exe");
            string zipPath = Path.Combine(installPath, "client.zip");

            
            if (File.Exists(exePath))
            {
                MessageBox.Show("The client is already installed!", "Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            
            if (!Directory.Exists(installPath))
            {
                Directory.CreateDirectory(installPath);
            }

            
            try
            {
                button2.Enabled = false; 

                
                await downloadClient();

                if (File.Exists(zipPath))
                {
                    lblStatus.Text = "Extracting files...";

                    
                    ZipHandler.ExtractAndCleanup(zipPath);

                    MessageBox.Show("Installation Complete!", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                button2.Enabled = true;
                lblStatus.Text = "Ready";
                pbDownload.Visible = false;
                lblStatus.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usr = textBox1.Text;
            if (Directory.Exists(@"C:\MCPS3\"))
            {
                if (File.Exists(@"C:\MCPS3\MinecraftClient.Exe"))
                {
                    Process.Start(@"C:\MCPS3\MinecraftClient.exe", $"-name \"{usr}\"");
                }
                else
                {
                    MessageBox.Show("There is no mc", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbDownload.Visible = false;
            lblStatus.Visible = false;
        }
    }
}
