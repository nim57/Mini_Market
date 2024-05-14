using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Dbconnect dbcon = new Dbconnect();
        public static string SellerName;

        public Form2()
        {
            InitializeComponent();
        }

        

        private void label_EXIT_MouseEnter(object sender, EventArgs e)
        {
            label_EXIT.ForeColor = Color.Red;
        }

        private void label_EXIT_MouseLeave(object sender, EventArgs e)
        {
            label_EXIT.ForeColor = Color.White;
        }

        private void label_CLEAR_MouseEnter(object sender, EventArgs e)
        {
            label_CLEAR.ForeColor = Color.Red;
        }

        private void label_CLEAR_MouseLeave(object sender, EventArgs e)
        {
            label_CLEAR.ForeColor = Color.White;
        }

        private void label_EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_CLEAR_Click(object sender, EventArgs e)
        {
            TextBox_USERNAME.Clear();
            TextBox_PASSWORD.Clear();
        }

        

        private void Button_LOGIN_Click(object sender, EventArgs e)
        {
            if (TextBox_USERNAME.Text == "" ||TextBox_PASSWORD.Text == "")
            {
                MessageBox.Show("Please Enter UserName And Password", "Missind Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboBox1.SelectedIndex > -1)
                {
                    if (comboBox1.SelectedItem.ToString()=="ADMIN")
                    {
                        if (TextBox_USERNAME.Text=="ADMIN" &&  TextBox_PASSWORD.Text=="Admin123")
                        {
                            Form3 Product = new Form3();
                            Product.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If your Admin,Please Enter Corret ID and Password", "Miss ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else
                    {
                        string SelectQuary1 = "SELECT * FROM seller WHERE SellerName='"+TextBox_USERNAME.Text+"' AND  SellerPss='"+TextBox_PASSWORD.Text+"'";

                        SqlDataAdapter adapter1 = new SqlDataAdapter(SelectQuary1,dbcon.Getcon());
                        DataTable Table = new DataTable();
                        adapter1.Fill(Table);
                        if (Table.Rows. Count > -1)
                        {
                            SellerName = TextBox_USERNAME.Text;
                            Form6 selling = new Form6();
                            selling.Show();
                            this.Hide();
                        }
                        else
                        {
                            
                             MessageBox.Show("Worng Username or Password ", "Wrong Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Please Select Role ", "Wrong Infomation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
