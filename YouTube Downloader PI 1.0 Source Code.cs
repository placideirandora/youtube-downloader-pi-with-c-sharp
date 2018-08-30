using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;

namespace YouTube_Downloader_PI
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
 

        protected StatusBar mainStatusBar = new StatusBar();

        protected StatusBarPanel statusPanel1 = new StatusBarPanel();

        protected StatusBarPanel datepanel = new StatusBarPanel();
            
 
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxQuality.SelectedIndex = 2;

            statusPanel1.BorderStyle = StatusBarPanelBorderStyle.Sunken;

            statusPanel1.Text = "Status: No video to download. Paste the video url and download the video.";

            statusPanel1.ToolTipText = "Current Activity";

            statusPanel1.AutoSize = StatusBarPanelAutoSize.Spring;

            mainStatusBar.Panels.Add(statusPanel1);

            mainStatusBar.ShowPanels = true;



            this.Controls.Add(mainStatusBar);



            datepanel.BorderStyle = StatusBarPanelBorderStyle.Raised;

            datepanel.ToolTipText = "Date: " + System.DateTime.Today.ToString();

            datepanel.ToolTipText = "Current Date";

            datepanel.Text = System.DateTime.Today.ToLongDateString();

            datepanel.AutoSize = StatusBarPanelAutoSize.Contents;

            mainStatusBar.Panels.Add(datepanel);



            mainStatusBar.ShowPanels = true;

       

            this.Controls.Add(mainStatusBar);



        }





        private void btnDowload_Click(object sender, EventArgs e)
        {

            statusPanel1.BorderStyle = StatusBarPanelBorderStyle.Sunken;

            statusPanel1.Text = "Status: Connecting to YouTube...";

            statusPanel1.ToolTipText = "Current Activity";

            statusPanel1.AutoSize = StatusBarPanelAutoSize.Spring;


            progressBar.Minimum = 0;

            progressBar.Maximum = 100;

            try


            {


                IEnumerable<VideoInfo> videos = DownloadUrlResolver.GetDownloadUrls(textBoxUrl.Text);

                VideoInfo video = videos.First(p => p.VideoType == VideoType.Mp4 && p.Resolution == Convert.ToInt32(comboBoxQuality.Text));

                if (video.RequiresDecryption)
                    DownloadUrlResolver.DecryptDownloadUrl(video);

                VideoDownloader downloader = new VideoDownloader(video, Path.Combine(textBoxPath.Text, video.Title + video.VideoExtension));

                downloader.DownloadProgressChanged += Downloader_DownloadProgressChanged;
                Thread thread = new Thread(() => { downloader.Execute(); }) { IsBackground = true };
                thread.Start();

                statusPanel1.BorderStyle = StatusBarPanelBorderStyle.Sunken;

                statusPanel1.Text = "Status: Downloading the video...";

                statusPanel1.ToolTipText = "Current Activity";

                statusPanel1.AutoSize = StatusBarPanelAutoSize.Spring;

               


            } catch
            {



            }


        }

        private void Downloader_DownloadProgressChanged(object sender, ProgressEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {

                progressBar.Value = (int)e.ProgressPercentage;

                lblPercentage.Text = $"{string.Format("{0:0.##}", e.ProgressPercentage)}%";

                progressBar.Update();

                if (progressBar.Value == progressBar.Maximum)

                {

                   DialogResult Response = MessageBox.Show("The video has been successfully downloaded from YouTube.", "Download Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    if (Response == DialogResult.OK)

                    {



                        textBoxUrl.Text = "";

                        progressBar.Value = 0;

                        lblPercentage.Text = "0%";


                        statusPanel1.BorderStyle = StatusBarPanelBorderStyle.Sunken;



            statusPanel1.Text = "Status: No video to download. Paste the video url and download the video.";

            statusPanel1.ToolTipText = "Current Activity";

            statusPanel1.AutoSize = StatusBarPanelAutoSize.Spring;

                       

                    }



                }

            }

          ));


        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
              using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select Where The Video Will Be Saved." })
            {

                if (fbd.ShowDialog() == DialogResult.OK)
                
                    textBoxPath.Text = fbd.SelectedPath;
           
                   
                

            }
        }

        private void linkLabelHelpUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Go to www.youtube.com, then open/watch the video that you want to download" +
                "  and copy the url/link of the video " +
                "by right-clicking on the video and select copy video url or you can also copy the video url/link right from the address bar." +
                " Lastly, After having copied the video url/link, paste it here for being able to download the video.","Copy And Paste The Video Url" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabelVideoQuality_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            MessageBox.Show("The video quality stands for the resolution - showing things clearly and with a lot of detail - of the video. " +
               "So, Higher the resolution, clearer the video. 240 pixels is the lower resolution." +
               " 360 pixels is the low resolution." +
               " 480 pixels is the medium/normal resolution." +
               " 780 pixels is the high resolution/high-definition/HD." +
               " 1080 pixels is the higher resolution/full high-definition/full HD." +
               " So, Select the video quality according to the quality of the YouTube video that you want to download. It is possible " +
               " to download a low quality video from a high quality video, but it is impossible to download" +
               " a high quality video from a low quality video. Therefore, You should firstly check the quality" +
               " of the Youtube video and select here the right video quality accordingly.  ", "Select The Right" +
               " Video Quality", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void linkLabelBrowseLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            MessageBox.Show("Select or type in the storage location/path where the video " +
                " will be saved while and after being downloaded from YouTube. ", "Select The Video Storage Location" , MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

       

        private void linkLabelProgressBar_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This is the progress bar of the video download operation. It shows" +
               " the percentage of the video download operation.", "Video Download Progress", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
        

        private void btnClipBoardPaste_Click_1(object sender, EventArgs e)
        {
            textBoxUrl.Text = Clipboard.GetText();
        }

    }
}
