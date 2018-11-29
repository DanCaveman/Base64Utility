using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf.parser;
using PdfSharp.Pdf;
using PdfSharp.Pdf.Content;
using PdfSharp.Pdf.IO;
using SautinSoft;

namespace Base64Utility
{
    public partial class Form1 : Form
    {
        private string _base64HL7String = string.Empty;
        private byte[] _binaryPdfFile = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void CreatePdfFileButton_Click(object sender, EventArgs e)
        {

            File.WriteAllBytes(@"C:\Base64\Test.pdf", _binaryPdfFile);
        }

        private void ConvertToTextIronPdfButton_Click(object sender, EventArgs e)
        {
            //var pdfDoc = new PdfDocument(new MemoryStream(_binaryPdfFile));
            //var pdfPage = new PdfPage(pdfDoc);
            //var text = ContentReader.ReadContent(pdfPage);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var Ocr = new IronOcr.AutoOcr();
            var Results = Ocr.ReadPdf(_binaryPdfFile);
            stopwatch.Stop();
            IronPdfStatsDetails.Text = $"Load Pdf Binary: {stopwatch.Elapsed.Seconds} seconds\r\n\r\n";
            stopwatch.Reset();
            stopwatch.Start();
            var text = Results.Text;
            stopwatch.Stop();
            IronPdfStatsDetails.Text += $"Convert to Text: {stopwatch.Elapsed.Seconds} seconds";

            ExtractedTextTextBox.Text = text;
            File.WriteAllText(@"C:\Base64\IronPdf.txt", text);

        }

        private void Base64Input_TextChanged(object sender, EventArgs e)
        {
            _base64HL7String = Base64Input.Text;

            var preppedString = _base64HL7String
                .Replace(@"\.br\", "\r\n");

            _binaryPdfFile = Convert.FromBase64String(preppedString);         

        }

        private void ConvertToTextPdfFocusButton_Click(object sender, EventArgs e)
        {
            var pdf = new PdfFocus();
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            pdf.OpenPdf(new MemoryStream(_binaryPdfFile));
            stopwatch.Stop();
            PdfFocusStatsDetails.Text = $"Load Pdf Binary: {stopwatch.Elapsed.Seconds} seconds\r\n\r\n";
            stopwatch.Reset();
            stopwatch.Start();
            var text = pdf.ToText();
            stopwatch.Stop();
            PdfFocusStatsDetails.Text += $"Convert to Text: {stopwatch.Elapsed.Seconds} seconds";

            ExtractedTextTextBox.Text = text;
            File.WriteAllText(@"C:\Base64\PdfFocus.txt", text);

        }

        private void ConvertToTextiTextButton_Click(object sender, EventArgs e)
        {

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var pdf = new iTextSharp.text.pdf.PdfReader(_binaryPdfFile);
            stopwatch.Stop();
            iTextDetails.Text = $"Load Pdf Binary: {stopwatch.Elapsed.Seconds} seconds\r\n\r\n";
            stopwatch.Reset();
            stopwatch.Start();
            string text = string.Empty;
            for (int i = 1; i <= pdf.NumberOfPages; i++)
            {
                text = PdfTextExtractor.GetTextFromPage(pdf, i, new LocationTextExtractionStrategy());

            }
            stopwatch.Stop();
            iTextDetails.Text += $"Convert to Text: {stopwatch.Elapsed.Seconds} seconds";

            ExtractedTextTextBox.Text = text;
            File.WriteAllText(@"C:\Base64\iText.txt", text);

        }
    }
}
