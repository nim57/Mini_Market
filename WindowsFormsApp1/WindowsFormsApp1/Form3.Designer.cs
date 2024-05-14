namespace WindowsFormsApp1
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_logout = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_selling = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_category = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_seller = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GRD_Mange = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmb_refresh = new System.Windows.Forms.ComboBox();
            this.Btn_refresh = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_update = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.Text_quantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.Text_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.Text_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.Text_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_EXIT = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRD_Mange)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(47)))), ((int)(((byte)(201)))));
            this.panel1.Controls.Add(this.lbl_logout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btn_selling);
            this.panel1.Controls.Add(this.Btn_category);
            this.panel1.Controls.Add(this.Btn_seller);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 660);
            this.panel1.TabIndex = 0;
            // 
            // lbl_logout
            // 
            this.lbl_logout.AutoSize = true;
            this.lbl_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(47)))), ((int)(((byte)(201)))));
            this.lbl_logout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logout.ForeColor = System.Drawing.Color.Black;
            this.lbl_logout.Location = new System.Drawing.Point(27, 609);
            this.lbl_logout.Name = "lbl_logout";
            this.lbl_logout.Size = new System.Drawing.Size(77, 25);
            this.lbl_logout.TabIndex = 18;
            this.lbl_logout.Text = "Logout";
            this.lbl_logout.Click += new System.EventHandler(this.lbl_logout_Click);
            this.lbl_logout.MouseEnter += new System.EventHandler(this.lbl_logout_MouseEnter);
            this.lbl_logout.MouseLeave += new System.EventHandler(this.lbl_logout_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(505, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "MANAGE PRODUCTS";
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
            this.Btn_selling.Location = new System.Drawing.Point(9, 181);
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
            this.Btn_category.Location = new System.Drawing.Point(9, 121);
            this.Btn_category.Name = "Btn_category";
            this.Btn_category.Size = new System.Drawing.Size(121, 45);
            this.Btn_category.TabIndex = 12;
            this.Btn_category.Text = "Category";
            this.Btn_category.Click += new System.EventHandler(this.Button_category_Click);
            // 
            // Btn_seller
            // 
            this.Btn_seller.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_seller.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_seller.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_seller.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_seller.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(47)))), ((int)(((byte)(201)))));
            this.Btn_seller.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_seller.ForeColor = System.Drawing.Color.Black;
            this.Btn_seller.Location = new System.Drawing.Point(9, 61);
            this.Btn_seller.Name = "Btn_seller";
            this.Btn_seller.Size = new System.Drawing.Size(95, 45);
            this.Btn_seller.TabIndex = 11;
            this.Btn_seller.Text = "Seller";
            this.Btn_seller.Click += new System.EventHandler(this.Btn_seller_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(119)))), ((int)(((byte)(175)))));
            this.panel2.Controls.Add(this.GRD_Mange);
            this.panel2.Controls.Add(this.cmb_refresh);
            this.panel2.Controls.Add(this.Btn_refresh);
            this.panel2.Controls.Add(this.Btn_delete);
            this.panel2.Controls.Add(this.Btn_update);
            this.panel2.Controls.Add(this.Btn_add);
            this.panel2.Controls.Add(this.cmb_category);
            this.panel2.Controls.Add(this.Text_quantity);
            this.panel2.Controls.Add(this.Text_price);
            this.panel2.Controls.Add(this.Text_name);
            this.panel2.Controls.Add(this.Text_id);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(136, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 586);
            this.panel2.TabIndex = 0;
            // 
            // GRD_Mange
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.GRD_Mange.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRD_Mange.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GRD_Mange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRD_Mange.DefaultCellStyle = dataGridViewCellStyle3;
            this.GRD_Mange.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GRD_Mange.Location = new System.Drawing.Point(347, 68);
            this.GRD_Mange.Name = "GRD_Mange";
            this.GRD_Mange.RowHeadersVisible = false;
            this.GRD_Mange.Size = new System.Drawing.Size(594, 506);
            this.GRD_Mange.TabIndex = 13;
            this.GRD_Mange.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GRD_Mange.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GRD_Mange.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GRD_Mange.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GRD_Mange.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GRD_Mange.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GRD_Mange.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GRD_Mange.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GRD_Mange.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GRD_Mange.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRD_Mange.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GRD_Mange.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GRD_Mange.ThemeStyle.HeaderStyle.Height = 23;
            this.GRD_Mange.ThemeStyle.ReadOnly = false;
            this.GRD_Mange.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GRD_Mange.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GRD_Mange.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRD_Mange.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GRD_Mange.ThemeStyle.RowsStyle.Height = 22;
            this.GRD_Mange.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GRD_Mange.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GRD_Mange.Click += new System.EventHandler(this.GRD_Mange_Click_1);
            // 
            // cmb_refresh
            // 
            this.cmb_refresh.FormattingEnabled = true;
            this.cmb_refresh.Location = new System.Drawing.Point(464, 31);
            this.cmb_refresh.Name = "cmb_refresh";
            this.cmb_refresh.Size = new System.Drawing.Size(200, 31);
            this.cmb_refresh.TabIndex = 12;
            this.cmb_refresh.Text = "Select Cotegory";
            this.cmb_refresh.SelectionChangeCommitted += new System.EventHandler(this.cmb_refresh_SelectionChangeCommitted);
            // 
            // Btn_refresh
            // 
            this.Btn_refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_refresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(119)))), ((int)(((byte)(175)))));
            this.Btn_refresh.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_refresh.ForeColor = System.Drawing.Color.Black;
            this.Btn_refresh.Location = new System.Drawing.Point(666, 31);
            this.Btn_refresh.Name = "Btn_refresh";
            this.Btn_refresh.Size = new System.Drawing.Size(117, 31);
            this.Btn_refresh.TabIndex = 11;
            this.Btn_refresh.Text = "Refresh";
            this.Btn_refresh.Click += new System.EventHandler(this.Btn_refresh_Click);
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
            // cmb_category
            // 
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(132, 282);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(200, 31);
            this.cmb_category.TabIndex = 1;
            this.cmb_category.Text = "Select Category";
            // 
            // Text_quantity
            // 
            this.Text_quantity.BorderRadius = 18;
            this.Text_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_quantity.DefaultText = "";
            this.Text_quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Text_quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Text_quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text_quantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text_quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text_quantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Text_quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text_quantity.Location = new System.Drawing.Point(132, 226);
            this.Text_quantity.Name = "Text_quantity";
            this.Text_quantity.PasswordChar = '\0';
            this.Text_quantity.PlaceholderText = "";
            this.Text_quantity.SelectedText = "";
            this.Text_quantity.Size = new System.Drawing.Size(200, 36);
            this.Text_quantity.TabIndex = 7;
            // 
            // Text_price
            // 
            this.Text_price.BorderRadius = 18;
            this.Text_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_price.DefaultText = "";
            this.Text_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Text_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Text_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text_price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Text_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text_price.Location = new System.Drawing.Point(132, 170);
            this.Text_price.Name = "Text_price";
            this.Text_price.PasswordChar = '\0';
            this.Text_price.PlaceholderText = "";
            this.Text_price.SelectedText = "";
            this.Text_price.Size = new System.Drawing.Size(200, 36);
            this.Text_price.TabIndex = 6;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 30);
            this.label6.TabIndex = 4;
            this.label6.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // label_EXIT
            // 
            this.label_EXIT.AutoSize = true;
            this.label_EXIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(47)))), ((int)(((byte)(201)))));
            this.label_EXIT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EXIT.ForeColor = System.Drawing.Color.Black;
            this.label_EXIT.Location = new System.Drawing.Point(1075, 1);
            this.label_EXIT.Name = "label_EXIT";
            this.label_EXIT.Size = new System.Drawing.Size(24, 25);
            this.label_EXIT.TabIndex = 10;
            this.label_EXIT.Text = "X";
            this.label_EXIT.Click += new System.EventHandler(this.label_EXIT_Click);
            this.label_EXIT.MouseEnter += new System.EventHandler(this.label_EXIT_MouseEnter);
            this.label_EXIT.MouseLeave += new System.EventHandler(this.label_EXIT_MouseLeave);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.label_EXIT);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRD_Mange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_EXIT;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox Text_quantity;
        private Guna.UI2.WinForms.Guna2TextBox Text_price;
        private Guna.UI2.WinForms.Guna2TextBox Text_name;
        private Guna.UI2.WinForms.Guna2TextBox Text_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_category;
        private Guna.UI2.WinForms.Guna2Button Btn_selling;
        private Guna.UI2.WinForms.Guna2Button Btn_category;
        private Guna.UI2.WinForms.Guna2Button Btn_seller;
        private Guna.UI2.WinForms.Guna2Button Btn_delete;
        private Guna.UI2.WinForms.Guna2Button Btn_update;
        private System.Windows.Forms.ComboBox cmb_refresh;
        private Guna.UI2.WinForms.Guna2Button Btn_refresh;
        private Guna.UI2.WinForms.Guna2Button Btn_add;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView GRD_Mange;
        private System.Windows.Forms.Label lbl_logout;
    }
}