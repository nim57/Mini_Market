namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_CLEAR = new System.Windows.Forms.Label();
            this.TextBox_USERNAME = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.TextBox_PASSWORD = new Guna.UI2.WinForms.Guna2TextBox();
            this.Button_LOGIN = new Guna.UI2.WinForms.Guna2Button();
            this.label_EXIT = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(680, 360);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(195, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(47, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "USERNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(47, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "PASSWORD";
            // 
            // label_CLEAR
            // 
            this.label_CLEAR.AutoSize = true;
            this.label_CLEAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_CLEAR.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CLEAR.ForeColor = System.Drawing.Color.White;
            this.label_CLEAR.Image = ((System.Drawing.Image)(resources.GetObject("label_CLEAR.Image")));
            this.label_CLEAR.Location = new System.Drawing.Point(346, 230);
            this.label_CLEAR.Name = "label_CLEAR";
            this.label_CLEAR.Size = new System.Drawing.Size(44, 20);
            this.label_CLEAR.TabIndex = 4;
            this.label_CLEAR.Text = "Clear";
            this.label_CLEAR.Click += new System.EventHandler(this.label_CLEAR_Click);
            this.label_CLEAR.MouseEnter += new System.EventHandler(this.label_CLEAR_MouseEnter);
            this.label_CLEAR.MouseLeave += new System.EventHandler(this.label_CLEAR_MouseLeave);
            // 
            // TextBox_USERNAME
            // 
            this.TextBox_USERNAME.BackColor = System.Drawing.Color.White;
            this.TextBox_USERNAME.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextBox_USERNAME.BackgroundImage")));
            this.TextBox_USERNAME.BorderRadius = 18;
            this.TextBox_USERNAME.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_USERNAME.DefaultText = "";
            this.TextBox_USERNAME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_USERNAME.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_USERNAME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_USERNAME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_USERNAME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_USERNAME.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_USERNAME.ForeColor = System.Drawing.Color.Black;
            this.TextBox_USERNAME.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_USERNAME.Location = new System.Drawing.Point(190, 126);
            this.TextBox_USERNAME.Name = "TextBox_USERNAME";
            this.TextBox_USERNAME.PasswordChar = '\0';
            this.TextBox_USERNAME.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TextBox_USERNAME.PlaceholderText = "";
            this.TextBox_USERNAME.SelectedText = "";
            this.TextBox_USERNAME.Size = new System.Drawing.Size(200, 33);
            this.TextBox_USERNAME.TabIndex = 5;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TextBox_PASSWORD
            // 
            this.TextBox_PASSWORD.BackColor = System.Drawing.Color.CadetBlue;
            this.TextBox_PASSWORD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextBox_PASSWORD.BackgroundImage")));
            this.TextBox_PASSWORD.BorderRadius = 18;
            this.TextBox_PASSWORD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_PASSWORD.DefaultText = "";
            this.TextBox_PASSWORD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_PASSWORD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_PASSWORD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_PASSWORD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_PASSWORD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_PASSWORD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_PASSWORD.ForeColor = System.Drawing.Color.Black;
            this.TextBox_PASSWORD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_PASSWORD.Location = new System.Drawing.Point(190, 175);
            this.TextBox_PASSWORD.Name = "TextBox_PASSWORD";
            this.TextBox_PASSWORD.PasswordChar = '●';
            this.TextBox_PASSWORD.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TextBox_PASSWORD.PlaceholderText = "";
            this.TextBox_PASSWORD.SelectedText = "";
            this.TextBox_PASSWORD.Size = new System.Drawing.Size(200, 33);
            this.TextBox_PASSWORD.TabIndex = 7;
            this.TextBox_PASSWORD.UseSystemPasswordChar = true;
            // 
            // Button_LOGIN
            // 
            this.Button_LOGIN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_LOGIN.BackgroundImage")));
            this.Button_LOGIN.BorderRadius = 18;
            this.Button_LOGIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_LOGIN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_LOGIN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_LOGIN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_LOGIN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_LOGIN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Button_LOGIN.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_LOGIN.ForeColor = System.Drawing.Color.White;
            this.Button_LOGIN.Location = new System.Drawing.Point(144, 257);
            this.Button_LOGIN.Name = "Button_LOGIN";
            this.Button_LOGIN.Size = new System.Drawing.Size(180, 45);
            this.Button_LOGIN.TabIndex = 8;
            this.Button_LOGIN.Text = "LOGIN";
            this.Button_LOGIN.Click += new System.EventHandler(this.Button_LOGIN_Click);
            // 
            // label_EXIT
            // 
            this.label_EXIT.AutoSize = true;
            this.label_EXIT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EXIT.ForeColor = System.Drawing.Color.White;
            this.label_EXIT.Image = ((System.Drawing.Image)(resources.GetObject("label_EXIT.Image")));
            this.label_EXIT.Location = new System.Drawing.Point(656, 0);
            this.label_EXIT.Name = "label_EXIT";
            this.label_EXIT.Size = new System.Drawing.Size(24, 25);
            this.label_EXIT.TabIndex = 9;
            this.label_EXIT.Text = "X";
            this.label_EXIT.Click += new System.EventHandler(this.label_EXIT_Click);
            this.label_EXIT.MouseEnter += new System.EventHandler(this.label_EXIT_MouseEnter);
            this.label_EXIT.MouseLeave += new System.EventHandler(this.label_EXIT_MouseLeave);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.comboBox1.Location = new System.Drawing.Point(190, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 23);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "Select Role";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 360);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_EXIT);
            this.Controls.Add(this.Button_LOGIN);
            this.Controls.Add(this.TextBox_PASSWORD);
            this.Controls.Add(this.TextBox_USERNAME);
            this.Controls.Add(this.label_CLEAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
           
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_CLEAR;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_USERNAME;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_PASSWORD;
        private Guna.UI2.WinForms.Guna2Button Button_LOGIN;
        private System.Windows.Forms.Label label_EXIT;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}