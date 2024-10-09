using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Convert_Binary
{
    internal class Upload
    {
        private Form1 form1 { get; set; }
        public Upload(Form1 form1)
        {
            this.form1 = form1;
        }

        public void UploadData()
        {
            FileStream fs = new FileStream("setting.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, form1.Text0.Font);
            bf.Serialize(fs, form1.Text0.ForeColor);
            bf.Serialize(fs, form1.TBinary.Font);
            bf.Serialize(fs, form1.TBinary.ForeColor);
            fs.Close();
        }
    }
}
