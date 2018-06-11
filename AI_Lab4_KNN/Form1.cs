using System;
using System.Windows.Forms;

namespace AI_Lab4_KNN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFindKNN_Click(object sender, EventArgs e)
        {
            FileReader.ReadParametrs(1);
            FileReader.ReadParametrs(2);
        }
    }
}
