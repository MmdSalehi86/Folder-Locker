using System.Security.AccessControl;
using System.Windows.Forms;
using System;
using System.IO;

namespace Folder.Lock
{
    internal static class FolderCode
    {
        public static void Unlock(string fullPath)
        {
            DirectoryInfo dir = new DirectoryInfo(fullPath);
            string folderName;
            if (!dir.FullName.Contains(".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}"))
            {
                MessageBox.Show("پوشه مورد نظر قفل نیست", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }
            UnLockFolder UnLock = new UnLockFolder(dir.FullName);
            UnLock.ShowDialog();
            if (!UnLock.Successful)
            {
                MessageBox.Show("عملیات لغو شد", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                   MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                try
                {
                    string username = Environment.UserName;
                    DirectorySecurity ds = dir.GetAccessControl();
                    FileSystemAccessRule rule = new FileSystemAccessRule(username, FileSystemRights.FullControl, AccessControlType.Deny);
                    ds.RemoveAccessRule(rule);
                    dir.SetAccessControl(ds);
                    int index = dir.Name.IndexOf(".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}");
                    folderName = dir.Name.Remove(index);
                    dir.MoveTo(dir.Parent.FullName + "\\" + folderName);
                    MessageBox.Show("قفل پوشه باز شد", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information,
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
    }
}