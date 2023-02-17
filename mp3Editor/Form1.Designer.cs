
namespace mp3Editor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Selectmp3_btn = new System.Windows.Forms.Button();
            this.URL_btn = new System.Windows.Forms.Button();
            this.URL_txt = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SelectFolder_btn = new System.Windows.Forms.Button();
            this.SelectFolder_lab = new System.Windows.Forms.Label();
            this.SaveToMp3_txt = new System.Windows.Forms.TextBox();
            this.YoutubeDownload_StatueLab = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Selectmp3_lab = new System.Windows.Forms.Label();
            this.VolumeBar = new System.Windows.Forms.HScrollBar();
            this.Volume_lab1 = new System.Windows.Forms.Label();
            this.Volume_lab2 = new System.Windows.Forms.Label();
            this.line_lab = new System.Windows.Forms.Label();
            this.mp3_name_lab = new System.Windows.Forms.Label();
            this.mp3_length_lab = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.mp3_play_btn = new System.Windows.Forms.Button();
            this.mp3_stop_btn = new System.Windows.Forms.Button();
            this.mp3_save_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Selectmp3_btn
            // 
            this.Selectmp3_btn.Location = new System.Drawing.Point(12, 12);
            this.Selectmp3_btn.Name = "Selectmp3_btn";
            this.Selectmp3_btn.Size = new System.Drawing.Size(75, 23);
            this.Selectmp3_btn.TabIndex = 0;
            this.Selectmp3_btn.Text = "Load mp3";
            this.Selectmp3_btn.UseVisualStyleBackColor = true;
            this.Selectmp3_btn.Click += new System.EventHandler(this.Selectmp3_btn_Click);
            // 
            // URL_btn
            // 
            this.URL_btn.Location = new System.Drawing.Point(6, 72);
            this.URL_btn.Name = "URL_btn";
            this.URL_btn.Size = new System.Drawing.Size(75, 23);
            this.URL_btn.TabIndex = 1;
            this.URL_btn.Text = "Download";
            this.URL_btn.UseVisualStyleBackColor = true;
            this.URL_btn.Click += new System.EventHandler(this.URL_btn_Click);
            // 
            // URL_txt
            // 
            this.URL_txt.Location = new System.Drawing.Point(6, 101);
            this.URL_txt.Name = "URL_txt";
            this.URL_txt.Size = new System.Drawing.Size(144, 20);
            this.URL_txt.TabIndex = 2;
            this.URL_txt.Text = "https://www.youtube.com/watch?v=aYsgsSo1aow";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SelectFolder_btn
            // 
            this.SelectFolder_btn.Location = new System.Drawing.Point(6, 19);
            this.SelectFolder_btn.Name = "SelectFolder_btn";
            this.SelectFolder_btn.Size = new System.Drawing.Size(100, 23);
            this.SelectFolder_btn.TabIndex = 3;
            this.SelectFolder_btn.Text = "Select Folder";
            this.SelectFolder_btn.UseVisualStyleBackColor = true;
            this.SelectFolder_btn.Click += new System.EventHandler(this.SelectFolder_btn_Click);
            // 
            // SelectFolder_lab
            // 
            this.SelectFolder_lab.AutoSize = true;
            this.SelectFolder_lab.Location = new System.Drawing.Point(6, 49);
            this.SelectFolder_lab.Name = "SelectFolder_lab";
            this.SelectFolder_lab.Size = new System.Drawing.Size(83, 13);
            this.SelectFolder_lab.TabIndex = 4;
            this.SelectFolder_lab.Text = "C:\\Fan_mp3test";
            // 
            // SaveToMp3_txt
            // 
            this.SaveToMp3_txt.Location = new System.Drawing.Point(6, 128);
            this.SaveToMp3_txt.Name = "SaveToMp3_txt";
            this.SaveToMp3_txt.Size = new System.Drawing.Size(100, 20);
            this.SaveToMp3_txt.TabIndex = 5;
            // 
            // YoutubeDownload_StatueLab
            // 
            this.YoutubeDownload_StatueLab.AutoSize = true;
            this.YoutubeDownload_StatueLab.Location = new System.Drawing.Point(3, 160);
            this.YoutubeDownload_StatueLab.Name = "YoutubeDownload_StatueLab";
            this.YoutubeDownload_StatueLab.Size = new System.Drawing.Size(24, 13);
            this.YoutubeDownload_StatueLab.TabIndex = 6;
            this.YoutubeDownload_StatueLab.Text = "Idle";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectFolder_btn);
            this.groupBox1.Controls.Add(this.YoutubeDownload_StatueLab);
            this.groupBox1.Controls.Add(this.URL_btn);
            this.groupBox1.Controls.Add(this.SaveToMp3_txt);
            this.groupBox1.Controls.Add(this.URL_txt);
            this.groupBox1.Controls.Add(this.SelectFolder_lab);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Location = new System.Drawing.Point(221, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 193);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // Selectmp3_lab
            // 
            this.Selectmp3_lab.AutoSize = true;
            this.Selectmp3_lab.Location = new System.Drawing.Point(9, 41);
            this.Selectmp3_lab.Name = "Selectmp3_lab";
            this.Selectmp3_lab.Size = new System.Drawing.Size(83, 13);
            this.Selectmp3_lab.TabIndex = 7;
            this.Selectmp3_lab.Text = "C:\\Fan_mp3test";
            // 
            // VolumeBar
            // 
            this.VolumeBar.Location = new System.Drawing.Point(21, 317);
            this.VolumeBar.Maximum = 109;
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Size = new System.Drawing.Size(125, 17);
            this.VolumeBar.SmallChange = 5;
            this.VolumeBar.TabIndex = 8;
            this.VolumeBar.Value = 100;
            this.VolumeBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VolumeBar_Scroll);
            // 
            // Volume_lab1
            // 
            this.Volume_lab1.AutoSize = true;
            this.Volume_lab1.Location = new System.Drawing.Point(21, 301);
            this.Volume_lab1.Name = "Volume_lab1";
            this.Volume_lab1.Size = new System.Drawing.Size(45, 13);
            this.Volume_lab1.TabIndex = 9;
            this.Volume_lab1.Text = "Volume:";
            // 
            // Volume_lab2
            // 
            this.Volume_lab2.AutoSize = true;
            this.Volume_lab2.Location = new System.Drawing.Point(72, 301);
            this.Volume_lab2.Name = "Volume_lab2";
            this.Volume_lab2.Size = new System.Drawing.Size(33, 13);
            this.Volume_lab2.TabIndex = 10;
            this.Volume_lab2.Text = "100%";
            // 
            // line_lab
            // 
            this.line_lab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line_lab.Location = new System.Drawing.Point(-3, 224);
            this.line_lab.Name = "line_lab";
            this.line_lab.Size = new System.Drawing.Size(521, 2);
            this.line_lab.TabIndex = 11;
            // 
            // mp3_name_lab
            // 
            this.mp3_name_lab.AutoSize = true;
            this.mp3_name_lab.Location = new System.Drawing.Point(21, 230);
            this.mp3_name_lab.Name = "mp3_name_lab";
            this.mp3_name_lab.Size = new System.Drawing.Size(38, 13);
            this.mp3_name_lab.TabIndex = 12;
            this.mp3_name_lab.Text = "Name:";
            // 
            // mp3_length_lab
            // 
            this.mp3_length_lab.AutoSize = true;
            this.mp3_length_lab.Location = new System.Drawing.Point(21, 256);
            this.mp3_length_lab.Name = "mp3_length_lab";
            this.mp3_length_lab.Size = new System.Drawing.Size(43, 13);
            this.mp3_length_lab.TabIndex = 13;
            this.mp3_length_lab.Text = "Length:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(24, 364);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(188, 45);
            this.trackBar1.TabIndex = 14;
            // 
            // mp3_play_btn
            // 
            this.mp3_play_btn.Location = new System.Drawing.Point(24, 416);
            this.mp3_play_btn.Name = "mp3_play_btn";
            this.mp3_play_btn.Size = new System.Drawing.Size(42, 23);
            this.mp3_play_btn.TabIndex = 15;
            this.mp3_play_btn.Text = "Play";
            this.mp3_play_btn.UseVisualStyleBackColor = true;
            // 
            // mp3_stop_btn
            // 
            this.mp3_stop_btn.Location = new System.Drawing.Point(72, 415);
            this.mp3_stop_btn.Name = "mp3_stop_btn";
            this.mp3_stop_btn.Size = new System.Drawing.Size(42, 23);
            this.mp3_stop_btn.TabIndex = 16;
            this.mp3_stop_btn.Text = "Stop";
            this.mp3_stop_btn.UseVisualStyleBackColor = true;
            // 
            // mp3_save_btn
            // 
            this.mp3_save_btn.Location = new System.Drawing.Point(221, 416);
            this.mp3_save_btn.Name = "mp3_save_btn";
            this.mp3_save_btn.Size = new System.Drawing.Size(42, 23);
            this.mp3_save_btn.TabIndex = 17;
            this.mp3_save_btn.Text = "Save";
            this.mp3_save_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 455);
            this.Controls.Add(this.mp3_save_btn);
            this.Controls.Add(this.mp3_stop_btn);
            this.Controls.Add(this.mp3_play_btn);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.mp3_length_lab);
            this.Controls.Add(this.mp3_name_lab);
            this.Controls.Add(this.line_lab);
            this.Controls.Add(this.Volume_lab2);
            this.Controls.Add(this.Volume_lab1);
            this.Controls.Add(this.VolumeBar);
            this.Controls.Add(this.Selectmp3_lab);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Selectmp3_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Selectmp3_btn;
        private System.Windows.Forms.Button URL_btn;
        private System.Windows.Forms.TextBox URL_txt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button SelectFolder_btn;
        private System.Windows.Forms.Label SelectFolder_lab;
        private System.Windows.Forms.TextBox SaveToMp3_txt;
        private System.Windows.Forms.Label YoutubeDownload_StatueLab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Selectmp3_lab;
        private System.Windows.Forms.HScrollBar VolumeBar;
        private System.Windows.Forms.Label Volume_lab1;
        private System.Windows.Forms.Label Volume_lab2;
        private System.Windows.Forms.Label line_lab;
        private System.Windows.Forms.Label mp3_name_lab;
        private System.Windows.Forms.Label mp3_length_lab;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button mp3_play_btn;
        private System.Windows.Forms.Button mp3_stop_btn;
        private System.Windows.Forms.Button mp3_save_btn;
    }
}

