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
using Guna.UI2.WinForms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        Dbconnect dbcon = new Dbconnect();
        public Form3()
        {
            InitializeComponent();
        }

        private void Button_category_Click(object sender, EventArgs e)
        {
            Form4 category = new Form4();
            category.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            getcategory();
            gettable();
        }

        private void getcategory() 
        {
            string SelectQuarry = "SELECT * FROM  category ";
            SqlCommand command = new SqlCommand(SelectQuarry, dbcon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmb_category.DataSource = table;
            cmb_category.ValueMember = "CatName";
            cmb_refresh .DataSource = table;
            cmb_refresh .ValueMember = "CatName";
        }

        private void gettable() 
        {
            string SelectQuarry = "SELECT * FROM  product";
            SqlCommand command = new SqlCommand(SelectQuarry, dbcon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            GRD_Mange .DataSource = table;
        }

        private void Clear() 
        {
            Text_id.Clear();
            Text_name.Clear();
            Text_price.Clear();
            Text_quantity.Clear();
            cmb_category .SelectedIndex = 0;
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuary = "INSERT INTO product VALUES(" + Text_id.Text + " , ' " + Text_name.Text + " ' , ' " + Text_price.Text + " ', ' " + Text_quantity.Text + " ', ' " + cmb_category.Text + " ')";
                SqlCommand command = new SqlCommand(insertQuary, dbcon.Getcon());
                dbcon.opencon();
                command.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully ", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbcon.closecon();
                gettable();
                Clear();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
             
            try
            {
                if (Text_id.Text == " " || Text_name.Text == " " || Text_price.Text == " " ||Text_quantity.Text == " ")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    string updateQuary = "UPDATE product SET ProdName =' " + Text_name.Text + " ' ,ProdPrice ='"+Text_price.Text+ " ',ProdQty ='"+Text_quantity.Text+ " ',ProdCat ='"+cmb_category.Text+ "'WHERE ProdId="+Text_id.Text+ " ";
                    SqlCommand command = new SqlCommand(updateQuary, dbcon.Getcon());
                    dbcon.opencon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product UpDated Successfully ", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbcon.closecon();
                    gettable();
                    Clear();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void GRD_Mange_Click_1(object sender, EventArgs e)
        {
            Text_id.Text =  GRD_Mange.SelectedRows[0].Cells[0].Value.ToString();
            Text_name.Text =  GRD_Mange.SelectedRows[0].Cells[1].Value.ToString();
            Text_price.Text =  GRD_Mange.SelectedRows[0].Cells[2].Value.ToString();
            Text_quantity.Text =  GRD_Mange.SelectedRows[0].Cells[3].Value.ToString();
            cmb_category.SelectedValue =  GRD_Mange.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Text_id.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string deleteQuary = "DELETE FROM  product WHERE ProdId ="+ Text_id.Text+" ";
                    SqlCommand command = new SqlCommand(deleteQuary, dbcon.Getcon());
                    dbcon.opencon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully ", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbcon.closecon();
                    gettable();
                    Clear();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            gettable();
        }

        private void cmb_refresh_SelectionChangeCommitted(object sender, EventArgs e)
        {

            string SelectQuarry = "SELECT * FROM  product WHERE ProdCat= '"+cmb_refresh.SelectedValue.ToString()+"'";
            SqlCommand command = new SqlCommand(SelectQuarry, dbcon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            GRD_Mange.DataSource = table;
        }

        private void label_EXIT_MouseEnter(object sender, EventArgs e)
        {
            label_EXIT.ForeColor = Color.Red;
        }

        private void label_EXIT_MouseLeave(object sender, EventArgs e)
        {
            label_EXIT.ForeColor= Color.Black;
        }

        private void lbl_logout_MouseEnter(object sender, EventArgs e)
        {
            lbl_logout.ForeColor = Color.Red;
        }

        private void lbl_logout_MouseLeave(object sender, EventArgs e)
        {
            lbl_logout.ForeColor = Color.White;
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

        private void Btn_selling_Click(object sender, EventArgs e)
        {
            Form6 selling = new Form6();
            selling.Show();
            this.Hide();
        }

        private void Btn_seller_Click(object sender, EventArgs e)
        {
            Form5 seller = new Form5();
            seller.Show();
            this.Hide();
        }
    }
}
