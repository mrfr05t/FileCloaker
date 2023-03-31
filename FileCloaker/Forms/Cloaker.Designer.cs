namespace FileCloaker
{
    partial class Cloaker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.SelectCipher = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Lnoise = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.Addnoise = new Guna.UI2.WinForms.Guna2CheckBox();
            this.SelectNoise = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Lsize = new Guna.UI.WinForms.GunaLabel();
            this.Ltype = new Guna.UI.WinForms.GunaLabel();
            this.Lname = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.cloakpath = new Guna.UI2.WinForms.Guna2TextBox();
            this.Start = new Guna.UI2.WinForms.Guna2Button();
            this.CloakProgress = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.SelectedN = new Guna.UI.WinForms.GunaLabel();
            this.SelectedC = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.guna2GroupBox3.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GroupBox3.BorderRadius = 2;
            this.guna2GroupBox3.Controls.Add(this.SelectCipher);
            this.guna2GroupBox3.Controls.Add(this.Lnoise);
            this.guna2GroupBox3.Controls.Add(this.gunaLabel8);
            this.guna2GroupBox3.Controls.Add(this.Addnoise);
            this.guna2GroupBox3.Controls.Add(this.SelectNoise);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2GroupBox3.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox3.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox3.Location = new System.Drawing.Point(25, 168);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(776, 116);
            this.guna2GroupBox3.TabIndex = 5;
            this.guna2GroupBox3.Text = "Cipher Selection";
            // 
            // SelectCipher
            // 
            this.SelectCipher.BackColor = System.Drawing.Color.Transparent;
            this.SelectCipher.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SelectCipher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SelectCipher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectCipher.FillColor = System.Drawing.Color.Black;
            this.SelectCipher.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SelectCipher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SelectCipher.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCipher.ForeColor = System.Drawing.Color.White;
            this.SelectCipher.ItemHeight = 30;
            this.SelectCipher.Location = new System.Drawing.Point(16, 63);
            this.SelectCipher.Name = "SelectCipher";
            this.SelectCipher.Size = new System.Drawing.Size(334, 36);
            this.SelectCipher.TabIndex = 5;
            this.SelectCipher.SelectedIndexChanged += new System.EventHandler(this.SelectCipher_SelectedIndexChanged_1);
            // 
            // Lnoise
            // 
            this.Lnoise.AutoSize = true;
            this.Lnoise.BackColor = System.Drawing.Color.Black;
            this.Lnoise.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lnoise.ForeColor = System.Drawing.Color.White;
            this.Lnoise.Location = new System.Drawing.Point(531, 32);
            this.Lnoise.Name = "Lnoise";
            this.Lnoise.Size = new System.Drawing.Size(89, 19);
            this.Lnoise.TabIndex = 4;
            this.Lnoise.Text = "Select Noise";
            this.Lnoise.Visible = false;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.BackColor = System.Drawing.Color.Black;
            this.gunaLabel8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.White;
            this.gunaLabel8.Location = new System.Drawing.Point(12, 32);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(94, 19);
            this.gunaLabel8.TabIndex = 3;
            this.gunaLabel8.Text = "Select Cipher";
            // 
            // Addnoise
            // 
            this.Addnoise.AutoSize = true;
            this.Addnoise.BackColor = System.Drawing.Color.Black;
            this.Addnoise.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Addnoise.CheckedState.BorderRadius = 0;
            this.Addnoise.CheckedState.BorderThickness = 0;
            this.Addnoise.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Addnoise.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addnoise.ForeColor = System.Drawing.Color.White;
            this.Addnoise.Location = new System.Drawing.Point(415, 63);
            this.Addnoise.Name = "Addnoise";
            this.Addnoise.Size = new System.Drawing.Size(94, 23);
            this.Addnoise.TabIndex = 2;
            this.Addnoise.Text = "Add Noise";
            this.Addnoise.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Addnoise.UncheckedState.BorderRadius = 0;
            this.Addnoise.UncheckedState.BorderThickness = 0;
            this.Addnoise.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Addnoise.UseVisualStyleBackColor = false;
            this.Addnoise.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // SelectNoise
            // 
            this.SelectNoise.BackColor = System.Drawing.Color.Transparent;
            this.SelectNoise.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SelectNoise.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SelectNoise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectNoise.FillColor = System.Drawing.Color.Black;
            this.SelectNoise.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SelectNoise.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SelectNoise.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectNoise.ForeColor = System.Drawing.Color.White;
            this.SelectNoise.ItemHeight = 30;
            this.SelectNoise.Location = new System.Drawing.Point(535, 63);
            this.SelectNoise.Name = "SelectNoise";
            this.SelectNoise.Size = new System.Drawing.Size(228, 36);
            this.SelectNoise.TabIndex = 1;
            this.SelectNoise.Visible = false;
            this.SelectNoise.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox2_SelectedIndexChanged);
            // 
            // Lsize
            // 
            this.Lsize.AutoSize = true;
            this.Lsize.BackColor = System.Drawing.Color.Transparent;
            this.Lsize.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lsize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Lsize.Location = new System.Drawing.Point(504, 88);
            this.Lsize.Name = "Lsize";
            this.Lsize.Size = new System.Drawing.Size(0, 19);
            this.Lsize.TabIndex = 7;
            this.Lsize.Click += new System.EventHandler(this.Lsize_Click);
            // 
            // Ltype
            // 
            this.Ltype.AutoSize = true;
            this.Ltype.BackColor = System.Drawing.Color.Transparent;
            this.Ltype.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Ltype.Location = new System.Drawing.Point(349, 88);
            this.Ltype.Name = "Ltype";
            this.Ltype.Size = new System.Drawing.Size(0, 19);
            this.Ltype.TabIndex = 6;
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.BackColor = System.Drawing.Color.Transparent;
            this.Lname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Lname.Location = new System.Drawing.Point(92, 88);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(0, 19);
            this.Lname.TabIndex = 4;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(440, 88);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(65, 19);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "File Size:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(280, 88);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(70, 19);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "File Type:";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(16, 88);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(78, 19);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "File Name:";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GroupBox1.BorderRadius = 4;
            this.guna2GroupBox1.Controls.Add(this.Lsize);
            this.guna2GroupBox1.Controls.Add(this.guna2Button1);
            this.guna2GroupBox1.Controls.Add(this.gunaLabel4);
            this.guna2GroupBox1.Controls.Add(this.Ltype);
            this.guna2GroupBox1.Controls.Add(this.cloakpath);
            this.guna2GroupBox1.Controls.Add(this.gunaLabel3);
            this.guna2GroupBox1.Controls.Add(this.gunaLabel1);
            this.guna2GroupBox1.Controls.Add(this.Lname);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(25, 26);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(776, 124);
            this.guna2GroupBox1.TabIndex = 3;
            this.guna2GroupBox1.Text = "File Selection";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Button1.BorderRadius = 2;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(626, 37);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(137, 36);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Select File";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // cloakpath
            // 
            this.cloakpath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cloakpath.BorderRadius = 2;
            this.cloakpath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cloakpath.DefaultText = "";
            this.cloakpath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cloakpath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cloakpath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cloakpath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cloakpath.FillColor = System.Drawing.Color.Black;
            this.cloakpath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cloakpath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cloakpath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cloakpath.Location = new System.Drawing.Point(16, 37);
            this.cloakpath.Name = "cloakpath";
            this.cloakpath.PasswordChar = '\0';
            this.cloakpath.PlaceholderText = "";
            this.cloakpath.SelectedText = "";
            this.cloakpath.Size = new System.Drawing.Size(595, 36);
            this.cloakpath.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Start.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Start.BorderRadius = 2;
            this.Start.BorderThickness = 1;
            this.Start.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Start.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Start.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Start.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Start.FillColor = System.Drawing.Color.Black;
            this.Start.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.Location = new System.Drawing.Point(604, 332);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(197, 61);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start Cloaking";
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // CloakProgress
            // 
            this.CloakProgress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CloakProgress.BorderRadius = 2;
            this.CloakProgress.BorderThickness = 1;
            this.CloakProgress.FillColor = System.Drawing.Color.Black;
            this.CloakProgress.ForeColor = System.Drawing.Color.White;
            this.CloakProgress.Location = new System.Drawing.Point(25, 428);
            this.CloakProgress.Name = "CloakProgress";
            this.CloakProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CloakProgress.ProgressColor2 = System.Drawing.Color.Green;
            this.CloakProgress.ShowText = true;
            this.CloakProgress.Size = new System.Drawing.Size(776, 21);
            this.CloakProgress.TabIndex = 6;
            this.CloakProgress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CloakProgress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // SelectedN
            // 
            this.SelectedN.AutoSize = true;
            this.SelectedN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectedN.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.SelectedN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SelectedN.Location = new System.Drawing.Point(323, 383);
            this.SelectedN.Name = "SelectedN";
            this.SelectedN.Size = new System.Drawing.Size(0, 26);
            this.SelectedN.TabIndex = 4;
            // 
            // SelectedC
            // 
            this.SelectedC.AutoSize = true;
            this.SelectedC.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectedC.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.SelectedC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SelectedC.Location = new System.Drawing.Point(94, 383);
            this.SelectedC.Name = "SelectedC";
            this.SelectedC.Size = new System.Drawing.Size(0, 26);
            this.SelectedC.TabIndex = 3;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLabel7.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.gunaLabel7.ForeColor = System.Drawing.Color.White;
            this.gunaLabel7.Location = new System.Drawing.Point(323, 356);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(60, 26);
            this.gunaLabel7.TabIndex = 2;
            this.gunaLabel7.Text = "Noise";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLabel5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.White;
            this.gunaLabel5.Location = new System.Drawing.Point(94, 356);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(67, 26);
            this.gunaLabel5.TabIndex = 0;
            this.gunaLabel5.Text = "Cipher";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLabel2.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(158, 306);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(189, 22);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "Your Selection";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click_1);
            // 
            // Cloaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(824, 477);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.SelectedN);
            this.Controls.Add(this.CloakProgress);
            this.Controls.Add(this.SelectedC);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.Start);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cloaker";
            this.Text = "Cloaker";
            this.Load += new System.EventHandler(this.Cloaker_Load);
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2CheckBox Addnoise;
        private Guna.UI2.WinForms.Guna2ComboBox SelectNoise;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox cloakpath;
        private Guna.UI2.WinForms.Guna2Button Start;
        private Guna.UI2.WinForms.Guna2ProgressBar CloakProgress;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel Lsize;
        private Guna.UI.WinForms.GunaLabel Ltype;
        private Guna.UI.WinForms.GunaLabel Lname;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI.WinForms.GunaLabel SelectedN;
        private Guna.UI.WinForms.GunaLabel SelectedC;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI.WinForms.GunaLabel Lnoise;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI2.WinForms.Guna2ComboBox SelectCipher;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}