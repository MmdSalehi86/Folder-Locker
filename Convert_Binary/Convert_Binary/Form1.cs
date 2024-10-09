using System;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Convert_Binary
{
    public partial class Form1 : Form
    {
        private Intro intro;
        bool Convert_text = true;
        bool Binary_pre = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void TBinary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '0' && e.KeyChar != '1' && !char.IsControl(e.KeyChar) || e.KeyChar == '\r')
            {
                Error1.SetError(TBinary, "Value Unknown");
                e.Handled = true;
                timer1.Start();
            }
            else
            if (e.KeyChar == '\u001b')
            {
                TBinary.Clear();
                return;
            }
        }

        private void TBinary_TextChanged(object sender, EventArgs e)
        {
            if (!Convert_text)
            {
                if (Mode.SelectedIndex == 0)
                {
                    try
                    {
                        string binaryWithoutSpaces = Regex.Replace(TBinary.Text, @"\s+", "");
                        byte[] binaryBytes = new byte[binaryWithoutSpaces.Length / 8];
                        for (int i = 0; i < binaryWithoutSpaces.Length; i += 8)
                        {
                            binaryBytes[i / 8] = Convert.ToByte(binaryWithoutSpaces.Substring(i, 8), 2);
                        }
                        Text0.Text = Encoding.UTF8.GetString(binaryBytes);
                    }
                    catch
                    {
                        Text0.Text = "Error!";
                    }
                }
                else if (Mode.SelectedIndex == 1)
                {
                    try
                    {
                        int num = 0;
                        num = Convert.ToSByte(TBinary.Text, 2);
                        Text0.Text = num.ToString();
                    }
                    catch
                    {
                        Text0.Text = "Error!";
                    }
                }
                else if (Mode.SelectedIndex == 2)
                {
                    try
                    {
                        short num = 0;
                        num = Convert.ToInt16(TBinary.Text, 2);
                        Text0.Text = num.ToString();
                    }
                    catch
                    {
                        Text0.Text = "Error!";
                    }
                }
                else if (Mode.SelectedIndex == 3)
                {
                    try
                    {
                        int num = 0;
                        /*for (int i = 0; i < TBinary.Text.Length; i++)
                        {
                           int bit = int.Parse(TBinary.Text[TBinary.Text.Length - i - 1].ToString());
                           num += bit << i;
                        }*/
                        num = Convert.ToInt32(TBinary.Text, 2);
                        Text0.Text = num.ToString();
                    }
                    catch
                    {
                        Text0.Text = "Error!";
                    }
                }
                else if (Mode.SelectedIndex == 4)
                {
                    try
                    {
                        long num = 0;
                        num = Convert.ToInt64(TBinary.Text, 2);
                        Text0.Text = num.ToString();
                    }
                    catch
                    {
                        Text0.Text = "Error!";
                    }
                }
                else if (Mode.SelectedIndex == 5)
                {
                    try
                    {
                        int num = 0;
                        /*for (int i = 0; i < TBinary.Text.Length; i++)
                        {
                           int bit = int.Parse(TBinary.Text[TBinary.Text.Length - i - 1].ToString());
                           num += bit << i;
                        }*/
                        num = Convert.ToByte(TBinary.Text, 2);
                        Text0.Text = num.ToString();
                    }
                    catch
                    {
                        Text0.Text = "Error!";
                    }
                }
                else if (Mode.SelectedIndex == 6)
                {
                    try
                    {
                        ushort num = 0;
                        num = Convert.ToUInt16(TBinary.Text, 2);
                        Text0.Text = num.ToString();
                    }
                    catch
                    {
                        Text0.Text = "Error!";
                    }
                }
                else if (Mode.SelectedIndex == 7)
                {
                    try
                    {
                        uint num = 0;
                        num = Convert.ToUInt32(TBinary.Text, 2);
                        Text0.Text = num.ToString();
                    }
                    catch
                    {
                        Text0.Text = "Error!";
                    }
                }
                else if (Mode.SelectedIndex == 8)
                {
                    try
                    {
                        ulong num = 0;
                        num = Convert.ToUInt64(TBinary.Text, 2);
                        Text0.Text = num.ToString();
                    }
                    catch
                    {
                        Text0.Text = "Error!";
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Error1.Clear();
        }

        private void Text0_TextChanged(object sender, EventArgs e)
        {
            if (Convert_text)
            {
                if (Mode.SelectedIndex == 0)
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(Text0.Text);
                    StringBuilder binary = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        byte b = bytes[i];
                        for (int j = 0; j < 8; j++)
                        {
                            binary.Append((b & 0x80) == 0 ? '0' : '1');
                            b <<= 1;
                        }
                    }
                    TBinary.Text = binary.ToString();
                }
                else if (Mode.SelectedIndex == 1)
                {
                    try
                    {
                        sbyte number = sbyte.Parse(Text0.Text);
                        TBinary.Text = Convert.ToString(number, 2);
                    }
                    catch
                    {
                        TBinary.Text = "";
                    }
                }
                else if (Mode.SelectedIndex == 2)
                {
                    try
                    {
                        short number = short.Parse(Text0.Text);
                        TBinary.Text = Convert.ToString(number, 2);
                    }
                    catch
                    {
                        TBinary.Text = "";
                    }
                }
                else if (Mode.SelectedIndex == 3)
                {
                    try
                    {
                        int number = int.Parse(Text0.Text);
                        TBinary.Text = Convert.ToString(number, 2);
                    }
                    catch
                    {
                        TBinary.Text = "";
                    }
                }
                else if (Mode.SelectedIndex == 4)
                {
                    try
                    {
                        long number = long.Parse(Text0.Text);
                        TBinary.Text = Convert.ToString(number, 2);
                    }
                    catch
                    {
                        TBinary.Text = "";
                    }
                }
                else if (Mode.SelectedIndex == 5)
                {
                    try
                    {
                        byte number = byte.Parse(Text0.Text);
                        TBinary.Text = Convert.ToString(number, 2);
                    }
                    catch
                    {
                        TBinary.Text = "";
                    }
                }
                else if (Mode.SelectedIndex == 6)
                {
                    try
                    {
                        TBinary.Text = Convert.ToString(ushort.Parse(Text0.Text), 2);
                    }
                    catch
                    {
                        TBinary.Text = "";
                    }
                }
                else if (Mode.SelectedIndex == 7)
                {
                    try
                    {
                        uint u = uint.Parse(Text0.Text);
                        TBinary.Text = Convert.ToString(u, 2);
                    }
                    catch
                    {
                        TBinary.Text = "";
                    }
                }
                else if (Mode.SelectedIndex == 8)
                {
                    try
                    {
                        string sum = "";
                        ulong n = ulong.Parse(Text0.Text);
                        ulong R = 0;
                        while (n > 0)
                        {
                            R = n % 2;
                            sum += R;
                            n /= 2;
                        }
                        TBinary.Text = sum;
                        char[] ch = sum.ToCharArray();
                        Array.Reverse(ch);
                        TBinary.Text = string.Join("", ch);
                    }
                    catch
                    {
                        TBinary.Text = "";
                    }
                }
            }
        }

        private void TBinary_Enter(object sender, EventArgs e)
        {
            Binary_pre = false;
            if (TBinary.Text == "0")
            {
                Convert_text = true;
                TBinary.Clear();
                Convert_text = false;
                Text0.Clear();
            }
            Convert_text = false;
        }

        private void TBinary_Leave(object sender, EventArgs e)
        {
            Convert_text = true;
            Binary_pre = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            intro = new Intro();
            intro.Show();
            TimerLoad.Enabled = true;
            Load load = new Load();
            Text0.Font = load.FontText;
            Text0.ForeColor = load.ColorText;
            TBinary.Font = load.FontBinary;
            TBinary.ForeColor = load.ColorBinary;
            Mode.SelectedIndex = 0;
        }

        private void TimerLoad_Tick(object sender, EventArgs e)
        {
            TimerLoad.Enabled = false;
            intro.Close();
            UseWaitCursor = false;
        }

        private void Copy_b_Click(object sender, EventArgs e)
        {
            TBinary.SelectAll();
            TBinary.Copy();
        }

        private void Copy_t_Click(object sender, EventArgs e)
        {
            Text0.SelectAll();
            Text0.Copy();
        }

        private void Mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Binary_pre)
            {
                Convert_text = false;
                TBinary_TextChanged(null, EventArgs.Empty);
            }
            else
            {
                Convert_text = true;
                Text0_TextChanged(null, EventArgs.Empty);
            }
        }

        private void Text0_Enter(object sender, EventArgs e)
        {
            if (Mode.SelectedIndex != 0 && Text0.Text.CompareTo("Error!") == 0)
                Text0.Clear();
            if (Text0.Text == "Error!" && TBinary.Text == "0")
                Text0.Clear();
            Convert_text = true;
            Binary_pre = false;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e) => Application.Exit();

        private void loadSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            intro =new Intro();
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Setting File (*.bin)|*.bin";
            open.Title = "Open Settings File";
            open.RestoreDirectory = true;
            open.ShowHelp = true;
            open.HelpRequest += LoadSettingHelp;
            if (open.ShowDialog() == DialogResult.OK)
            {
                intro.LabelText = "Loading";
                intro.Show();
                TimerLoad.Enabled = true;
                File.Copy(open.FileName, "setting.bin", true);
                Load load = new Load();
                Text0.Font = load.FontText;
                Text0.ForeColor = load.ColorText;
                TBinary.Font = load.FontBinary;
                TBinary.ForeColor = load.ColorBinary;
            }
        }

        void LoadSettingHelp(object obj, EventArgs e)
        {
            MessageBox.Show("Import the \"setting.bin\" file to load the previous settings", "Open File Setting",
               MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void Text0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Mode.SelectedIndex != 0 && (!char.IsControl(e.KeyChar) || e.KeyChar == '\r') && !char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != '-')
                {
                    e.Handled = true;
                    Error1.SetError(Text0, "Value Unknown");
                    timer1.Start();
                }
            }
            if (e.KeyChar == '\u001b')
                Text0.Clear();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Set S = new Set(this);
            S.ShowDialog();
            intro = new Intro();
            intro.LabelText = "Saving";
            intro.Show();
            TimerLoad.Enabled = true;
            Upload upload = new Upload(this);
            upload.UploadData();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            intro = new Intro();
            intro.LabelText = "Saving";
            intro.Show();
            TimerLoad.Enabled = true;
            Upload upload = new Upload(this);
            upload.UploadData();
        }
    }
}