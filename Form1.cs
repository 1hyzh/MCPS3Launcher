using System.Diagnostics;

namespace MCConsolesLauncher
{
    public partial class Form1 : Form
    {


        async Task downloadClient()
        {
            string cdn = "https://mcps3cdn.hyzh.uk/client.zip";
            string cFolder = @"C:\MCConsoles\client";
            var progress = new Progress<double>(percent =>
            {
                progressBar1.Value = (int)percent;
                label1.Text = $"{percent:0}%";
            });

            await download.DownloadFileWithProgressAsync(cdn, cFolder, progress);

        }
        async Task downloadClientandExtract()
        {
            try
            {
                await downloadClient();
                if (File.Exists(@"C:\MCConsoles\client\client.zip"))
                {
                    label1.Text = "Extracting...";
                    ZipHandler.ExtractAndCleanup(@"C:\MCConsoles\client\client.zip");
                    MessageBox.Show("Installation Complete!", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                label1.Text = "Ready!";
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\MCConsoles"))
            {
                if (Directory.Exists(@"C:\MCConsoles\client"))
                {
                    if (File.Exists(@"C:\MCConsoles\client\MinecraftClient.exe"))
                    {
                        MessageBox.Show("The client is already installed!", "Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        await downloadClientandExtract();
                    }
                }
                else
                {
                    Directory.CreateDirectory(@"C:\MCConsoles\client");
                    await downloadClientandExtract();
                }
            }
            else
            {
                Directory.CreateDirectory(@"C:\MCConsoles");
                Directory.CreateDirectory(@"C:\MCConsoles\client");
                await downloadClientandExtract();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usr = textBox1.Text;
            if (Directory.Exists(@"C:\MCConsoles\client"))
            {
                if (File.Exists(@"C:\MCConsoles\client\MinecraftClient.Exe"))
                {
                    Process.Start(@"C:\MCConsoles\client\MinecraftClient.exe", $"-name \"{usr}\"");
                }
                else
                {
                    MessageBox.Show("There is no installation, click download to install!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("There is no installation, click download to install!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] serverinfo = { textBox2.Text, textBox3.Text, textBox4.Text };
            if (Directory.Exists(@"C:\MCConsoles"))
            {
                if (Directory.Exists(@"C:\MCConsoles\client"))
                {
                    if (File.Exists(@"C:\MCConsoles\client\servers.txt"))
                    {
                        File.AppendAllLines(@"C:\MCConsoles\client\servers.txt", serverinfo);
                    }
                    else
                    {
                        File.CreateText(@"C:\MCConsoles\client\servers.txt");
                        File.AppendAllLines(@"C:\MCConsoles\client\servers.txt", serverinfo);
                    }

                }
                else
                {
                    MessageBox.Show("There is no installation, click download to install!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("There is no installation, click download to install!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\MCConsoles"))
            {
                if (Directory.Exists(@"C:\MCConsoles\client"))
                {
                    if (File.Exists(@"C:\MCConsoles\client\servers.txt"))
                    {
                        File.WriteAllText(@"C:\MCConsoles\client\servers.txt", "");
                    }
                    else
                    {
                        
                        
                    }

                }
                else
                {
                    MessageBox.Show("There is no installation, click download to install!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("There is no installation, click download to install!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
