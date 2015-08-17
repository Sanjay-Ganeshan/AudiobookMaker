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
            this.btnCreateText = new System.Windows.Forms.Button();
            this.pdfFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtPdfLoc = new System.Windows.Forms.TextBox();
            this.lblPdfLoc = new System.Windows.Forms.Label();
            this.btnPDFBrowse = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreateText
            // 
            this.btnCreateText.Location = new System.Drawing.Point(257, 306);
            this.btnCreateText.Name = "btnCreateText";
            this.btnCreateText.Size = new System.Drawing.Size(141, 69);
            this.btnCreateText.TabIndex = 0;
            this.btnCreateText.Text = "Create Text Document";
            this.btnCreateText.UseVisualStyleBackColor = true;
            this.btnCreateText.Click += new System.EventHandler(this.btnCreateText_Click);
            // 
            // pdfFileDialog
            // 
            this.pdfFileDialog.FileName = "book.pdf";
            this.pdfFileDialog.Filter = "PDF Files | *.pdf";
            this.pdfFileDialog.FilterIndex = 0;
            this.pdfFileDialog.Title = "Select a pdf file";
            this.pdfFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.pdfFileDialog_FileOk);
            // 
            // txtPdfLoc
            // 
            this.txtPdfLoc.Location = new System.Drawing.Point(141, 36);
            this.txtPdfLoc.Name = "txtPdfLoc";
            this.txtPdfLoc.Size = new System.Drawing.Size(464, 22);
            this.txtPdfLoc.TabIndex = 1;
            // 
            // lblPdfLoc
            // 
            this.lblPdfLoc.AutoSize = true;
            this.lblPdfLoc.Location = new System.Drawing.Point(12, 36);
            this.lblPdfLoc.Name = "lblPdfLoc";
            this.lblPdfLoc.Size = new System.Drawing.Size(123, 17);
            this.lblPdfLoc.TabIndex = 2;
            this.lblPdfLoc.Text = "PDF File Location:";
            // 
            // btnPDFBrowse
            // 
            this.btnPDFBrowse.Location = new System.Drawing.Point(612, 34);
            this.btnPDFBrowse.Name = "btnPDFBrowse";
            this.btnPDFBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnPDFBrowse.TabIndex = 3;
            this.btnPDFBrowse.Text = "Browse...";
            this.btnPDFBrowse.UseVisualStyleBackColor = true;
            this.btnPDFBrowse.Click += new System.EventHandler(this.btnPDFBrowse_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(612, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Browse...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output File Location:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(448, 22);
            this.textBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 387);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnPDFBrowse);
            this.Controls.Add(this.lblPdfLoc);
            this.Controls.Add(this.txtPdfLoc);
            this.Controls.Add(this.btnCreateText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateText;
        private System.Windows.Forms.OpenFileDialog pdfFileDialog;
        private System.Windows.Forms.TextBox txtPdfLoc;
        private System.Windows.Forms.Label lblPdfLoc;
        private System.Windows.Forms.Button btnPDFBrowse;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

