
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
            this.button1 = new System.Windows.Forms.Button();
            this.URL_btn = new System.Windows.Forms.Button();
            this.URL_txt = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SelectFolder_btn = new System.Windows.Forms.Button();
            this.SelectFolder_lab = new System.Windows.Forms.Label();
            this.SaveToMp3_txt = new System.Windows.Forms.TextBox();
            this.YoutubeDownload_StatueLab = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load mp3";
            this.button1.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button URL_btn;
        private System.Windows.Forms.TextBox URL_txt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button SelectFolder_btn;
        private System.Windows.Forms.Label SelectFolder_lab;
        private System.Windows.Forms.TextBox SaveToMp3_txt;
        private System.Windows.Forms.Label YoutubeDownload_StatueLab;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

