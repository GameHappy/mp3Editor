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

        private void mp3_save_btn_Click(object sender, EventArgs e)
        {
            if (mp3_save_path_lab.Text != "" && mp3_save_txt.Text != "") Mp3Clip();
            else MessageBox.Show("please setting path and name.");
        }

        WaveOut waveOut = new WaveOut();
        private void VolumeBar_Scroll(object sender, ScrollEventArgs e)
        {
            //Volume_lab2.Text = VolumeBar.Value.ToString() + "%";
            
            float V = (float)VolumeBar.Value / 100f;
            waveOut.Volume = V;
            Volume_lab2.Text = ((int)(waveOut.Volume * 100)).ToString() + "%";

        }

        private void mp3_play_btn_Click(object sender, EventArgs e)
        {
            waveOut.Play();
            
        }

        private void mp3_stop_btn_Click(object sender, EventArgs e)
        {
            waveOut.Stop();
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
        }

        private void clip_interval_txt_TextChanged(object sender, EventArgs e)
        {
            trackBar1.SmallChange = int.Parse(clip_interval_txt.Text);
        }

        private void mp3_save_path_btn_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    mp3_save_path_lab.Text = fbd.SelectedPath;
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
        Mp3FileReader reader;
        private void LoadMP3()
        {
            mp3_name_lab.Text = "Name: " + mp3_save_txt.Text;
            reader = new Mp3FileReader(Selectmp3_lab.Text); 
            mp3_length_lab.Text = reader.TotalTime.ToString();
            mp3_length_lab.Text = mp3_length_lab.Text.Substring(0, mp3_length_lab.Text.IndexOf("."));

            waveOut.DeviceNumber = 0;
            waveOut.Init(reader);
            VolumeBar.Value = (int)waveOut.Volume*100;
            Volume_lab2.Text = VolumeBar.Value.ToString();
            
        }

        private void Mp3Clip()
        {
            TimeSpan begin = TimeSpan.FromMinutes(1);
            TimeSpan end = TimeSpan.FromMinutes(1);
            string outputPath = Path.Combine(mp3_save_path_lab.Text, $"{mp3_save_txt.Text}.mp3");
            if (begin > end)
                throw new ArgumentOutOfRangeException("end", "end should be greater than begin");

            using (var writer = File.Create(outputPath))
            {
                Mp3Frame frame;
                
                while ((frame = reader.ReadNextFrame()) != null)
                    if (reader.CurrentTime >= begin)
                    {
                        if (reader.CurrentTime <= end)
                            writer.Write(frame.RawData, 0, frame.RawData.Length);
                        else break;
                    }
            }
        }

    }
}
