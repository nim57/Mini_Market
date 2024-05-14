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

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        Dbconnect dbcon= new Dbconnect();
        public Form4()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            string SelectQuarry = "SELECT * FROM category";
            SqlCommand command =new SqlCommand(SelectQuarry, dbcon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }


        private void Buttonadd_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuary = "INSERT INTO category VALUES(" + TextBoxname.Text + " , ' " + guna2TextBox3.Text + " ' , ' " + TextBox_description.Text + " ')";
                SqlCommand command= new SqlCommand(insertQuary,dbcon.Getcon());
                dbcon.opencon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully ", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbcon.closecon();
                getTable();
                clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxname.Text == ""|| guna2TextBox3.Text == "" || TextBox_description.Text == "")
                {
                    MessageBox.Show("Missing Information", "Worning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuary = "UPDATE category SET CatName =' " + guna2TextBox3.Text + " ' ,CatDes ='"+TextBox_description.Text+ " 'WHERE CatId="+TextBoxname.Text+"";
                    SqlCommand command = new SqlCommand(updateQuary, dbcon.Getcon());
                    dbcon.opencon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category UpDated Successfully ", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbcon.closecon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            TextBoxname.Text=dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            guna2TextBox3.Text=dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_description.Text=dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }
        private void clear() 
        {
            TextBoxname.Clear();
            guna2TextBox3.Clear();
            guna2TextBox3.Clear();
        }

        private void Buttondelet_Click(object sender, EventArgs e)
        {
            string deleteQuary = "DELETE FROM  category WHERE CatId ="+ TextBoxname.Text+" ";
            SqlCommand command = new SqlCommand(deleteQuary, dbcon.Getcon());
            dbcon.opencon();
            command.ExecuteNonQuery();
            MessageBox.Show("Category Deleted Successfully ", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dbcon.closecon();
            getTable();
            clear();

        }

        private void label_EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_EXIT_MouseEnter(object sender, EventArgs e)
        {
           label_EXIT.ForeColor = Color.Red;
        }

        private void label_EXIT_MouseLeave(object sender, EventArgs e)
        {
            label_EXIT.ForeColor= Color.White;
        }

        private void lbl_logout_MouseEnter(object sender, EventArgs e)
        {
            lbl_logout.ForeColor = Color.Red;
        }

        private void lbl_logout_MouseLeave(object sender, EventArgs e)
        {
            lbl_logout.ForeColor= Color.White;
        }

        private void lbl_logout_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            login.Show();
            this.Hide();

        }

        private void Btnproduct_Click(object sender, EventArgs e)
        {
            Form3 login = new Form3();
            login.Show();
            this.Hide();
        }

        private void Btnseller_Click(object sender, EventArgs e)
        {
            Form5 login = new Form5();
            login.Show();
            this.Hide();
        }

        private void Btnselling_Click(object sender, EventArgs e)
        {
            Form6 category = new Form6();
            category.Show();
            this.Hide();
        }
    }
}
