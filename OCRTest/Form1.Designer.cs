namespace OCRTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCreateText = new System.Windows.Forms.Button();
            this.inputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtFileLoc = new System.Windows.Forms.TextBox();
            this.lblFileLoc = new System.Windows.Forms.Label();
            this.btnPDFBrowse = new System.Windows.Forms.Button();
            this.btnSaveWav = new System.Windows.Forms.Button();
            this.lblOutputFileLoc = new System.Windows.Forms.Label();
            this.txtOutputFileLoc = new System.Windows.Forms.TextBox();
            this.btnCreateAudioBook = new System.Windows.Forms.Button();
            this.waveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.trackSpeed = new System.Windows.Forms.TrackBar();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.gbSpeedControl = new System.Windows.Forms.GroupBox();
            this.rbAtSpeed = new System.Windows.Forms.RadioButton();
            this.rbNoSpeed = new System.Windows.Forms.RadioButton();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).BeginInit();
            this.gbSpeedControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateText
            // 
            this.btnCreateText.Enabled = false;
            this.btnCreateText.Location = new System.Drawing.Point(76, 306);
            this.btnCreateText.Name = "btnCreateText";
            this.btnCreateText.Size = new System.Drawing.Size(141, 69);
            this.btnCreateText.TabIndex = 5;
            this.btnCreateText.Text = "Create Text Document";
            this.btnCreateText.UseVisualStyleBackColor = true;
            this.btnCreateText.Click += new System.EventHandler(this.btnCreateText_Click);
            // 
            // inputFileDialog
            // 
            this.inputFileDialog.FileName = "book.pdf";
            this.inputFileDialog.Filter = resources.GetString("inputFileDialog.Filter");
            this.inputFileDialog.FilterIndex = 0;
            this.inputFileDialog.Title = "Select a pdf file";
            this.inputFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.pdfFileDialog_FileOk);
            // 
            // txtFileLoc
            // 
            this.txtFileLoc.Location = new System.Drawing.Point(149, 78);
            this.txtFileLoc.Name = "txtFileLoc";
            this.txtFileLoc.Size = new System.Drawing.Size(456, 22);
            this.txtFileLoc.TabIndex = 1;
            this.txtFileLoc.TextChanged += new System.EventHandler(this.txtFileLoc_TextChanged);
            // 
            // lblFileLoc
            // 
            this.lblFileLoc.AutoSize = true;
            this.lblFileLoc.Location = new System.Drawing.Point(12, 82);
            this.lblFileLoc.Name = "lblFileLoc";
            this.lblFileLoc.Size = new System.Drawing.Size(131, 17);
            this.lblFileLoc.TabIndex = 2;
            this.lblFileLoc.Text = "Input File Location: ";
            // 
            // btnPDFBrowse
            // 
            this.btnPDFBrowse.Location = new System.Drawing.Point(612, 76);
            this.btnPDFBrowse.Name = "btnPDFBrowse";
            this.btnPDFBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnPDFBrowse.TabIndex = 2;
            this.btnPDFBrowse.Text = "Browse...";
            this.btnPDFBrowse.UseVisualStyleBackColor = true;
            this.btnPDFBrowse.Click += new System.EventHandler(this.btnPDFBrowse_Click);
            // 
            // btnSaveWav
            // 
            this.btnSaveWav.Enabled = false;
            this.btnSaveWav.Location = new System.Drawing.Point(612, 121);
            this.btnSaveWav.Name = "btnSaveWav";
            this.btnSaveWav.Size = new System.Drawing.Size(75, 23);
            this.btnSaveWav.TabIndex = 4;
            this.btnSaveWav.Text = "Save...";
            this.btnSaveWav.UseVisualStyleBackColor = true;
            this.btnSaveWav.Click += new System.EventHandler(this.btnSaveWav_Click);
            // 
            // lblOutputFileLoc
            // 
            this.lblOutputFileLoc.AutoSize = true;
            this.lblOutputFileLoc.Enabled = false;
            this.lblOutputFileLoc.Location = new System.Drawing.Point(4, 121);
            this.lblOutputFileLoc.Name = "lblOutputFileLoc";
            this.lblOutputFileLoc.Size = new System.Drawing.Size(141, 17);
            this.lblOutputFileLoc.TabIndex = 5;
            this.lblOutputFileLoc.Text = "Output wav Location:";
            // 
            // txtOutputFileLoc
            // 
            this.txtOutputFileLoc.Enabled = false;
            this.txtOutputFileLoc.Location = new System.Drawing.Point(149, 120);
            this.txtOutputFileLoc.Name = "txtOutputFileLoc";
            this.txtOutputFileLoc.Size = new System.Drawing.Size(456, 22);
            this.txtOutputFileLoc.TabIndex = 3;
            this.txtOutputFileLoc.TextChanged += new System.EventHandler(this.txtOutputFileLoc_TextChanged);
            // 
            // btnCreateAudioBook
            // 
            this.btnCreateAudioBook.Enabled = false;
            this.btnCreateAudioBook.Location = new System.Drawing.Point(438, 306);
            this.btnCreateAudioBook.Name = "btnCreateAudioBook";
            this.btnCreateAudioBook.Size = new System.Drawing.Size(140, 69);
            this.btnCreateAudioBook.TabIndex = 9;
            this.btnCreateAudioBook.Text = "Create Audio Book";
            this.btnCreateAudioBook.UseVisualStyleBackColor = true;
            this.btnCreateAudioBook.Click += new System.EventHandler(this.btnCreateAudioBook_Click);
            // 
            // waveFileDialog
            // 
            this.waveFileDialog.DefaultExt = "wav";
            this.waveFileDialog.FileName = "audiobook.wav";
            this.waveFileDialog.Filter = "Wave Sound File|*.wav|MP3 File|*.mp3";
            this.waveFileDialog.Title = ".wav Save Location";
            this.waveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.waveFileDialog_FileOk);
            // 
            // trackSpeed
            // 
            this.trackSpeed.Enabled = false;
            this.trackSpeed.Location = new System.Drawing.Point(113, 57);
            this.trackSpeed.Maximum = 4;
            this.trackSpeed.Name = "trackSpeed";
            this.trackSpeed.Size = new System.Drawing.Size(104, 56);
            this.trackSpeed.TabIndex = 8;
            this.trackSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackSpeed.Value = 2;
            this.trackSpeed.ValueChanged += new System.EventHandler(this.trackSpeed_ValueChanged);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Enabled = false;
            this.lblSpeed.Location = new System.Drawing.Point(223, 65);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(53, 17);
            this.lblSpeed.TabIndex = 10;
            this.lblSpeed.Text = "Normal";
            // 
            // gbSpeedControl
            // 
            this.gbSpeedControl.Controls.Add(this.rbAtSpeed);
            this.gbSpeedControl.Controls.Add(this.rbNoSpeed);
            this.gbSpeedControl.Controls.Add(this.lblSpeed);
            this.gbSpeedControl.Controls.Add(this.trackSpeed);
            this.gbSpeedControl.Enabled = false;
            this.gbSpeedControl.Location = new System.Drawing.Point(359, 175);
            this.gbSpeedControl.Name = "gbSpeedControl";
            this.gbSpeedControl.Size = new System.Drawing.Size(302, 113);
            this.gbSpeedControl.TabIndex = 11;
            this.gbSpeedControl.TabStop = false;
            this.gbSpeedControl.Text = "Speed Control";
            // 
            // rbAtSpeed
            // 
            this.rbAtSpeed.AutoSize = true;
            this.rbAtSpeed.Location = new System.Drawing.Point(16, 63);
            this.rbAtSpeed.Name = "rbAtSpeed";
            this.rbAtSpeed.Size = new System.Drawing.Size(91, 21);
            this.rbAtSpeed.TabIndex = 7;
            this.rbAtSpeed.Text = "At Speed:";
            this.rbAtSpeed.UseVisualStyleBackColor = true;
            this.rbAtSpeed.CheckedChanged += new System.EventHandler(this.rbAtSpeed_CheckedChanged);
            // 
            // rbNoSpeed
            // 
            this.rbNoSpeed.AutoSize = true;
            this.rbNoSpeed.Checked = true;
            this.rbNoSpeed.Location = new System.Drawing.Point(16, 36);
            this.rbNoSpeed.Name = "rbNoSpeed";
            this.rbNoSpeed.Size = new System.Drawing.Size(103, 21);
            this.rbNoSpeed.TabIndex = 6;
            this.rbNoSpeed.TabStop = true;
            this.rbNoSpeed.Text = "Unspecified";
            this.rbNoSpeed.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(76, 405);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(502, 77);
            this.txtLog.TabIndex = 12;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(76, 498);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(502, 23);
            this.progressBar.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 533);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnCreateAudioBook);
            this.Controls.Add(this.btnSaveWav);
            this.Controls.Add(this.lblOutputFileLoc);
            this.Controls.Add(this.txtOutputFileLoc);
            this.Controls.Add(this.btnPDFBrowse);
            this.Controls.Add(this.lblFileLoc);
            this.Controls.Add(this.txtFileLoc);
            this.Controls.Add(this.btnCreateText);
            this.Controls.Add(this.gbSpeedControl);
            this.Name = "Form1";
            this.Text = "Audio Book Maker";
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).EndInit();
            this.gbSpeedControl.ResumeLayout(false);
            this.gbSpeedControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateText;
        private System.Windows.Forms.OpenFileDialog inputFileDialog;
        private System.Windows.Forms.TextBox txtFileLoc;
        private System.Windows.Forms.Label lblFileLoc;
        private System.Windows.Forms.Button btnPDFBrowse;
        private System.Windows.Forms.Button btnSaveWav;
        private System.Windows.Forms.Label lblOutputFileLoc;
        private System.Windows.Forms.TextBox txtOutputFileLoc;
        private System.Windows.Forms.Button btnCreateAudioBook;
        private System.Windows.Forms.SaveFileDialog waveFileDialog;
        private System.Windows.Forms.TrackBar trackSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.GroupBox gbSpeedControl;
        private System.Windows.Forms.RadioButton rbAtSpeed;
        private System.Windows.Forms.RadioButton rbNoSpeed;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

