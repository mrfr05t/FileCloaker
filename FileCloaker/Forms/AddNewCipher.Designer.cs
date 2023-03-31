namespace FileCloaker
{
    partial class AddNewCipher
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
            this.CipherWords = new System.Windows.Forms.RichTextBox();
            this.CipherData = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddCipher = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.guna2GroupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CipherWords
            // 
            this.CipherWords.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CipherWords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CipherWords.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CipherWords.ForeColor = System.Drawing.SystemColors.Info;
            this.CipherWords.Location = new System.Drawing.Point(3, 3);
            this.CipherWords.Name = "CipherWords";
            this.CipherWords.Size = new System.Drawing.Size(765, 318);
            this.CipherWords.TabIndex = 0;
            this.CipherWords.Text = "";
            this.CipherWords.TextChanged += new System.EventHandler(this.CipherWords_TextChanged);
            // 
            // CipherData
            // 
            this.CipherData.BorderColor = System.Drawing.Color.IndianRed;
            this.CipherData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CipherData.DefaultText = "";
            this.CipherData.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CipherData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CipherData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CipherData.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CipherData.FillColor = System.Drawing.Color.Black;
            this.CipherData.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CipherData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CipherData.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CipherData.Location = new System.Drawing.Point(18, 389);
            this.CipherData.Name = "CipherData";
            this.CipherData.PasswordChar = '\0';
            this.CipherData.PlaceholderText = "";
            this.CipherData.SelectedText = "";
            this.CipherData.Size = new System.Drawing.Size(611, 36);
            this.CipherData.TabIndex = 1;
            // 
            // AddCipher
            // 
            this.AddCipher.BorderColor = System.Drawing.Color.IndianRed;
            this.AddCipher.BorderRadius = 2;
            this.AddCipher.BorderThickness = 1;
            this.AddCipher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddCipher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddCipher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddCipher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddCipher.FillColor = System.Drawing.Color.Black;
            this.AddCipher.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCipher.ForeColor = System.Drawing.Color.White;
            this.AddCipher.Location = new System.Drawing.Point(638, 389);
            this.AddCipher.Name = "AddCipher";
            this.AddCipher.Size = new System.Drawing.Size(151, 36);
            this.AddCipher.TabIndex = 2;
            this.AddCipher.Text = "Create Cipher";
            this.AddCipher.Click += new System.EventHandler(this.AddCipher_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(17, 357);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(93, 19);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Cipher Name";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GroupBox2.Controls.Add(this.panel1);
            this.guna2GroupBox2.Controls.Add(this.linkLabel1);
            this.guna2GroupBox2.Controls.Add(this.CipherData);
            this.guna2GroupBox2.Controls.Add(this.AddCipher);
            this.guna2GroupBox2.Controls.Add(this.gunaLabel1);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.IndianRed;
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox2.FillColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(12, 12);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(808, 444);
            this.guna2GroupBox2.TabIndex = 5;
            this.guna2GroupBox2.Text = "Create new cipher";
            this.guna2GroupBox2.TextOffset = new System.Drawing.Point(0, -3);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.CipherWords);
            this.panel1.Location = new System.Drawing.Point(18, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 324);
            this.panel1.TabIndex = 5;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(679, 20);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(110, 15);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "How to add cipher?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // AddNewCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(832, 477);
            this.Controls.Add(this.guna2GroupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewCipher";
            this.Text = "AddNewCipher";
            this.Load += new System.EventHandler(this.AddNewCipher_Load);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox CipherWords;
        private Guna.UI2.WinForms.Guna2TextBox CipherData;
        private Guna.UI2.WinForms.Guna2Button AddCipher;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
    }
}