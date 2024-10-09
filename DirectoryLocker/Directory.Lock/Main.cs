using System;
using System.Drawing;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace Folder.Lock
{
    public partial class Main : Form
    {
        static public readonly string Path_Data = "C:\\Program Files (x86)\\folderlocker\\";
        public Main()
        {
            InitializeComponent();
            Folder.ShowNewFolderButton = true;
            Folder.Description = "Directory Secure";
            Folder.RootFolder = Environment.SpecialFolder.Desktop;
        }

        private void btnlock_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir;
            Folder.Description = "Lock Folder";
            if (Folder.ShowDialog() == DialogResult.OK)
            {
                dir = new DirectoryInfo(Folder.SelectedPath);
                if (dir.FullName.Contains(".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}"))
                {
                    MessageBox.Show("پوشه مورد نظر قفل است", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                    return;
                }
                LockFolder Lock = new LockFolder(dir.FullName);
                Lock.ShowDialog();
                if (!Lock.Successful)
                {
                    MessageBox.Show("عملیات لغو شد", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);
                    return;
                }
                try
                {
                    dir.MoveTo(dir.Parent.FullName + "\\" + dir.Name + ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}");
                    string username = Environment.UserName;
                    DirectorySecurity ds = dir.GetAccessControl();
                    FileSystemAccessRule rule = new FileSystemAccessRule(username, FileSystemRights.FullControl, AccessControlType.Deny);
                    ds.AddAccessRule(rule);
                    dir.SetAccessControl(ds);
                    MessageBox.Show("پوشه قفل شد", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
                catch
                {
                    MessageBox.Show("Something went wrong", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1);
                }
                finally
                {
                    GC.Collect();
                }
            }
        }

        private void btnunlock_Click(object sender, EventArgs e)
        {
            Folder.Description = "Unlock Folder";
            if (Folder.ShowDialog() == DialogResult.OK)
            {
                FolderCode.Unlock(Folder.SelectedPath);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(Path_Data))
                Directory.CreateDirectory(Path_Data);
            if (!File.Exists(Path_Data + "pass.bin"))
            {
                File.Create(Path_Data + "pass.bin").Close();
                Terms t = new Terms();
                t.ShowDialog();
            }
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Terms t = new Terms();
            t.ShowDialog();
        }

        private void btnListFolder_Click(object sender, EventArgs e)
        {
            ListLockFolder listfolder = new ListLockFolder();
            listfolder.ShowDialog();
        }
    }
}