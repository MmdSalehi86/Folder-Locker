using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Convert_Binary
{
    internal class Load
    {
        private Color c2;
        private Color c1;
        private Font f1;
        private Font f2;

        public Font FontText { get { return f1; } }
        public Font FontBinary { get { return f2; } }
        public Color ColorText { get { return c1; } }
        public Color ColorBinary { get { return c2; } }
        private FileStream fs;
        public Load()
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                if (File.Exists("setting.bin"))
                {
                    fs = new FileStream("setting.bin", FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    f1 = (Font)bf.Deserialize(fs);
                    c1 = (Color)bf.Deserialize(fs);
                    f2 = (Font)bf.Deserialize(fs);
                    c2 = (Color)bf.Deserialize(fs);
                    fs.Close();
                }
            }
            catch
            {
                MessageBox.Show("Problem reading the \"setting.bin\" file", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                fs.Close();
                File.Delete("setting.bin");
                Application.Exit();
            }
        }
    }
}