using Folder.Lock.Properties;
using System;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace Folder.Lock
{
    public partial class UnLockFolder : Form
    {
        readonly string Path_Data = "C:\\Program Files (x86)\\folderlocker\\";
        public bool Successful { get; private set; }
        ErrorProvider error = new ErrorProvider();
        ToolTip tip = new ToolTip();

        private int PrePosition;
        private int Position;
        private string FullPath;
        private string FullName = null;
        private long Password;
        private bool NullPassword;

        public UnLockFolder(string fullname)
        {
            InitializeComponent();
            FullPath = fullname;
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

        private void errortimer_Tick(object sender, EventArgs e)
        {
            errortimer.Stop();
            error.Clear();
        }

        private void Loadtimer_Tick(object sender, EventArgs e)
        {
            Loadtimer.Stop();
            if (FullPath.Contains(".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}"))
                FullPath = FullPath.Replace(".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}", "");
            else
            {
                MessageBox.Show("پوشه مورد نظر قفل نیست", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                this.Close();
                return;
            }
            bool Folder = false;
            if (!File.Exists(Path_Data + "pass.bin"))
            {
                MessageBox.Show("File Not Found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                FileStream fs = new FileStream(Path_Data + "pass.bin", FileMode.Open, FileAccess.ReadWrite);
                BinaryReader br = new BinaryReader(fs);
                while (br.BaseStream.Position < br.BaseStream.Length)
                {
                    PrePosition = (int)br.BaseStream.Position;
                    FullName = br.ReadString();
                    Password = br.ReadInt64();
                    if (FullName.Contains("[null]"))
                    {
                        FullName = FullName.Replace("[null]", "");
                        NullPassword = true;
                    }
                    if (FullName.CompareTo(FullPath) == 0)
                    {
                        Position = (int)br.BaseStream.Position;
                        label1.Visible = false;
                        label2.Visible = true;
                        tpassword.ReadOnly = false;
                        button1.Enabled = true;
                        Folder = true;
                        break;
                    }
                    if (progLoad.Value < 100)
                    {
                        progLoad.Value += 5;
                    }
                }
                progLoad.Value = 100;
                if (!Folder)
                {
                    MessageBox.Show("پوشه مورد نظر قفل نیست", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                    this.Close();
                }
                br.Close();
                fs.Close();
            }
        }

        private void UnLockFolder_Load(object sender, EventArgs e)
        {
            progLoad.Value = 50;
            Loadtimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long Password;
            if (string.IsNullOrEmpty(tpassword.Text) && NullPassword)
            {
                Successful = true;
                RemoveData();
                Close();
            }
            else if (!long.TryParse(tpassword.Text, out Password))
            {
                error.SetError(tpassword, "Value Unknown");
                errortimer.Start();
            }
            else
            {
                if (this.Password == Password)
                {
                    Successful = true;
                    RemoveData();
                    Close();
                }
                else
                {
                    error.SetError(tpassword, "Password is wrong");
                    errortimer.Start();
                }
            }
        }

        private void RemoveData()
        {
            byte[] buffer;
            FileStream fs = new FileStream(Path_Data + "pass.bin", FileMode.Open, FileAccess.ReadWrite);
            fs.Position = Position;
            BinaryReader br = new BinaryReader(fs);
            BinaryWriter bw = new BinaryWriter(fs);

            buffer = new byte[br.BaseStream.Length - (Position - 1)];
            buffer = br.ReadBytes(buffer.Length);
            bw.BaseStream.Position = PrePosition;
            bw.Write(buffer);
            bw.BaseStream.SetLength(bw.BaseStream.Length - (Position - PrePosition));

            bw.Close();
            br.Close();
            fs.Close();
        }

        private void tpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}