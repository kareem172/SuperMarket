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

namespace SuperMarket
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds=new DataSet() ;
        public string name { get; set; }
        public string pass { get; set; }
        public string user { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        public void getinfo()
        {
            name = this.textBox1.Text;
             
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // name = textBox1.Text;
             pass = textBox2.Text;
             user = comboBox1.SelectedItem.ToString();
            getinfo();
            try
            {
                if (user=="Admin")
                {
                    if(name=="admin"||name=="Admin")
                    {
                        if(pass=="admin")
                        {
                            
                            AdminSellers admin_Sellers = new AdminSellers();
                            admin_Sellers.Show();
                            MessageBox.Show("LogIn successfully");
                            this.Hide();
                            
                        }
                        else
                        {
                            MessageBox.Show("The username or password is incorrect");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The username or password is incorrect");
                    }
                }
                else if (user == "Seller")
                {
                    foreach (DataRow r in ds.Tables["Sellers"].Rows)
                    {
                        if (r["sellerName"].ToString()==name && r["sellerPassword"].ToString() == pass)
                        {
                            Sellers sellers = new Sellers();
                            sellers.name = name;
                            sellers.Show();
                            MessageBox.Show("LogIn successfully");
                            this.Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("This feature will be added in the near future");
                }

            }
            catch {
                MessageBox.Show("Something Went Wrong");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string s = "Data Source=KAREEM001;Initial Catalog=superMarket;Integrated Security=True";
                con = new SqlConnection(s);
                con.Open();
                SqlCommand sql = new SqlCommand("select * from Sellers", con);
                sql.ExecuteNonQuery();
                da = new SqlDataAdapter(sql);
                
                if (da != null)
                {
                   // MessageBox.Show("it's not null");
                    da.Fill(ds, "Sellers");
                    
                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed \n" + ex);
            }

        }
    }
}
