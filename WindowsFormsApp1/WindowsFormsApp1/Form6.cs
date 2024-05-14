using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form

    {
        Dbconnect dbcon = new Dbconnect();
        DGVPrinter printer = new DGVPrinter();
        public Form6()
        {
            InitializeComponent();
        }

        private void getcategory()
        {
            string SelectQuarry = "SELECT * FROM  category ";
            SqlCommand command = new SqlCommand(SelectQuarry, dbcon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmb_cate.DataSource = table;
            cmb_cate.ValueMember = "CatName";
            
        }
        private void gettable()
        {
            string SelectQuarry = "SELECT ProdName,ProdPrice FROM  product";
            SqlCommand command = new SqlCommand(SelectQuarry, dbcon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            grd_product.DataSource = table;
        }

        private void getselltable()
        {
            string SelectQuarry = "SELECT * FROM  bill";
            SqlCommand command = new SqlCommand(SelectQuarry, dbcon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            grd_selllist.DataSource = table;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Today.ToShortDateString();
            lbl_nam.Text = Form2.SellerName;
            gettable();
            getcategory();
            getselltable();
        }

        private void grd_product_Click(object sender, EventArgs e)
        {
            Text_name.Text=grd_product.SelectedRows[0].Cells[0].Value.ToString();
            Text_price.Text=grd_product.SelectedRows[0].Cells[1].Value.ToString();
        }

        int grandtotal = 0 , n = 0;

        private void Btn_add1_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuary = "INSERT INTO bill VALUES(" + Txt_billid.Text + " , ' " + lbl_nam.Text + " ' , ' " + lbl_date .Text + " ',  ' " + grandtotal.ToString() + " ')";
                SqlCommand command = new SqlCommand(insertQuary, dbcon.Getcon());
                dbcon.opencon();
                command.ExecuteNonQuery();
                MessageBox.Show("Order Added Successfully ", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbcon.closecon();
                getselltable();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            printer.Title= "Mini Market Sell List";
            printer.SubTitle=String.Format("Date:{0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "foxlearn";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(grd_selllist);
        }

        private void lbl_logout_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            login.Show();
            this.Hide();
        }

        private void label_EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_EXIT_MouseEnter(object sender, EventArgs e)
        {
            label_EXIT.ForeColor= Color.Red;
        }

        private void label_EXIT_MouseLeave(object sender, EventArgs e)
        {
            label_EXIT.ForeColor = Color.Black;
        }

        private void lbl_logout_MouseEnter(object sender, EventArgs e)
        {
            lbl_logout.ForeColor = Color.Red;
        }

        private void lbl_logout_MouseLeave(object sender, EventArgs e)
        {
            lbl_logout.ForeColor= Color.Black;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            gettable();
        }

        private void cmb_cate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string SelectQuarry = "SELECT ProdName,ProdPrice FROM  product WHERE ProdCat= '"+cmb_cate.SelectedValue.ToString()+"'";
            SqlCommand command = new SqlCommand(SelectQuarry, dbcon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            grd_product.DataSource = table;
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            if (Text_name.Text ==""||Text_quantity.Text == "")
            {
                MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int total = Convert.ToInt32(Text_price.Text) * Convert.ToInt32(Text_quantity.Text);
                DataGridViewRow addRow = new DataGridViewRow();
                addRow.CreateCells(grd_oder);
                addRow.Cells[0].Value = ++n;
                addRow.Cells[1].Value =Text_name.Text;
                addRow.Cells[2].Value =Text_price.Text;
                addRow.Cells[3].Value =Text_quantity.Text;
                addRow.Cells[4].Value =total;
                grd_oder.Rows.Add(addRow);
                grandtotal += total;
                lbl_amount1.Text = "Rs:"+ grandtotal;
            }

        }
    }
}
