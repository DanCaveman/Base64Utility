namespace Base64Utility
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
            this.Base64Input = new System.Windows.Forms.TextBox();
            this.CreatePdfFileButton = new System.Windows.Forms.Button();
            this.ConvertToTextIronPdfButton = new System.Windows.Forms.Button();
            this.ExtractedTextTextBox = new System.Windows.Forms.TextBox();
            this.ConvertToTextPdfFocusButton = new System.Windows.Forms.Button();
            this.IronPdfStatsLabel = new System.Windows.Forms.Label();
            this.PdfFocusStatsLabel = new System.Windows.Forms.Label();
            this.IronPdfStatsDetails = new System.Windows.Forms.TextBox();
            this.PdfFocusStatsDetails = new System.Windows.Forms.TextBox();
            this.iTextDetails = new System.Windows.Forms.TextBox();
            this.iTextResultLabel = new System.Windows.Forms.Label();
            this.ConvertToTextiTextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Base64Input
            // 
            this.Base64Input.AcceptsReturn = true;
            this.Base64Input.AcceptsTab = true;
            this.Base64Input.Location = new System.Drawing.Point(9, 26);
            this.Base64Input.Margin = new System.Windows.Forms.Padding(2);
            this.Base64Input.MaxLength = 1000000;
            this.Base64Input.Multiline = true;
            this.Base64Input.Name = "Base64Input";
            this.Base64Input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Base64Input.Size = new System.Drawing.Size(583, 227);
            this.Base64Input.TabIndex = 0;
            this.Base64Input.TextChanged += new System.EventHandler(this.Base64Input_TextChanged);
            // 
            // CreatePdfFileButton
            // 
            this.CreatePdfFileButton.Location = new System.Drawing.Point(9, 267);
            this.CreatePdfFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.CreatePdfFileButton.Name = "CreatePdfFileButton";
            this.CreatePdfFileButton.Size = new System.Drawing.Size(206, 46);
            this.CreatePdfFileButton.TabIndex = 1;
            this.CreatePdfFileButton.Text = "ConvertBase64ToFile";
            this.CreatePdfFileButton.UseVisualStyleBackColor = true;
            this.CreatePdfFileButton.Click += new System.EventHandler(this.CreatePdfFileButton_Click);
            // 
            // ConvertToTextIronPdfButton
            // 
            this.ConvertToTextIronPdfButton.Location = new System.Drawing.Point(234, 267);
            this.ConvertToTextIronPdfButton.Name = "ConvertToTextIronPdfButton";
            this.ConvertToTextIronPdfButton.Size = new System.Drawing.Size(170, 45);
            this.ConvertToTextIronPdfButton.TabIndex = 2;
            this.ConvertToTextIronPdfButton.Text = "Convert To Text with IronPDF";
            this.ConvertToTextIronPdfButton.UseVisualStyleBackColor = true;
            this.ConvertToTextIronPdfButton.Click += new System.EventHandler(this.ConvertToTextIronPdfButton_Click);
            // 
            // ExtractedTextTextBox
            // 
            this.ExtractedTextTextBox.AcceptsReturn = true;
            this.ExtractedTextTextBox.AcceptsTab = true;
            this.ExtractedTextTextBox.Location = new System.Drawing.Point(9, 368);
            this.ExtractedTextTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ExtractedTextTextBox.MaxLength = 1000000;
            this.ExtractedTextTextBox.Multiline = true;
            this.ExtractedTextTextBox.Name = "ExtractedTextTextBox";
            this.ExtractedTextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ExtractedTextTextBox.Size = new System.Drawing.Size(583, 269);
            this.ExtractedTextTextBox.TabIndex = 3;
            // 
            // ConvertToTextPdfFocusButton
            // 
            this.ConvertToTextPdfFocusButton.Location = new System.Drawing.Point(410, 268);
            this.ConvertToTextPdfFocusButton.Name = "ConvertToTextPdfFocusButton";
            this.ConvertToTextPdfFocusButton.Size = new System.Drawing.Size(170, 45);
            this.ConvertToTextPdfFocusButton.TabIndex = 4;
            this.ConvertToTextPdfFocusButton.Text = "Convert To Text with Pdf Focus";
            this.ConvertToTextPdfFocusButton.UseVisualStyleBackColor = true;
            this.ConvertToTextPdfFocusButton.Click += new System.EventHandler(this.ConvertToTextPdfFocusButton_Click);
            // 
            // IronPdfStatsLabel
            // 
            this.IronPdfStatsLabel.AutoSize = true;
            this.IronPdfStatsLabel.Location = new System.Drawing.Point(630, 26);
            this.IronPdfStatsLabel.Name = "IronPdfStatsLabel";
            this.IronPdfStatsLabel.Size = new System.Drawing.Size(71, 13);
            this.IronPdfStatsLabel.TabIndex = 5;
            this.IronPdfStatsLabel.Text = "Iron Pdf Stats";
            // 
            // PdfFocusStatsLabel
            // 
            this.PdfFocusStatsLabel.AutoSize = true;
            this.PdfFocusStatsLabel.Location = new System.Drawing.Point(619, 165);
            this.PdfFocusStatsLabel.Name = "PdfFocusStatsLabel";
            this.PdfFocusStatsLabel.Size = new System.Drawing.Size(82, 13);
            this.PdfFocusStatsLabel.TabIndex = 6;
            this.PdfFocusStatsLabel.Text = "Pdf Focus Stats";
            // 
            // IronPdfStatsDetails
            // 
            this.IronPdfStatsDetails.Location = new System.Drawing.Point(622, 52);
            this.IronPdfStatsDetails.MaxLength = 1000000;
            this.IronPdfStatsDetails.Multiline = true;
            this.IronPdfStatsDetails.Name = "IronPdfStatsDetails";
            this.IronPdfStatsDetails.ReadOnly = true;
            this.IronPdfStatsDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.IronPdfStatsDetails.Size = new System.Drawing.Size(340, 82);
            this.IronPdfStatsDetails.TabIndex = 7;
            // 
            // PdfFocusStatsDetails
            // 
            this.PdfFocusStatsDetails.Location = new System.Drawing.Point(622, 183);
            this.PdfFocusStatsDetails.MaxLength = 1000000;
            this.PdfFocusStatsDetails.Multiline = true;
            this.PdfFocusStatsDetails.Name = "PdfFocusStatsDetails";
            this.PdfFocusStatsDetails.ReadOnly = true;
            this.PdfFocusStatsDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PdfFocusStatsDetails.Size = new System.Drawing.Size(340, 88);
            this.PdfFocusStatsDetails.TabIndex = 8;
            // 
            // iTextDetails
            // 
            this.iTextDetails.Location = new System.Drawing.Point(622, 313);
            this.iTextDetails.MaxLength = 1000000;
            this.iTextDetails.Multiline = true;
            this.iTextDetails.Name = "iTextDetails";
            this.iTextDetails.ReadOnly = true;
            this.iTextDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.iTextDetails.Size = new System.Drawing.Size(340, 88);
            this.iTextDetails.TabIndex = 10;
            // 
            // iTextResultLabel
            // 
            this.iTextResultLabel.AutoSize = true;
            this.iTextResultLabel.Location = new System.Drawing.Point(619, 295);
            this.iTextResultLabel.Name = "iTextResultLabel";
            this.iTextResultLabel.Size = new System.Drawing.Size(57, 13);
            this.iTextResultLabel.TabIndex = 9;
            this.iTextResultLabel.Text = "iText Stats";
            // 
            // ConvertToTextiTextButton
            // 
            this.ConvertToTextiTextButton.Location = new System.Drawing.Point(234, 318);
            this.ConvertToTextiTextButton.Name = "ConvertToTextiTextButton";
            this.ConvertToTextiTextButton.Size = new System.Drawing.Size(170, 45);
            this.ConvertToTextiTextButton.TabIndex = 11;
            this.ConvertToTextiTextButton.Text = "Convert To Text with iText";
            this.ConvertToTextiTextButton.UseVisualStyleBackColor = true;
            this.ConvertToTextiTextButton.Click += new System.EventHandler(this.ConvertToTextiTextButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 648);
            this.Controls.Add(this.ConvertToTextiTextButton);
            this.Controls.Add(this.iTextDetails);
            this.Controls.Add(this.iTextResultLabel);
            this.Controls.Add(this.PdfFocusStatsDetails);
            this.Controls.Add(this.IronPdfStatsDetails);
            this.Controls.Add(this.PdfFocusStatsLabel);
            this.Controls.Add(this.IronPdfStatsLabel);
            this.Controls.Add(this.ConvertToTextPdfFocusButton);
            this.Controls.Add(this.ExtractedTextTextBox);
            this.Controls.Add(this.ConvertToTextIronPdfButton);
            this.Controls.Add(this.CreatePdfFileButton);
            this.Controls.Add(this.Base64Input);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Base64Input;
        private System.Windows.Forms.Button CreatePdfFileButton;
        private System.Windows.Forms.Button ConvertToTextIronPdfButton;
        private System.Windows.Forms.TextBox ExtractedTextTextBox;
        private System.Windows.Forms.Button ConvertToTextPdfFocusButton;
        private System.Windows.Forms.Label IronPdfStatsLabel;
        private System.Windows.Forms.Label PdfFocusStatsLabel;
        private System.Windows.Forms.TextBox IronPdfStatsDetails;
        private System.Windows.Forms.TextBox PdfFocusStatsDetails;
        private System.Windows.Forms.TextBox iTextDetails;
        private System.Windows.Forms.Label iTextResultLabel;
        private System.Windows.Forms.Button ConvertToTextiTextButton;
    }
}

