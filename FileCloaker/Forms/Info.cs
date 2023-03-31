using System;
using System.Windows.Forms;

namespace FileCloaker
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }
        public void DataToShow(string message)
        {
           richTextBox1.Text = @message;
        }

        public void TitleOfGroupBox(string titletext)
        {
        }
        private void Info_Load(object sender, EventArgs e)
        {
            

        }
    }
}
