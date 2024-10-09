using System.Windows.Forms;

namespace Convert_Binary
{
    public partial class Intro : Form
    {
        public string LabelText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public Intro()
        {
            InitializeComponent();
        }
    }
}