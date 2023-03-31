namespace FileCloaker
{
    partial class Decloaker
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
            this.Lchipher = new Guna.UI.WinForms.GunaLabel();
            this.noiseyesno = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.DecloakPro = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.Start = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.AddedNoise = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Selectdecipher = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Lsize = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.Ltype = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.Lname = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.OpenFile = new Guna.UI2.WinForms.Guna2Button();
            this.FilePath = new Guna.UI2.WinForms.Guna2TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.guna2GroupBox3.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lchipher
            // 
            this.Lchipher.AutoSize = true;
            this.Lchipher.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lchipher.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lchipher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Lchipher.Location = new System.Drawing.Point(94, 383);
            this.Lchipher.Name = "Lchipher";
            this.Lchipher.Size = new System.Drawing.Size(0, 19);
            this.Lchipher.TabIndex = 8;
            // 
            // noiseyesno
            // 
            this.noiseyesno.AutoSize = true;
            this.noiseyesno.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.noiseyesno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noiseyesno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.noiseyesno.Location = new System.Drawing.Point(323, 383);
            this.noiseyesno.Name = "noiseyesno";
            this.noiseyesno.Size = new System.Drawing.Size(0, 19);
            this.noiseyesno.TabIndex = 7;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLabel7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // DecloakPro
            // 
            this.DecloakPro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DecloakPro.BorderRadius = 2;
            this.DecloakPro.BorderThickness = 1;
            this.DecloakPro.FillColor = System.Drawing.Color.Black;
            this.DecloakPro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecloakPro.ForeColor = System.Drawing.Color.White;
            this.DecloakPro.Location = new System.Drawing.Point(25, 428);
            this.DecloakPro.Name = "DecloakPro";
            this.DecloakPro.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DecloakPro.ProgressColor2 = System.Drawing.Color.Green;
            this.DecloakPro.ShowText = true;
            this.DecloakPro.Size = new System.Drawing.Size(776, 21);
            this.DecloakPro.TabIndex = 12;
            this.DecloakPro.Text = "guna2ProgressBar1";
            this.DecloakPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DecloakPro.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
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
            this.Start.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.Location = new System.Drawing.Point(604, 332);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(197, 61);
            this.Start.TabIndex = 8;
            this.Start.Text = "Start Decloaking";
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GroupBox3.BorderRadius = 2;
            this.guna2GroupBox3.Controls.Add(this.gunaLabel8);
            this.guna2GroupBox3.Controls.Add(this.AddedNoise);
            this.guna2GroupBox3.Controls.Add(this.Selectdecipher);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2GroupBox3.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox3.FillColor = System.Drawing.Color.Black;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox3.Location = new System.Drawing.Point(25, 168);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(776, 116);
            this.guna2GroupBox3.TabIndex = 11;
            this.guna2GroupBox3.Text = "Cipher Selection";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLabel8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.White;
            this.gunaLabel8.Location = new System.Drawing.Point(12, 32);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(94, 19);
            this.gunaLabel8.TabIndex = 3;
            this.gunaLabel8.Text = "Select Cipher";
            // 
            // AddedNoise
            // 
            this.AddedNoise.AutoSize = true;
            this.AddedNoise.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddedNoise.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddedNoise.CheckedState.BorderRadius = 0;
            this.AddedNoise.CheckedState.BorderThickness = 0;
            this.AddedNoise.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddedNoise.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddedNoise.ForeColor = System.Drawing.Color.White;
            this.AddedNoise.Location = new System.Drawing.Point(415, 63);
            this.AddedNoise.Name = "AddedNoise";
            this.AddedNoise.Size = new System.Drawing.Size(117, 23);
            this.AddedNoise.TabIndex = 2;
            this.AddedNoise.Text = "Added Noise?";
            this.AddedNoise.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AddedNoise.UncheckedState.BorderRadius = 0;
            this.AddedNoise.UncheckedState.BorderThickness = 0;
            this.AddedNoise.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AddedNoise.UseVisualStyleBackColor = false;
            this.AddedNoise.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // Selectdecipher
            // 
            this.Selectdecipher.BackColor = System.Drawing.Color.Black;
            this.Selectdecipher.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Selectdecipher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Selectdecipher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Selectdecipher.FillColor = System.Drawing.Color.Black;
            this.Selectdecipher.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Selectdecipher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Selectdecipher.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Selectdecipher.ForeColor = System.Drawing.Color.White;
            this.Selectdecipher.ItemHeight = 30;
            this.Selectdecipher.Location = new System.Drawing.Point(16, 63);
            this.Selectdecipher.Name = "Selectdecipher";
            this.Selectdecipher.Size = new System.Drawing.Size(334, 36);
            this.Selectdecipher.TabIndex = 0;
            this.Selectdecipher.SelectedIndexChanged += new System.EventHandler(this.Selectdecipher_SelectedIndexChanged);
            // 
            // Lsize
            // 
            this.Lsize.AutoSize = true;
            this.Lsize.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lsize.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lsize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Lsize.Location = new System.Drawing.Point(503, 88);
            this.Lsize.Name = "Lsize";
            this.Lsize.Size = new System.Drawing.Size(0, 19);
            this.Lsize.TabIndex = 11;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLabel4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(440, 88);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(65, 19);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "File Size:";
            // 
            // Ltype
            // 
            this.Ltype.AutoSize = true;
            this.Ltype.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ltype.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Ltype.Location = new System.Drawing.Point(348, 88);
            this.Ltype.Name = "Ltype";
            this.Ltype.Size = new System.Drawing.Size(0, 19);
            this.Ltype.TabIndex = 10;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLabel3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(280, 88);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(70, 19);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "File Type:";
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Lname.Location = new System.Drawing.Point(92, 88);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(0, 19);
            this.Lname.TabIndex = 8;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GroupBox1.BorderRadius = 2;
            this.guna2GroupBox1.Controls.Add(this.Lsize);
            this.guna2GroupBox1.Controls.Add(this.OpenFile);
            this.guna2GroupBox1.Controls.Add(this.gunaLabel4);
            this.guna2GroupBox1.Controls.Add(this.FilePath);
            this.guna2GroupBox1.Controls.Add(this.Ltype);
            this.guna2GroupBox1.Controls.Add(this.gunaLabel1);
            this.guna2GroupBox1.Controls.Add(this.gunaLabel3);
            this.guna2GroupBox1.Controls.Add(this.Lname);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(25, 26);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(776, 124);
            this.guna2GroupBox1.TabIndex = 9;
            this.guna2GroupBox1.Text = "File Selection";
            // 
            // OpenFile
            // 
            this.OpenFile.BackColor = System.Drawing.Color.Black;
            this.OpenFile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.OpenFile.BorderRadius = 2;
            this.OpenFile.BorderThickness = 1;
            this.OpenFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.OpenFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.OpenFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OpenFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.OpenFile.FillColor = System.Drawing.Color.Black;
            this.OpenFile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFile.ForeColor = System.Drawing.Color.White;
            this.OpenFile.Location = new System.Drawing.Point(626, 37);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(137, 36);
            this.OpenFile.TabIndex = 1;
            this.OpenFile.Text = "Select File";
            this.OpenFile.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // FilePath
            // 
            this.FilePath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FilePath.BorderRadius = 2;
            this.FilePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FilePath.DefaultText = "";
            this.FilePath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FilePath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FilePath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FilePath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FilePath.FillColor = System.Drawing.Color.Black;
            this.FilePath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FilePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FilePath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FilePath.Location = new System.Drawing.Point(16, 37);
            this.FilePath.Name = "FilePath";
            this.FilePath.PasswordChar = '\0';
            this.FilePath.PlaceholderText = "";
            this.FilePath.SelectedText = "";
            this.FilePath.Size = new System.Drawing.Size(595, 36);
            this.FilePath.TabIndex = 0;
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
            this.gunaLabel2.TabIndex = 13;
            this.gunaLabel2.Text = "Your Selection";
            // 
            // Decloaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(824, 477);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.noiseyesno);
            this.Controls.Add(this.Lchipher);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.DecloakPro);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.guna2GroupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Decloaker";
            this.Text = "Decloaker";
            this.Load += new System.EventHandler(this.Decloaker_Load);
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI2.WinForms.Guna2ProgressBar DecloakPro;
        private Guna.UI2.WinForms.Guna2Button Start;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2CheckBox AddedNoise;
        private Guna.UI2.WinForms.Guna2ComboBox Selectdecipher;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button OpenFile;
        private Guna.UI2.WinForms.Guna2TextBox FilePath;
        private Guna.UI.WinForms.GunaLabel Lsize;
        private Guna.UI.WinForms.GunaLabel Ltype;
        private Guna.UI.WinForms.GunaLabel Lname;
        private Guna.UI.WinForms.GunaLabel noiseyesno;
        private Guna.UI.WinForms.GunaLabel Lchipher;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}