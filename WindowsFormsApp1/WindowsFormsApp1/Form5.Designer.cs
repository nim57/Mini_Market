namespace WindowsFormsApp1
{
    partial class Form5
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_EXIT = new System.Windows.Forms.Label();
            this.lbl_logout = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.Btn_selling = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_category = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Product = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Text_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.GRD_Seller = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_update = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.Text_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.Text_age = new Guna.UI2.WinForms.Guna2TextBox();
            this.Text_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.Text_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_phoone = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.labe_sname = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRD_Seller)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(47)))), ((int)(((byte)(201)))));
            this.panel1.Controls.Add(this.label_EXIT);
            this.panel1.Controls.Add(this.lbl_logout);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Controls.Add(this.Btn_selling);
            this.panel1.Controls.Add(this.Btn_category);
            this.panel1.Controls.Add(this.Btn_Product);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 650);
            this.panel1.TabIndex = 1;
            // 
            // label_EXIT
            // 
            this.label_EXIT.AutoSize = true;
            this.label_EXIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(47)))), ((int)(((byte)(201)))));
            this.label_EXIT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EXIT.ForeColor = System.Drawing.Color.Black;
            this.label_EXIT.Location = new System.Drawing.Point(1061, 24);
            this.label_EXIT.Name = "label_EXIT";
            this.label_EXIT.Size = new System.Drawing.Size(24, 25);
            this.label_EXIT.TabIndex = 17;
            this.label_EXIT.Text = "X";
            this.label_EXIT.Click += new System.EventHandler(this.label_EXIT_Click);
            this.label_EXIT.MouseEnter += new System.EventHandler(this.label_EXIT_MouseEnter);
            this.label_EXIT.MouseLeave += new System.EventHandler(this.label_EXIT_MouseLeave);
            // 
            // lbl_logout
            // 
            this.lbl_logout.AutoSize = true;
            this.lbl_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(47)))), ((int)(((byte)(201)))));
            this.lbl_logout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logout.ForeColor = System.Drawing.Color.Black;
            this.lbl_logout.Location = new System.Drawing.Point(27, 600);
            this.lbl_logout.Name = "lbl_logout";
            this.lbl_logout.Size = new System.Drawing.Size(77, 25);
            this.lbl_logout.TabIndex = 18;
            this.lbl_logout.Text = "Logout";
            this.lbl_logout.Click += new System.EventHandler(this.lbl_logout_Click);
            this.lbl_logout.MouseEnter += new System.EventHandler(this.lbl_logout_MouseEnter);
            this.lbl_logout.MouseLeave += new System.EventHandler(this.lbl_logout_MouseLeave);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(505, 26);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(197, 35);
            this.lbl_title.TabIndex = 16;
            this.lbl_title.Text = "MANAGE SELLER";
            // 
            // Btn_selling
            // 
            this.Btn_selling.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_selling.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_selling.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_selling.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_selling.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(47)))), ((int)(((byte)(201)))));
            this.Btn_selling.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_selling.ForeColor = System.Drawing.Color.Black;
            this.Btn_selling.Location = new System.Drawing.Point(3, 179);
            this.Btn_selling.Name = "Btn_selling";
            this.Btn_selling.Size = new System.Drawing.Size(101, 45);
            this.Btn_selling.TabIndex = 13;
            this.Btn_selling.Text = "Selling";
            this.Btn_selling.Click += new System.EventHandler(this.Btn_selling_Click);
            // 
            // Btn_category
            // 
            this.Btn_category.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_category.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_category.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_category.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_category.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(47)))), ((int)(((byte)(201)))));
            this.Btn_category.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_category.ForeColor = System.Drawing.Color.Black;
            this.Btn_category.Location = new System.Drawing.Point(3, 120);
            this.Btn_category.Name = "Btn_category";
            this.Btn_category.Size = new System.Drawing.Size(121, 45);
            this.Btn_category.TabIndex = 12;
            this.Btn_category.Text = "Category";
            this.Btn_category.Click += new System.EventHandler(this.Btn_category_Click);
            // 
            // Btn_Product
            // 
            this.Btn_Product.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Product.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Product.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Product.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Product.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(47)))), ((int)(((byte)(201)))));
            this.Btn_Product.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Product.ForeColor = System.Drawing.Color.Black;
            this.Btn_Product.Location = new System.Drawing.Point(3, 61);
            this.Btn_Product.Name = "Btn_Product";
            this.Btn_Product.Size = new System.Drawing.Size(109, 45);
            this.Btn_Product.TabIndex = 11;
            this.Btn_Product.Text = "Product";
            this.Btn_Product.Click += new System.EventHandler(this.Btn_Product_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(119)))), ((int)(((byte)(175)))));
            this.panel2.Controls.Add(this.Text_pass);
            this.panel2.Controls.Add(this.lbl_password);
            this.panel2.Controls.Add(this.GRD_Seller);
            this.panel2.Controls.Add(this.Btn_delete);
            this.panel2.Controls.Add(this.Btn_update);
            this.panel2.Controls.Add(this.Btn_add);
            this.panel2.Controls.Add(this.Text_phone);
            this.panel2.Controls.Add(this.Text_age);
            this.panel2.Controls.Add(this.Text_name);
            this.panel2.Controls.Add(this.Text_id);
            this.panel2.Controls.Add(this.lbl_phoone);
            this.panel2.Controls.Add(this.lbl_age);
            this.panel2.Controls.Add(this.labe_sname);
            this.panel2.Controls.Add(this.lbl_name);
            this.panel2.Location = new System.Drawing.Point(136, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 561);
            this.panel2.TabIndex = 0;
            // 
            // Text_pass
            // 
            this.Text_pass.BorderRadius = 18;
            this.Text_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_pass.DefaultText = "";
            this.Text_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Text_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Text_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text_pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Text_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text_pass.Location = new System.Drawing.Point(132, 283);
            this.Text_pass.Name = "Text_pass";
            this.Text_pass.PasswordChar = '●';
            this.Text_pass.PlaceholderText = "";
            this.Text_pass.SelectedText = "";
            this.Text_pass.Size = new System.Drawing.Size(200, 36);
            this.Text_pass.TabIndex = 15;
            this.Text_pass.UseSystemPasswordChar = true;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(38, 286);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(92, 30);
            this.lbl_password.TabIndex = 14;
            this.lbl_password.Text = "Password";
            // 
            // GRD_Seller
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.GRD_Seller.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRD_Seller.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.GRD_Seller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRD_Seller.DefaultCellStyle = dataGridViewCellStyle6;
            this.GRD_Seller.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GRD_Seller.Location = new System.Drawing.Point(346, 58);
            this.GRD_Seller.Name = "GRD_Seller";
            this.GRD_Seller.RowHeadersVisible = false;
            this.GRD_Seller.Size = new System.Drawing.Size(591, 489);
            this.GRD_Seller.TabIndex = 13;
            this.GRD_Seller.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GRD_Seller.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GRD_Seller.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GRD_Seller.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GRD_Seller.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GRD_Seller.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GRD_Seller.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GRD_Seller.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GRD_Seller.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GRD_Seller.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRD_Seller.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GRD_Seller.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GRD_Seller.ThemeStyle.HeaderStyle.Height = 23;
            this.GRD_Seller.ThemeStyle.ReadOnly = false;
            this.GRD_Seller.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GRD_Seller.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GRD_Seller.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRD_Seller.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GRD_Seller.ThemeStyle.RowsStyle.Height = 22;
            this.GRD_Seller.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GRD_Seller.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GRD_Seller.Click += new System.EventHandler(this.GRD_Seller_Click);
            // 
            // Btn_delete
            // 
            this.Btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(119)))), ((int)(((byte)(175)))));
            this.Btn_delete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_delete.ForeColor = System.Drawing.Color.Black;
            this.Btn_delete.Location = new System.Drawing.Point(245, 347);
            this.Btn_delete.Name = "Btn_delete";
            this.Btn_delete.Size = new System.Drawing.Size(95, 45);
            this.Btn_delete.TabIndex = 10;
            this.Btn_delete.Text = "Delete";
            this.Btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // Btn_update
            // 
            this.Btn_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(119)))), ((int)(((byte)(175)))));
            this.Btn_update.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_update.ForeColor = System.Drawing.Color.Black;
            this.Btn_update.Location = new System.Drawing.Point(126, 347);
            this.Btn_update.Name = "Btn_update";
            this.Btn_update.Size = new System.Drawing.Size(99, 45);
            this.Btn_update.TabIndex = 9;
            this.Btn_update.Text = "Update";
            this.Btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // Btn_add
            // 
            this.Btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(119)))), ((int)(((byte)(175)))));
            this.Btn_add.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_add.ForeColor = System.Drawing.Color.Black;
            this.Btn_add.Location = new System.Drawing.Point(34, 347);
            this.Btn_add.Name = "Btn_add";
            this.Btn_add.Size = new System.Drawing.Size(72, 45);
            this.Btn_add.TabIndex = 8;
            this.Btn_add.Text = "Add";
            this.Btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // Text_phone
            // 
            this.Text_phone.BorderRadius = 18;
            this.Text_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_phone.DefaultText = "";
            this.Text_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Text_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Text_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text_phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Text_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text_phone.Location = new System.Drawing.Point(132, 226);
            this.Text_phone.Name = "Text_phone";
            this.Text_phone.PasswordChar = '\0';
            this.Text_phone.PlaceholderText = "";
            this.Text_phone.SelectedText = "";
            this.Text_phone.Size = new System.Drawing.Size(200, 36);
            this.Text_phone.TabIndex = 7;
            // 
            // Text_age
            // 
            this.Text_age.BorderRadius = 18;
            this.Text_age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_age.DefaultText = "";
            this.Text_age.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Text_age.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Text_age.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text_age.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text_age.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text_age.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Text_age.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text_age.Location = new System.Drawing.Point(132, 170);
            this.Text_age.Name = "Text_age";
            this.Text_age.PasswordChar = '\0';
            this.Text_age.PlaceholderText = "";
            this.Text_age.SelectedText = "";
            this.Text_age.Size = new System.Drawing.Size(200, 36);
            this.Text_age.TabIndex = 6;
            // 
            // Text_name
            // 
            this.Text_name.BorderRadius = 18;
            this.Text_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_name.DefaultText = "";
            this.Text_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Text_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Text_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Text_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text_name.Location = new System.Drawing.Point(132, 114);
            this.Text_name.Name = "Text_name";
            this.Text_name.PasswordChar = '\0';
            this.Text_name.PlaceholderText = "";
            this.Text_name.SelectedText = "";
            this.Text_name.Size = new System.Drawing.Size(200, 36);
            this.Text_name.TabIndex = 5;
            // 
            // Text_id
            // 
            this.Text_id.BorderRadius = 18;
            this.Text_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_id.DefaultText = "";
            this.Text_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Text_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Text_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Text_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text_id.Location = new System.Drawing.Point(132, 58);
            this.Text_id.Name = "Text_id";
            this.Text_id.PasswordChar = '\0';
            this.Text_id.PlaceholderText = "";
            this.Text_id.SelectedText = "";
            this.Text_id.Size = new System.Drawing.Size(200, 36);
            this.Text_id.TabIndex = 1;
            // 
            // lbl_phoone
            // 
            this.lbl_phoone.AutoSize = true;
            this.lbl_phoone.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phoone.Location = new System.Drawing.Point(38, 229);
            this.lbl_phoone.Name = "lbl_phoone";
            this.lbl_phoone.Size = new System.Drawing.Size(94, 30);
            this.lbl_phoone.TabIndex = 3;
            this.lbl_phoone.Text = "Phone No";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_age.Location = new System.Drawing.Point(38, 173);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(44, 30);
            this.lbl_age.TabIndex = 2;
            this.lbl_age.Text = "Age";
            // 
            // labe_sname
            // 
            this.labe_sname.AutoSize = true;
            this.labe_sname.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe_sname.Location = new System.Drawing.Point(38, 117);
            this.labe_sname.Name = "labe_sname";
            this.labe_sname.Size = new System.Drawing.Size(62, 30);
            this.labe_sname.TabIndex = 1;
            this.labe_sname.Text = "Name";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(38, 61);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(32, 30);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "ID";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRD_Seller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_logout;
        private System.Windows.Forms.Label lbl_title;
        private Guna.UI2.WinForms.Guna2Button Btn_selling;
        private Guna.UI2.WinForms.Guna2Button Btn_category;
        private Guna.UI2.WinForms.Guna2Button Btn_Product;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox Text_pass;
        private System.Windows.Forms.Label lbl_password;
        private Guna.UI2.WinForms.Guna2DataGridView GRD_Seller;
        private Guna.UI2.WinForms.Guna2Button Btn_delete;
        private Guna.UI2.WinForms.Guna2Button Btn_update;
        private Guna.UI2.WinForms.Guna2Button Btn_add;
        private Guna.UI2.WinForms.Guna2TextBox Text_phone;
        private Guna.UI2.WinForms.Guna2TextBox Text_age;
        private Guna.UI2.WinForms.Guna2TextBox Text_name;
        private Guna.UI2.WinForms.Guna2TextBox Text_id;
        private System.Windows.Forms.Label lbl_phoone;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label labe_sname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label_EXIT;
    }
}