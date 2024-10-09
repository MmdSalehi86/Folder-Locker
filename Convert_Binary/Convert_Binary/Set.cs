using System;
using System.Drawing;
using System.Windows.Forms;

namespace Convert_Binary
{
    public partial class Set : Form
    {
        Form1 F1 { get; set; }
        public FontDialog FD1 = new FontDialog();
        public FontDialog FD2 = new FontDialog();
        public ColorDialog cd1 = new ColorDialog();
        public ColorDialog cd2 = new ColorDialog();
        public Set(Form1 f1)
        {
            F1 = f1;
            InitializeComponent();
            {
                FD1.Font = F1.Text0.Font;
                FD1.ShowApply = true;
                FD1.Apply += Lable1_Edit;
                FD1.ShowColor = false;
                FD1.ShowHelp = false;
                FD1.ShowEffects = false;
            }
            {
                FD2.Font = F1.TBinary.Font;
                FD2.ShowApply = true;
                FD2.Apply += Lable2_Edit;
                FD2.ShowColor = false;
                FD2.ShowHelp = false;
                FD2.ShowEffects = false;
            }
            {
                cd1.Color = F1.Text0.ForeColor;
                cd2.Color = F1.TBinary.ForeColor;
            }
            label1.Font = FD1.Font;
            label1.ForeColor = cd1.Color;
            label2.Font = FD2.Font;
            label2.ForeColor = cd2.Color;
        }

        private void EditT_Click(object sender, EventArgs e)
        {
            if (FD1.ShowDialog() == DialogResult.OK)
                Lable1_Edit(sender, e);
            F1.Text0.Font = FD1.Font;
        }

        private void Lable1_Edit(object s, EventArgs e)
        {
            label1.Font = FD1.Font;
        }

        private void Lable2_Edit(object s, EventArgs e)
        {
            label2.Font = FD2.Font;
        }

        private void EditB_Click(object sender, EventArgs e)
        {
            if (FD2.ShowDialog() == DialogResult.OK)
                Lable2_Edit(sender, e);
            F1.TBinary.Font = FD2.Font;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Font f = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);
            Color c = Color.Black;
            F1.Text0.Font = f;
            F1.Text0.ForeColor = c;
            F1.TBinary.Font = f;
            F1.TBinary.ForeColor = c;
            FD1.Font = f;
            cd1.Color = c;
            FD2.Font = f;
            cd2.Color = c;
            label1.Font = f;
            label1.ForeColor = c;
            label2.Font = f;
            label2.ForeColor = c;
        }

        private void ColorT_Click(object sender, EventArgs e)
        {
            if (cd1.ShowDialog() == DialogResult.OK)
                label1.ForeColor = cd1.Color;
            F1.Text0.ForeColor = cd1.Color;
        }

        private void ColorB_Click(object sender, EventArgs e)
        {
            if (cd2.ShowDialog() == DialogResult.OK)
                label2.ForeColor = cd2.Color;
            F1.TBinary.ForeColor = cd2.Color;
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}