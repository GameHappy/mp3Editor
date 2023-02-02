
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
            this.URL_btn.Location = new System.Drawing.Point(239, 64);
            this.URL_btn.Name = "URL_btn";
            this.URL_btn.Size = new System.Drawing.Size(75, 23);
            this.URL_btn.TabIndex = 1;
            this.URL_btn.Text = "Download";
            this.URL_btn.UseVisualStyleBackColor = true;
            this.URL_btn.Click += new System.EventHandler(this.URL_btn_Click);
            // 
            // URL_txt
            // 
            this.URL_txt.Location = new System.Drawing.Point(239, 94);
            this.URL_txt.Name = "URL_txt";
            this.URL_txt.Size = new System.Drawing.Size(144, 20);
            this.URL_txt.TabIndex = 2;
            this.URL_txt.Text = "https://www.youtube.com/watch?v=O7L0zAGtV4g";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SelectFolder_btn
            // 
            this.SelectFolder_btn.Location = new System.Drawing.Point(239, 11);
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
            this.SelectFolder_lab.Location = new System.Drawing.Point(239, 41);
            this.SelectFolder_lab.Name = "SelectFolder_lab";
            this.SelectFolder_lab.Size = new System.Drawing.Size(83, 13);
            this.SelectFolder_lab.TabIndex = 4;
            this.SelectFolder_lab.Text = "C:\\Fan_mp3test";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 455);
            this.Controls.Add(this.SelectFolder_lab);
            this.Controls.Add(this.SelectFolder_btn);
            this.Controls.Add(this.URL_txt);
            this.Controls.Add(this.URL_btn);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button URL_btn;
        private System.Windows.Forms.TextBox URL_txt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button SelectFolder_btn;
        private System.Windows.Forms.Label SelectFolder_lab;
    }
}

