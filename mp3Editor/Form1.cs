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
using NAudio.Wave;
using static mp3Editor.semicircle;


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
                {
                    SelectFolder_lab.Text = fbd.SelectedPath;
                }
            }
        }
        private void Selectmp3_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Selectmp3_lab.Text = openFileDialog.FileName;
                    if (Selectmp3_lab.Text.Substring(Selectmp3_lab.Text.Length - 4) == ".mp3")
                    {
                        mp3_save_txt.Text = openFileDialog.SafeFileName;
                        LoadMP3();
                    }
                }
            }
        }

        //function

        private void SaveMP3()
        {
            var source = SelectFolder_lab.Text;
            var youtube = YouTube.Default;
            var vid = youtube.GetVideo(URL_txt.Text);

            string vediopath = Path.Combine(source, vid.FullName);
            File.WriteAllBytes(vediopath, vid.GetBytes());

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
        
        private void LoadMP3()
        {
            mp3_name_lab.Text = "Name: " + mp3_save_txt.Text;
            var reader = new Mp3FileReader(Selectmp3_lab.Text); 
            Mp3Frame Frame = reader.ReadNextFrame();
            MessageBox.Show("mp3_BitRate: " + Frame.BitRate.ToString() + "\nFrameLength: " + Frame.FrameLength.ToString());

            mp3_length_lab.Text = reader.TotalTime.ToString();
            mp3_length_lab.Text = mp3_length_lab.Text.Substring(0, mp3_length_lab.Text.IndexOf("."));
        }

        
        private void VolumeBar_Scroll(object sender, ScrollEventArgs e)
        {
            Volume_lab2.Text = VolumeBar.Value.ToString()+"%";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
        }

        private void clip_interval_txt_TextChanged(object sender, EventArgs e)
        {
            trackBar1.SmallChange = int.Parse(clip_interval_txt.Text);
        }
    }
}
