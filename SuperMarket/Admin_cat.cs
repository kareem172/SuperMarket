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
    public partial class Admin_cat : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public Admin_cat()
        {
            InitializeComponent();
        }

        private void Admin_cat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'superMarketDataSet.Catagories' table. You can move, or remove it, as needed.
            
            sell_button.Enabled = true;
            prod_button.Enabled = true;
            cat_button.Enabled = false;
            try
            {
                string s = "Data Source=KAREEM001;Initial Catalog=superMarket;Integrated Security=True";
                con = new SqlConnection(s);
                con.Open();
                this.catagoriesTableAdapter.Fill(this.superMarketDataSet.Catagories);
                dataGridView1.DataSource = superMarketDataSet.Catagories;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed \n" + ex);
            }
        }

        private void exiit_button_Click(object sender, EventArgs e)
        {
            con.Close();

            Application.Exit();
        }

        private void prod_button_Click(object sender, EventArgs e)
        {
            Admin_prod admin_Prod = new Admin_prod();
            admin_Prod.Show();
            this.Hide();
        }

        private void sell_button_Click(object sender, EventArgs e)
        {
            AdminSellers sellers = new AdminSellers();
            sellers.Show();
            this.Hide();
        }
        public void erase()
        {
            ID.Clear();
            cat_name.Clear();
            Descrip.Clear();
            
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand($"insert into Catagories values({int.Parse(ID.Text)},'" + cat_name.Text + "','" + Descrip.Text + "')", con);
                command.ExecuteNonQuery();
                this.catagoriesTableAdapter.Fill(this.superMarketDataSet.Catagories);
                dataGridView1.DataSource = superMarketDataSet.Catagories;
                erase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adding failed \n" + ex);
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID.Text != "")
                {
                    foreach (DataRow r in superMarketDataSet.Catagories)
                    {
                        if (Convert.ToInt32(r["catID"]) == int.Parse(ID.Text))
                        {
                            r[1] = cat_name.Text;
                            r[2] = Descrip.Text;
                            
                        }
                        
                    }
                    this.catagoriesTableAdapter.Update(this.superMarketDataSet);
                    this.catagoriesTableAdapter.Fill(this.superMarketDataSet.Catagories);
                    dataGridView1.DataSource = superMarketDataSet.Catagories;
                    erase();
                }
                else { MessageBox.Show("you must enter an ID"); }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Editing failed \n" + ex);
            }
        }

        private void del_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID.Text != "")
                {
                    SqlCommand command = new SqlCommand($"delete from Catagories where catID={ID.Text}", con);
                    command.ExecuteNonQuery();

                    this.catagoriesTableAdapter.Fill(this.superMarketDataSet.Catagories);
                    dataGridView1.DataSource = superMarketDataSet.Catagories;
                    erase();
                }
                else { MessageBox.Show("you must enter an ID"); }

            }
            catch (Exception ex)
            {
                MessageBox.Show("deleting failed \n" + ex);
            }
        }
    }
}
