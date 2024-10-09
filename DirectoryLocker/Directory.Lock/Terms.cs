using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace Folder.Lock
{
    public partial class Terms : Form
    {
        public Terms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Terms_Load(object sender, EventArgs e)
        {
            if (Directory.Exists("font"))
            {
                PrivateFontCollection pFont = new PrivateFontCollection();
                pFont.AddFontFile("font\\IRNazaninBold.ttf");
                label1.Font = new Font(pFont.Families[0], 14, FontStyle.Bold);
                button1.Font = new Font(pFont.Families[0], 14, FontStyle.Bold);
            }
        }
    }
}