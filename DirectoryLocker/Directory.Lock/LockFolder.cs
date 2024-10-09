using System;
using System.Windows.Forms;
using Folder.Lock.Properties;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace Folder.Lock
{
    public partial class LockFolder : Form
    {
        readonly string Path_Data = "C:\\Program Files (x86)\\folderlocker\\";
        ErrorProvider error = new ErrorProvider();
        ToolTip tip = new ToolTip();
        public string FullName;
        public long Password;
        public bool Successful
        {
            get; private set;
        }

        public LockFolder(string fullaname)
        {
            FullName = fullaname;
            InitializeComponent();
            tip.SetToolTip(pic1, "Show Password");
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            if (tpassword.UseSystemPasswordChar)
            {
                tip.SetToolTip(pic1, "Hide Password");
                tpassword.UseSystemPasswordChar = false;
                pic1.Image = Resources.hide;
            }
            else
            {
                tip.SetToolTip(pic1, "Show Password");
                tpassword.UseSystemPasswordChar = true;
                pic1.Image = Resources.show;
            }
        }

        private void tpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tpassword.Text))
            {
                tpassword.Text = "0";
                FullName += "[null]";
            }

            if (!long.TryParse(tpassword.Text, out Password))
            {
                error.SetError(tpassword, "Value Unknown");
                errortimer.Start();
                return;
            }
            FileStream fs;
            if (!File.Exists(Path_Data + "pass.bin"))
                fs = new FileStream(Path_Data + "pass.bin", FileMode.Create, FileAccess.ReadWrite);
            else
                fs = new FileStream(Path_Data + "pass.bin", FileMode.Append, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(FullName);
            bw.Write(Password);
            bw.Close();
            fs.Close();
            Successful = true;
            this.Close();
        }

        private void errortimer_Tick(object sender, EventArgs e)
        {
            errortimer.Stop();
            error.Clear();
        }
    }
}