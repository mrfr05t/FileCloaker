using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace FileCloaker
{
    public partial class Main : Form
    {
        Variables variables = new Variables();
        Functions functions = new Functions();

        public void startForm()
        {
            Application.Run(new Main());
        }
        public Main()
        {
            InitializeComponent();
        }

        public void Enablebtn()
        {
            Decloaker.Enabled = true;
            Cloaker.Enabled = true;
            Settings.Enabled = true;
            guna2ControlBox1.Enabled = true;
        }
        public void Disablebtn()
        {
            Decloaker.Enabled = false;
            Cloaker.Enabled = false;
            Settings.Enabled = false;
            guna2ControlBox1.Enabled = false;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Cloaker cloaker = new Cloaker(this);
            cloaker.TopLevel = false;
            cloaker.AutoScroll = true;
            panel2.Controls.Add(cloaker);
            cloaker.Show();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Decloaker decloaker = new Decloaker(this);
            decloaker.TopLevel = false;
            decloaker.AutoScroll = true;
            panel2.Controls.Add(decloaker);
            decloaker.Show();

        }

        private void Settings_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            AddNewCipher newCipher = new AddNewCipher();
            newCipher.TopLevel = false;
            newCipher.AutoScroll = true;
            panel2.Controls.Add(newCipher);
            newCipher.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string mymsgtodeply = @"File Cloaker " + "\nis not a secure encryption scheme. It's vulnerable to frequency analysis attacks. Use your own 'Cipher' and 'Add Noise' option to add entropy when cloaking a data to help degrade frequency analysis attacks. Be sure to encrypt the file prior to cloaking if secrecy is needed.";
            string TitleText = @"Disclaimer";
            Info info = new Info();
            info.TitleOfGroupBox(TitleText);
            info.DataToShow(mymsgtodeply);
            info.ShowDialog();
        }


        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("You are about to redirect to the developers github page", "Incomming!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.Start("https://github.com/Omnimaverick");
            Process.Start("https://github.com/mrfr05t");

        }

    
    }
}
