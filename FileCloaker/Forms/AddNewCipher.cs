using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileCloaker
{
    public partial class AddNewCipher : Form
    {
        
        public AddNewCipher()
        {
            InitializeComponent();
        }

        Variables variables = new Variables();
        Functions fuctions = new Functions();
        private void AddCipher_Click(object sender, EventArgs e)
        {
           

            try
            {
                string initPath = Directory.GetCurrentDirectory() + @"\ciphers\";
                string[] words = CipherWords.Text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                List<string> newWords = new List<string>();
                foreach (string word in words)
                {
                    newWords.Add(fuctions.Encrypt(word));
                }
                if (words.Length < 66)
                {
                    MessageBox.Show("Enter 66 characters you are missing " + (66 - words.Length), "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (words.Distinct().Count() < 66)
                {
                    MessageBox.Show("You have entered a duplicate value", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    File.WriteAllLines(initPath + CipherData.Text, newWords);


                    MessageBox.Show("Cipher created successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Cannot make a cipher file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        ToolTip yourToolTip = new ToolTip();
        
        private void AddNewCipher_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string AddCipherHelp = @"
File Cloaker is at its best when you're using your own customized ciphers. The default ciphers may work for most needs, but in a unique data sharing scenario you may need to build your own. 

Creating a Cipher:
    1.Generate a list of at least 66 unique words / phrases / symbols (Unicode allowed)
    2.Remove all duplicate entries and all blank lines
    3.Randomize the list order
    4.Re-run File Cloaker and it will automatically load your new cipher as an option
    5.Test cloaking / decloaking with new cipher before using operationally";

            string TitleText = @"Create your own ciphers";
            Info info = new Info();
            info.TitleOfGroupBox(TitleText);
            info.DataToShow(AddCipherHelp);
            info.ShowDialog();    
        }

        private void CipherWords_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
