namespace WindowsFormsApp1
{
    partial class Form6
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_EXIT = new System.Windows.Forms.Label();
            this.lbl_logout = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Txt_billid = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_buillId = new System.Windows.Forms.Label();
            this.lbl_amount1 = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.lbl_selle = new System.Windows.Forms.Label();
            this.grd_selllist = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_refresh = new Guna.UI2.WinForms.Guna2Button();
            this.cmb_cate = new System.Windows.Forms.ComboBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_nam = new System.Windows.Forms.Label();
            this.grd_product = new Guna.UI2.WinForms.Guna2DataGridView();
            this.grd_oder = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_add1 = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_print = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.Text_quantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.Text_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.Text_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_selllist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_oder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(47)))), ((int)(((byte)(201)))));
            this.panel1.Controls.Add(this.label_EXIT);
            this.panel1.Controls.Add(this.lbl_logout);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 653);
            this.panel1.TabIndex = 2;
            // 
            // label_EXIT
            // 
            this.label_EXIT.AutoSize = true;
            this.label_EXIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(47)))), ((int)(((byte)(201)))));
            this.label_EXIT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EXIT.ForeColor = System.Drawing.Color.Black;
            this.label_EXIT.Location = new System.Drawing.Point(1077, 3);
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
            this.lbl_title.Font = new System.Drawing.Font("Sitka Display", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(508, 17);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(131, 42);
            this.lbl_title.TabIndex = 16;
            this.lbl_title.Text = "SELLING";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(119)))), ((int)(((byte)(175)))));
            this.panel2.Controls.Add(this.Txt_billid);
            this.panel2.Controls.Add(this.lbl_buillId);
            this.panel2.Controls.Add(this.lbl_amount1);
            this.panel2.Controls.Add(this.lbl_amount);
            this.panel2.Controls.Add(this.lbl_selle);
            this.panel2.Controls.Add(this.grd_selllist);
            this.panel2.Controls.Add(this.btn_refresh);
            this.panel2.Controls.Add(this.cmb_cate);
            this.panel2.Controls.Add(this.lbl_date);
            this.panel2.Controls.Add(this.lbl_nam);
            this.panel2.Controls.Add(this.grd_product);
            this.panel2.Controls.Add(this.grd_oder);
            this.panel2.Controls.Add(this.Btn_add1);
            this.panel2.Controls.Add(this.Btn_print);
            this.panel2.Controls.Add(this.Btn_add);
            this.panel2.Controls.Add(this.Text_quantity);
            this.panel2.Controls.Add(this.Text_price);
            this.panel2.Controls.Add(this.Text_name);
            this.panel2.Controls.Add(this.lbl_quantity);
            this.panel2.Controls.Add(this.lbl_price);
            this.panel2.Controls.Add(this.lbl_name);
            this.panel2.Location = new System.Drawing.Point(136, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 561);
            this.panel2.TabIndex = 0;
            // 
            // Txt_billid
            // 
            this.Txt_billid.BorderRadius = 18;
            this.Txt_billid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_billid.DefaultText = "";
            this.Txt_billid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_billid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_billid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_billid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_billid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_billid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txt_billid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_billid.Location = new System.Drawing.Point(748, 280);
            this.Txt_billid.Name = "Txt_billid";
            this.Txt_billid.PasswordChar = '\0';
            this.Txt_billid.PlaceholderText = "";
            this.Txt_billid.SelectedText = "";
            this.Txt_billid.Size = new System.Drawing.Size(103, 33);
            this.Txt_billid.TabIndex = 24;
            // 
            // lbl_buillId
            // 
            this.lbl_buillId.AutoSize = true;
            this.lbl_buillId.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buillId.Location = new System.Drawing.Point(665, 281);
            this.lbl_buillId.Name = "lbl_buillId";
            this.lbl_buillId.Size = new System.Drawing.Size(67, 30);
            this.lbl_buillId.TabIndex = 23;
            this.lbl_buillId.Text = "BuillId";
            // 
            // lbl_amount1
            // 
            this.lbl_amount1.AutoSize = true;
            this.lbl_amount1.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount1.Location = new System.Drawing.Point(732, 216);
            this.lbl_amount1.Name = "lbl_amount1";
            this.lbl_amount1.Size = new System.Drawing.Size(38, 30);
            this.lbl_amount1.TabIndex = 22;
            this.lbl_amount1.Text = "Rs ";
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.Location = new System.Drawing.Point(636, 216);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(91, 30);
            this.lbl_amount.TabIndex = 21;
            this.lbl_amount.Text = "Amount :";
            // 
            // lbl_selle
            // 
            this.lbl_selle.AutoSize = true;
            this.lbl_selle.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selle.Location = new System.Drawing.Point(341, 283);
            this.lbl_selle.Name = "lbl_selle";
            this.lbl_selle.Size = new System.Drawing.Size(85, 30);
            this.lbl_selle.TabIndex = 20;
            this.lbl_selle.Text = "Sells List";
            // 
            // grd_selllist
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.grd_selllist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_selllist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.grd_selllist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_selllist.DefaultCellStyle = dataGridViewCellStyle21;
            this.grd_selllist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grd_selllist.Location = new System.Drawing.Point(346, 323);
            this.grd_selllist.Name = "grd_selllist";
            this.grd_selllist.RowHeadersVisible = false;
            this.grd_selllist.Size = new System.Drawing.Size(591, 193);
            this.grd_selllist.TabIndex = 19;
            this.grd_selllist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grd_selllist.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grd_selllist.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grd_selllist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grd_selllist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grd_selllist.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grd_selllist.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grd_selllist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grd_selllist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grd_selllist.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_selllist.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grd_selllist.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grd_selllist.ThemeStyle.HeaderStyle.Height = 23;
            this.grd_selllist.ThemeStyle.ReadOnly = false;
            this.grd_selllist.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grd_selllist.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grd_selllist.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_selllist.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grd_selllist.ThemeStyle.RowsStyle.Height = 22;
            this.grd_selllist.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grd_selllist.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btn_refresh
            // 
            this.btn_refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_refresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(119)))), ((int)(((byte)(175)))));
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_refresh.Location = new System.Drawing.Point(216, 284);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(102, 33);
            this.btn_refresh.TabIndex = 18;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // cmb_cate
            // 
            this.cmb_cate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cate.FormattingEnabled = true;
            this.cmb_cate.Location = new System.Drawing.Point(29, 284);
            this.cmb_cate.Name = "cmb_cate";
            this.cmb_cate.Size = new System.Drawing.Size(180, 33);
            this.cmb_cate.TabIndex = 17;
            this.cmb_cate.Text = "Select Category";
            this.cmb_cate.SelectionChangeCommitted += new System.EventHandler(this.cmb_cate_SelectionChangeCommitted);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(733, 2);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(61, 30);
            this.lbl_date.TabIndex = 16;
            this.lbl_date.Text = "Date :";
            // 
            // lbl_nam
            // 
            this.lbl_nam.AutoSize = true;
            this.lbl_nam.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nam.Location = new System.Drawing.Point(38, 2);
            this.lbl_nam.Name = "lbl_nam";
            this.lbl_nam.Size = new System.Drawing.Size(113, 30);
            this.lbl_nam.TabIndex = 15;
            this.lbl_nam.Text = "Seller Name";
            // 
            // grd_product
            // 
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.grd_product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_product.DefaultCellStyle = dataGridViewCellStyle24;
            this.grd_product.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grd_product.Location = new System.Drawing.Point(29, 323);
            this.grd_product.Name = "grd_product";
            this.grd_product.RowHeadersVisible = false;
            this.grd_product.Size = new System.Drawing.Size(281, 216);
            this.grd_product.TabIndex = 14;
            this.grd_product.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grd_product.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grd_product.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grd_product.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grd_product.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grd_product.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grd_product.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grd_product.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grd_product.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grd_product.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_product.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grd_product.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grd_product.ThemeStyle.HeaderStyle.Height = 23;
            this.grd_product.ThemeStyle.ReadOnly = false;
            this.grd_product.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grd_product.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grd_product.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_product.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grd_product.ThemeStyle.RowsStyle.Height = 22;
            this.grd_product.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grd_product.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grd_product.Click += new System.EventHandler(this.grd_product_Click);
            // 
            // grd_oder
            // 
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            this.grd_oder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_oder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.grd_oder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grd_oder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdId,
            this.ProdName,
            this.ProdPrice,
            this.ProdQty,
            this.Total});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_oder.DefaultCellStyle = dataGridViewCellStyle27;
            this.grd_oder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grd_oder.Location = new System.Drawing.Point(346, 36);
            this.grd_oder.Name = "grd_oder";
            this.grd_oder.RowHeadersVisible = false;
            this.grd_oder.Size = new System.Drawing.Size(591, 176);
            this.grd_oder.TabIndex = 13;
            this.grd_oder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grd_oder.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grd_oder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grd_oder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grd_oder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grd_oder.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grd_oder.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grd_oder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grd_oder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grd_oder.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_oder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grd_oder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grd_oder.ThemeStyle.HeaderStyle.Height = 23;
            this.grd_oder.ThemeStyle.ReadOnly = false;
            this.grd_oder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grd_oder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grd_oder.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_oder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grd_oder.ThemeStyle.RowsStyle.Height = 22;
            this.grd_oder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grd_oder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ProdId
            // 
            this.ProdId.HeaderText = "ProdId";
            this.ProdId.Name = "ProdId";
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "ProdName";
            this.ProdName.Name = "ProdName";
            // 
            // ProdPrice
            // 
            this.ProdPrice.HeaderText = "ProdPrice";
            this.ProdPrice.Name = "ProdPrice";
            // 
            // ProdQty
            // 
            this.ProdQty.HeaderText = "ProdQty";
            this.ProdQty.Name = "ProdQty";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // Btn_add1
            // 
            this.Btn_add1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_add1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_add1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_add1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_add1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(119)))), ((int)(((byte)(175)))));
            this.Btn_add1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_add1.ForeColor = System.Drawing.Color.Black;
            this.Btn_add1.Location = new System.Drawing.Point(857, 273);
            this.Btn_add1.Name = "Btn_add1";
            this.Btn_add1.Size = new System.Drawing.Size(80, 40);
            this.Btn_add1.TabIndex = 10;
            this.Btn_add1.Text = "Add";
            this.Btn_add1.Click += new System.EventHandler(this.Btn_add1_Click);
            // 
            // Btn_print
            // 
            this.Btn_print.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_print.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_print.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_print.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_print.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(119)))), ((int)(((byte)(175)))));
            this.Btn_print.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_print.ForeColor = System.Drawing.Color.Black;
            this.Btn_print.Location = new System.Drawing.Point(844, 522);
            this.Btn_print.Name = "Btn_print";
            this.Btn_print.Size = new System.Drawing.Size(99, 33);
            this.Btn_print.TabIndex = 9;
            this.Btn_print.Text = "Print";
            this.Btn_print.Click += new System.EventHandler(this.Btn_print_Click);
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
            this.Btn_add.Location = new System.Drawing.Point(132, 180);
            this.Btn_add.Name = "Btn_add";
            this.Btn_add.Size = new System.Drawing.Size(128, 45);
            this.Btn_add.TabIndex = 8;
            this.Btn_add.Text = "Add Order";
            this.Btn_add.Click += new System.EventHandler(this.Btn_add_Click);
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
            this.Text_quantity.Location = new System.Drawing.Point(132, 138);
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
            this.Text_price.Location = new System.Drawing.Point(132, 93);
            this.Text_price.Name = "Text_price";
            this.Text_price.PasswordChar = '\0';
            this.Text_price.PlaceholderText = "";
            this.Text_price.ReadOnly = true;
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
            this.Text_name.Location = new System.Drawing.Point(132, 47);
            this.Text_name.Name = "Text_name";
            this.Text_name.PasswordChar = '\0';
            this.Text_name.PlaceholderText = "";
            this.Text_name.SelectedText = "";
            this.Text_name.Size = new System.Drawing.Size(200, 36);
            this.Text_name.TabIndex = 5;
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.Location = new System.Drawing.Point(34, 141);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(83, 30);
            this.lbl_quantity.TabIndex = 3;
            this.lbl_quantity.Text = "Quantity";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(34, 96);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(54, 30);
            this.lbl_price.TabIndex = 2;
            this.lbl_price.Text = "Price";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(34, 50);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(62, 30);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_selllist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_oder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_EXIT;
        private System.Windows.Forms.Label lbl_logout;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmb_cate;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_nam;
        private Guna.UI2.WinForms.Guna2DataGridView grd_product;
        private Guna.UI2.WinForms.Guna2DataGridView grd_oder;
        private Guna.UI2.WinForms.Guna2Button Btn_add1;
        private Guna.UI2.WinForms.Guna2Button Btn_print;
        private Guna.UI2.WinForms.Guna2Button Btn_add;
        private Guna.UI2.WinForms.Guna2TextBox Text_quantity;
        private Guna.UI2.WinForms.Guna2TextBox Text_price;
        private Guna.UI2.WinForms.Guna2TextBox Text_name;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_name;
        private Guna.UI2.WinForms.Guna2Button btn_refresh;
        private System.Windows.Forms.Label lbl_amount1;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label lbl_selle;
        private Guna.UI2.WinForms.Guna2DataGridView grd_selllist;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private Guna.UI2.WinForms.Guna2TextBox Txt_billid;
        private System.Windows.Forms.Label lbl_buillId;
    }
}