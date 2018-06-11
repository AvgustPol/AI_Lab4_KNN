using System;
using System.Windows.Forms;

namespace AI_Lab4_KNN
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonFindKNN_Click(object sender, EventArgs e)
        {
            ImageParametrs firstImageParametrs =  FileReader.ReadParametrs(1);
            ImageParametrs secondImageParametrs = FileReader.ReadParametrs(2);
        }
    }
}
