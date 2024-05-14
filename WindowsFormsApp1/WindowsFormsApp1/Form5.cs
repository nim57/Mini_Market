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
    public partial class Form5 : Form
    {
        Dbconnect dbcon = new Dbconnect();
        public Form5()
        {
            InitializeComponent();
        }

        private void gettable()
        {
            string SelectQuarry = "SELECT * FROM  seller";
            SqlCommand command = new SqlCommand(SelectQuarry, dbcon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            GRD_Seller.DataSource = table;
        }

        private void Clear()
        {
            Text_id.Clear();
            Text_name.Clear();
            Text_age.Clear();
            Text_phone.Clear();
            Text_pass.Clear();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuary = "INSERT INTO seller VALUES(" + Text_id.Text + " , ' " + Text_name.Text + " ' , ' " + Text_age.Text + " ', ' " + Text_phone.Text + " ', ' " + Text_pass.Text + " ')";
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

        private void Form5_Load(object sender, EventArgs e)
        {
            gettable();
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (Text_id.Text == " " || Text_name.Text == " " || Text_age.Text == " " ||Text_phone.Text == " "||Text_pass.Text == " ")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    string updateQuary = "UPDATE seller SET SellerName =' " + Text_name.Text + " ' ,SellerAge ='"+Text_age.Text+ " ',SellerPhone ='"+Text_phone.Text+ " ',Sellerpss ='"+Text_pass.Text+ "'WHERE sellerId="+Text_id.Text+ " ";
                    SqlCommand command = new SqlCommand(updateQuary, dbcon.Getcon());
                    dbcon.opencon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Seller UpDated Successfully ", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void GRD_Seller_Click(object sender, EventArgs e)
        {
           Text_id.Text=GRD_Seller.SelectedRows[0].Cells[0].Value.ToString();
           Text_name.Text=GRD_Seller.SelectedRows[0].Cells[1].Value.ToString();
           Text_age.Text=GRD_Seller.SelectedRows[0].Cells[2].Value.ToString();
            Text_phone.Text=GRD_Seller.SelectedRows[0].Cells[3].Value.ToString();
            Text_pass.Text=GRD_Seller.SelectedRows[0].Cells[4].Value.ToString();
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
                    if (MessageBox.Show("Are You sure you want to Delete This record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        string deleteQuary = "DELETE FROM  seller WHERE SellerId ="+ Text_id.Text+" ";
                        SqlCommand command = new SqlCommand(deleteQuary, dbcon.Getcon());
                        dbcon.opencon();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Seller Deleted Successfully ", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dbcon.closecon();
                        gettable();
                        Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbl_logout_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            login.Show();
            this.Hide();
        }

        private void lbl_logout_MouseEnter(object sender, EventArgs e)
        {
            lbl_logout.ForeColor = Color.Red;
        }

        private void lbl_logout_MouseLeave(object sender, EventArgs e)
        {
            lbl_logout.ForeColor = Color.White;
        }

        private void label_EXIT_MouseEnter(object sender, EventArgs e)
        {
            label_EXIT.ForeColor = Color.Red;
        }

        private void label_EXIT_MouseLeave(object sender, EventArgs e)
        {
            label_EXIT.ForeColor= Color.White;
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

        private void Btn_Product_Click(object sender, EventArgs e)
        {
            Form3 product = new Form3();
            product.Show();
            this.Hide();
        }

        private void Btn_category_Click(object sender, EventArgs e)
        {
            Form4 category = new Form4();
            category.Show();
            this.Hide();
        }
    }
}

