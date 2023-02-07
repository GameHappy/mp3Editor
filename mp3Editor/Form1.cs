using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using VideoLibrary;
using MediaToolkit.Model;
using MediaToolkit;
using System.Threading;

namespace mp3Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        /*
         var source = @"<your destination folder>";
var youtube = YouTube.Default;
var vid = youtube.GetVideo("<video url>");
File.WriteAllBytes(source + vid.FullName, vid.GetBytes());

var inputFile = new MediaFile { Filename = source + vid.FullName };
var outputFile = new MediaFile { Filename = $"{source + vid.FullName}.mp3" };

using (var engine = new Engine())
{
    engine.GetMetadata(inputFile);

    engine.Convert(inputFile, outputFile);
}
         
         */
        private void URL_btn_Click(object sender, EventArgs e)
        {
            YoutubeDownload_StatueLab.Text = "Downloading...";
            URL_btn.Enabled = false;
            SelectFolder_btn.Enabled = false;
            URL_txt.Enabled = false;
            SaveToMp3_txt.Enabled = false;
            
            //Check input Format
            //YoutubeDownload_StatueLab.Text = Uri.IsWellFormedUriString(URL_txt.Text,UriKind.Relative).ToString();
            //if(SelectFolder_lab.Text != )
            Thread T1 = new Thread(SaveMP3);
            T1.Start();
            //SaveMP3(SelectFolder_lab.Text, URL_txt.Text,"1");
            
        }

        private void SelectFolder_btn_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog()){
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    SelectFolder_lab.Text = fbd.SelectedPath;
            }
        }

        //function
        
        private void SaveMP3()
        {
            var source = SelectFolder_lab.Text;
            var youtube = YouTube.Default;
            var vid = youtube.GetVideo(URL_txt.Text);
            Thread VideoDownload = new Thread(Downloading);

            string vediopath = Path.Combine(source, vid.FullName);
            VideoDownload.Start();
            File.WriteAllBytes(vediopath, vid.GetBytes());
            VideoDownload.Abort();

            //mp4 to mp3
            var inputFile = new MediaFile { Filename = vediopath };
            var outputFile = new MediaFile { Filename = Path.Combine(source, $"{SaveToMp3_txt.Text}.mp3")};
            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);

                engine.Convert(inputFile, outputFile);
            }


            YoutubeDownload_StatueLab.Text = "Done";
            URL_btn.Enabled = true;
            SelectFolder_btn.Enabled = true;
            URL_txt.Enabled = true;
            SaveToMp3_txt.Enabled = true;


        }
        private void Downloading()
        {
            
            VideoClient videoClient = new VideoClient();
            //using (var Stream = videoClient.Stream(vid))
            {
                
            }
        }
    }
}
