using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Folder.Lock
{
    public partial class ListLockFolder : Form
    {
        public ListLockFolder()
        {
            InitializeComponent();
        }

        private void ListLockFolder_Load(object sender, EventArgs e)
        {
            loading.Value = 50;
            UseWaitCursor = true;
            tLoad.Enabled = true;
            listFolder.Visible = false;
            Location = new Point(Location.X, Location.Y + 80);
        }

        private void tLoad_Tick(object sender, EventArgs e)
        {
            tLoad.Enabled = false;
            label1.Location = new Point(230, 23);
            label1.Text = "بررسی اطلاعات ...";
            FileStream fs = new FileStream(Main.Path_Data + "pass.bin", FileMode.Open, FileAccess.Read);
            if (fs.Length == 0)
            {
                listFolder.Visible = false;
                label1.Text = "شما هیچ پوشه ی قفل شده ای ندارید";
                label1.Location = new Point(label1.Location.X - 60, label1.Location.Y);
                UseWaitCursor = false;
                loading.Value = 100;
                fs.Close();
                return;
            }
            listFolder.Visible = true;
            BinaryReader br = new BinaryReader(fs);
            string path;
            int index;
            while (br.BaseStream.Length > br.BaseStream.Position)
            {
                path = br.ReadString();
                index = path.IndexOf("[null]");
                if (index != -1)
                {
                    path = path.Remove(index);
                }
                listFolder.Items.Add(path);
                br.BaseStream.Position += 8;
            }
            Thread.Sleep(600);
            br.Close();
            fs.Close();
            UseWaitCursor = false;
            label1.Text = "برای باز کردن هر پوشه دو بار روی آن کلیک کنید";
            label1.Location = new Point(label1.Location.X - 90, label1.Location.Y);
            loading.Value = 100;
            listFolder.SelectedIndex = 0;
        }

        private void listFolder_DoubleClick(object sender, EventArgs e)
        {
            string fullpath = listFolder.SelectedItem.ToString() + ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}";
            FolderCode.Unlock(fullpath);
            listFolder.Items.Clear();
            tLoad.Enabled = true;
        }
    }
}