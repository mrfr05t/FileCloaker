using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace FileCloaker
{
    public partial class Decloaker : Form
    {
        Main form;
        public Decloaker(Main frm)
        {
            form = frm;
            InitializeComponent();
        }
        static string TempFile = System.Environment.GetFolderPath(System.Environment.SpecialFolder.CommonApplicationData) + "\\temp.dmp";


        public void Cipher_Func()
        {
            DirectoryInfo d = new DirectoryInfo(@"ciphers/");
            FileInfo[] Files = d.GetFiles();
            foreach (FileInfo file in Files)
            {
                Selectdecipher.Items.Add(file.Name);
            }
        }

        bool workerfilled = false;

        Variables variables = new Variables();
        Functions fuctions = new Functions();


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog FileOpen = new OpenFileDialog();
                FileOpen.Filter = "All Files|*.*";

                if (FileOpen.ShowDialog() == DialogResult.OK)
                {
                    variables.FileName = FileOpen.FileName;
                    FilePath.Text = FileOpen.FileName;
                    variables.ciphered = File.ReadAllLines(FileOpen.FileName);
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
                    
                    FileInfo GetFileExt = new FileInfo(FilePath.Text);
                    string ExtensionFinal = GetFileExt.Extension;
                    Ltype.Text = ExtensionFinal;

                }
                else
                {
                    MessageBox.Show("Please select a file", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("This file cannot be decloacked", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Decloaker_Load(object sender, EventArgs e)
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
                if (File.Exists(TempFile))
                {
                    File.Delete(TempFile);
                }
            }
            catch 
            {
                MessageBox.Show("Ciphers not found", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (AddedNoise.Checked)
            {
                noiseyesno.Text = "Yes";
            }
            else
            {
                noiseyesno.Text = "No";
            }
        }

        private void Selectdecipher_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lchipher.Text = Selectdecipher.Text;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Start.Text = "Cancel";
                string[] enccipher = File.ReadAllLines("ciphers/" + Selectdecipher.Text);
                List<string> chiphers = new List<string>();
                foreach (string encword in enccipher)
                {
                    chiphers.Add(fuctions.Decrypt(encword));
                }
                DecloakPro.Maximum = variables.ciphered.Length;
                List<string> list = new List<string>();
                if (AddedNoise.Checked)
                {
                    //deStatus.Text = "Processing";
                    foreach (string chip in variables.ciphered)
                    {
                        if (backgroundWorker1.CancellationPending == true)
                        {
                            e.Cancel = true;
                            return;

                        }
                        list.Add(chip.Split(new String[] { "  " }, StringSplitOptions.None)[1]);
                    }
                    if (chiphers.Contains(list[1]))
                    {
                        var appender = File.AppendText(TempFile);
                        foreach (string c in list)
                        {
                            if (Array.IndexOf(chiphers.ToArray(), c) >= 0)
                            {
                                if (backgroundWorker1.CancellationPending == true)
                                {
                                    e.Cancel = true;
                                    return;

                                }
                                appender.Write(variables.cipherArray[Array.IndexOf(chiphers.ToArray(), c)]);
                                DecloakPro.Value++;
                            }
                        }
                        appender.Close();
                        workerfilled = true;
                    }
                    else
                    {
                        
                        e.Cancel = true;
                        MessageBox.Show("This file have different cipher","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    if (chiphers.Contains(variables.ciphered[1]))
                    {
                        if (variables.FileName.EndsWith(".docx"))
                        {
                            var appender = File.AppendText(TempFile);
                            var doc = DocX.Load(variables.FileName);
                            variables.ciphered = doc.Text.Split('\n');
                            foreach (string c in variables.ciphered)
                            {
                                if (backgroundWorker1.CancellationPending == true)
                                {
                                    e.Cancel = true;
                                    return;

                                }
                                appender.Write(variables.cipherArray[Array.IndexOf(chiphers.ToArray(), c)]);
                                DecloakPro.Value++;
                            }
                            appender.Close();
                            workerfilled = true;
                        }
                        else
                        {
                            var appender = File.AppendText(TempFile);
                            foreach (string c in variables.ciphered)
                            {
                                if (backgroundWorker1.CancellationPending == true)
                                {
                                    e.Cancel = true;
                                    return;

                                }
                                appender.Write(variables.cipherArray[Array.IndexOf(chiphers.ToArray(), c)]);
                                DecloakPro.Value++;
                            }
                            workerfilled = true;
                            appender.Close();
                        }
                    }
                    else
                    {
                        e.Cancel = true;
                        MessageBox.Show("This file have different cipher", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Start.Text = "Start Decloaking";
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            try
            {
                if (e.Cancelled)
                {
                    form.Enablebtn();
                    Selectdecipher.Enabled = true;
                    AddedNoise.Enabled = true;
                    FilePath.Enabled = true;
                    OpenFile.Enabled = true;
                    workerfilled = false;
                    DecloakPro.Value = 0;
                    MessageBox.Show("Decloaking canceled", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Start.Text = "Start Decloaking";
                    if (File.Exists(TempFile))
                    {
                        File.Delete(TempFile);
                    }
                }
                if (workerfilled == true)
                {
                    form.Enablebtn();
                    Selectdecipher.Enabled = true;
                    AddedNoise.Enabled = true;
                    FilePath.Enabled = true;
                    OpenFile.Enabled = true;
                    MessageBox.Show("File decloaked successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SaveFileDialog newfile = new SaveFileDialog();
                    newfile.Filter = "All files (*.*)|*.*";
                    if (newfile.ShowDialog() == DialogResult.OK)
                    {
                        var filler=Convert.FromBase64String(File.ReadAllText(TempFile));
                        File.WriteAllBytes(newfile.FileName, filler);
                        DecloakPro.Value = 0;
                        MessageBox.Show("File saved successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (File.Exists(TempFile))
                        {
                            File.Delete(TempFile);
                        }
                    }
                    else
                    {
                        if (File.Exists(TempFile))
                        {
                            File.Delete(TempFile);
                        }
                        MessageBox.Show("File not saved", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                    }
                    workerfilled = false;
                    Start.Text = "Start Decloaking";
                    DecloakPro.Value = 0;
                }
            }
            catch 
            {
                form.Enablebtn();
                workerfilled = false;
                DecloakPro.Value = 0;
                Start.Text = "Start Decloaking";
                MessageBox.Show("Error file decloaking","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            try
            {
                if (backgroundWorker1.IsBusy == true && Start.Text == "Cancel")
                {
                    workerfilled = false;
                    backgroundWorker1.CancelAsync();
                    backgroundWorker1.Dispose();
                }
                else
                {
                    if (FilePath.Text == "")
                    {
                        MessageBox.Show("select a file", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (Selectdecipher.Text == "")
                    {
                        MessageBox.Show("select a cipher", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Start.Text = "Cancel";
                        backgroundWorker1.WorkerSupportsCancellation = true;
                        backgroundWorker1.RunWorkerAsync();
                        form.Disablebtn();
                        Selectdecipher.Enabled = false;
                        AddedNoise.Enabled = false;
                        FilePath.Enabled = false;
                        OpenFile.Enabled = false;


                    }
                }
            }
            catch
            {
                workerfilled = false;
                Start.Text = "Start Decloaking";
                MessageBox.Show("Unable to decloak the file.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
