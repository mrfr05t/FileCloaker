using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Xceed.Words.NET;

namespace FileCloaker
{
    public partial class Cloaker : Form
    {
        Main form;
        public Cloaker(Main frm)
        {
            form = frm;
            InitializeComponent();
        }
        Variables variables = new Variables();
        Functions fuctions = new Functions();



        public bool workerfilled = false;
        public void Cipher_Func()
        {
            try
            {
                DirectoryInfo d = new DirectoryInfo(@"ciphers/");
                FileInfo[] Files = d.GetFiles();
                foreach (FileInfo file in Files)
                {
                    SelectCipher.Items.Add(file.Name);
                    SelectNoise.Items.Add(file.Name);

                }
            }
            catch 
            {

            }
        }
        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Addnoise.Checked)
            {
                SelectedN.Text = SelectNoise.Text;
            }
        }

        private void guna2GroupBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog FileOpen = new OpenFileDialog();
                FileOpen.DefaultExt = "";
                FileOpen.Filter = "all Files|*.*";
                if (FileOpen.ShowDialog() != DialogResult.Cancel)
                {
                    try
                    {
                        cloakpath.Text = FileOpen.FileName;
                        byte[] payloadRaw = File.ReadAllBytes(FileOpen.FileName);
                        string base64string = Convert.ToBase64String(payloadRaw, 0, payloadRaw.Length);
                        variables.toCipher = base64string;
                        if (FileOpen.SafeFileName.Length > 25)
                        {
                            Lname.Text = FileOpen.SafeFileName.Substring(0, 20) + "...";
                        }
                        else
                        {
                            Lname.Text = FileOpen.SafeFileName;
                        }
                        Functions fuctions = new Functions();
                        Lsize.Text = fuctions.fileSize(FileOpen.FileName);
                        var pathlength = FileOpen.FileName.LastIndexOf('\\') + 1;
                        if (pathlength > 25)
                        {
                            ToolTip yourToolTip = new ToolTip();
                            yourToolTip.ShowAlways = true;

                        }
                        else
                        {
                        }
                        FileInfo GetFileExt = new FileInfo(cloakpath.Text);
                        string ExtensionFinal = GetFileExt.Extension;
                        Ltype.Text = ExtensionFinal;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a file first", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("The selected File cannot be Cloaked","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Lsize_Click(object sender, EventArgs e)
        {

        }

        private void Cloaker_Load(object sender, EventArgs e)
        {
            try
            {
                CheckForIllegalCrossThreadCalls = false;
                Cipher_Func();
                List<string> array64 = new List<string>();
                string line = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789/+=";
                foreach (char c in line)
                {
                    array64.Add(c.ToString());
                }
                variables.cipherArray = array64;
            }
            catch
            {
                MessageBox.Show("Ciphers not found", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Addnoise.Checked)
            {
                SelectNoise.Visible = true;
                Lnoise.Visible = true;  
                SelectedN.Text = SelectNoise.Text;
            }
            else
            {
                SelectNoise.Visible = false;
                Lnoise.Visible = false;
                SelectedN.Text = "...";
            }
        }



        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Start.Text = "Cancel";
                string[] enccipher = File.ReadAllLines("ciphers/" + SelectCipher.Text);
                List<string> cipher = new List<string>();
                foreach(string encword in enccipher)
                {
                    cipher.Add(fuctions.Decrypt(encword));
                }
                CloakProgress.Value = 0;
                CloakProgress.Maximum = variables.toCipher.Length;

                if (Addnoise.Checked)
                {
                    if (variables.FillerPath.EndsWith(".docx"))
                    {
                        var doc = DocX.Create(variables.FillerPath);
                        doc.DifferentFirstPage = true;
                        string[] encciphers = File.ReadAllLines("ciphers/" + SelectNoise.Text);
                        List<string> ciphers = new List<string>();
                        foreach (string encword in encciphers)
                        {
                            ciphers.Add(fuctions.Decrypt(encword));
                        }
                        Random rand = new Random();
                        foreach (char c in variables.toCipher)
                        {
                            if (backgroundWorker1.CancellationPending == true)
                            {
                                doc.Dispose();
                                e.Cancel = true;
                                return;

                            }
                            int index = rand.Next(ciphers.ToArray().Length);

                            doc.InsertParagraph(ciphers[index] + "  " + cipher[variables.cipherArray.IndexOf(c.ToString())] + "\n");
                            CloakProgress.Value++;
                        }
                        workerfilled = true;
                        doc.Save();
                        doc.Dispose();

                    }
                    else
                    {
                        string[] encciphers = File.ReadAllLines("ciphers/" + SelectNoise.Text);
                        List<string> ciphers = new List<string>();
                        foreach (string encword in encciphers)
                        {
                            ciphers.Add(fuctions.Decrypt(encword));
                        }
                        Random rand = new Random();
                        StreamWriter filler = File.AppendText(variables.FillerPath);
                        foreach (char c in variables.toCipher)
                        {
                            if (backgroundWorker1.CancellationPending == true)
                            {
                                filler.Close();
                                e.Cancel = true;
                                return;

                            }
                            int index = rand.Next(ciphers.ToArray().Length);

                            filler.Write(ciphers[index] + "  " + cipher[variables.cipherArray.IndexOf(c.ToString())] + "\n");
                            CloakProgress.Value++;
                        }
                        workerfilled = true;
                        filler.Close();
                        
                    }
                }

                else
                {
                    if (variables.FillerPath.EndsWith(".docx"))
                    {
                        var doc = DocX.Create(variables.FillerPath);
                        doc.DifferentFirstPage = true;
                        foreach (char c in variables.toCipher)
                        {
                            if (backgroundWorker1.CancellationPending == true)
                            {
                                doc.Dispose();
                                e.Cancel = true;
                                return;

                            }

                            doc.InsertParagraph(cipher[variables.cipherArray.IndexOf(c.ToString())] + "\n");
                            CloakProgress.Value++;
                        }
                        workerfilled = true;

                        doc.Save();
                        doc.Dispose();
                    }
                    else
                    {
                        StreamWriter filler = File.AppendText(variables.FillerPath);
                        foreach (char c in variables.toCipher)
                        {
                            if (backgroundWorker1.CancellationPending == true)
                            {
                                filler.Close();
                                e.Cancel = true;
                                return;

                            }

                            filler.Write(cipher[variables.cipherArray.IndexOf(c.ToString())] + "\n");
                            CloakProgress.Value++;
                        }
                        workerfilled = true;
                        filler.Close();
                    }
                }
                
                Start.Text = "Start Cloaking";
            }
            catch
            {
                MessageBox.Show("Error","",MessageBoxButtons.OK, MessageBoxIcon.Error);
                Start.Text = "Start Cloaking";
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Cancelled)
                {
                    form.Enablebtn();
                    File.Delete(variables.FillerPath);
                    workerfilled = false;
                    CloakProgress.Value = 0;
                    Start.Text = "Start Cloaking";
                    MessageBox.Show("Canceled", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cloakpath.Text = "";
                    Lname.Text = "...";
                   // Llocation.Text = "...";
                    Ltype.Text = "...";
                    Lsize.Text = "...";
                    SelectCipher.Text = "...";
                   //Fextension.Text = "...";
                    SelectedN.Text = "...";
                }
                if (workerfilled)
                {
                    form.Enablebtn();
                    MessageBox.Show("File cloaked and saved successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cloakpath.Text = "";
                    Lname.Text = "...";
                   // Llocation.Text = "...";
                    Ltype.Text = "...";
                    Lsize.Text = "...";
                    SelectCipher.Text = "...";
                    //Fextension.Text = "...";
                    SelectedN.Text = "...";
                }
                    CloakProgress.Value = 0;
                    workerfilled = false;
                
            }
            catch
            {
                Start.Text = "Start Cloaking";
                MessageBox.Show("Error Try again","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            try
            {
                if (backgroundWorker1.IsBusy && Start.Text == "Cancel")
                {
                    DialogResult beta = MessageBox.Show("Are you sure! you want to cancel this process?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (beta == DialogResult.Yes)
                    {
                        backgroundWorker1.CancelAsync();
                        backgroundWorker1.Dispose();
                    }
                    else
                    {

                    }

                }
                else
                {
                    if (cloakpath.Text == "")
                    {
                        MessageBox.Show("Please select a file first", "Need attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (SelectCipher.Text == "")
                    {
                        MessageBox.Show("Please select a cipher first", "Need attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Addnoise.Checked && SelectNoise.Text == "")
                    {
                        MessageBox.Show("Please Select a Noise", "Need attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult delta = MessageBox.Show("Are you sure you want to cloak this file?", "Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                        if (delta == DialogResult.Yes)
                        {
                            SaveFileDialog SF = new SaveFileDialog();
                            SF.Filter= "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                            if (SF.ShowDialog() == DialogResult.OK)
                            {
                                variables.FillerPath = SF.FileName;
                                backgroundWorker1.WorkerSupportsCancellation = true;
                                backgroundWorker1.RunWorkerAsync();
                                form.Disablebtn();
                                SelectCipher.Enabled = true;
                                Addnoise.Enabled = true;
                                cloakpath.Enabled = true;
                                guna2Button1.Enabled = true;
                                SelectNoise.Enabled = true;
                                string contents = @"Meta data file created by File Cloaker" + "\n" + "\n" + "Original File Location:" + cloakpath.Text + "\nFile Size:" + Lsize.Text + "\nSelected Cipher:" + SelectedC.Text.ToUpper() + "\nSelected Noise:" + SelectedN.Text.ToUpper() + "\nCloaked File Location:" + SF.FileName;
                                string[] fillerFile = SF.FileName.Split('\\');
                                File.WriteAllText(Path.GetDirectoryName(SF.FileName) + "\\Metadata-File-" + fillerFile.Last(), contents);

                            }
                            else
                            {
                                MessageBox.Show("Please select a path to save the cloaked file", "Need Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            
                        }
                        else
                        {

                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error","",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Llocation_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void SelectCipher_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SelectedC.Text = SelectCipher.Text;
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
