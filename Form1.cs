using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base64Utility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var preppedString = Base64Input.Text
                .Replace(@"\.br\", string.Empty);

            switch (preppedString.Length % 4)
            { // Pad with trailing '='s
                case 0: break; // No pad chars in this case
                case 2: preppedString += "=="; break; // Two pad chars
                case 3: preppedString += "="; break;  // One pad char
                default: throw new FormatException("invalid format");
            }

            byte[] convertedBase64Data = Convert.FromBase64String(preppedString);

            File.WriteAllBytes(@"C:\Base64\Test.pdf", convertedBase64Data);
        }

    }
}
