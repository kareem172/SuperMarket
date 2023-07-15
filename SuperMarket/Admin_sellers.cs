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
    public partial class AdminSellers : Form
    {
        public AdminSellers()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        private void Admin_sellers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'superMarketDataSet.Sellers' table. You can move, or remove it, as needed.
            erase();
            sell_button.Enabled = false;
            prod_button.Enabled = true;
            cat_button.Enabled = true;
            try
            {
                string s = "Data Source=KAREEM001;Initial Catalog=superMarket;Integrated Security=True";
                con = new SqlConnection(s);
                con.Open();
                this.sellersTableAdapter.Fill(this.superMarketDataSet.Sellers);
                dataGridView1.DataSource = superMarketDataSet.Sellers;
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Connection failed \n" + ex);
            }

        }

        private void exiit_button_Click(object sender, EventArgs e)
        {
            con.Close();
           
            Application.Exit();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID.Text != "") 
                {
                    foreach (DataRow r in superMarketDataSet.Sellers)
                    {
                        if (Convert.ToInt32(r["sellerID"]) == int.Parse(ID.Text))
                        {
                            r[1] = seller_name.Text;
                            r[2] = Age.Text;
                            r[3] = Phone.Text;
                            r[4] = Password.Text;
                        }
                       // else { MessageBox.Show("Not Found"); }
                    }
                    this.sellersTableAdapter.Update(this.superMarketDataSet);
                    this.sellersTableAdapter.Fill(this.superMarketDataSet.Sellers);
                    dataGridView1.DataSource = superMarketDataSet.Sellers;
                    erase();
                }
                else { MessageBox.Show("you must enter an ID"); }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Editing failed \n" + ex);
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {              
                SqlCommand command = new SqlCommand($"insert into Sellers values({int.Parse(ID.Text)},'"+seller_name.Text+"',"+int.Parse(Age.Text)+","+int.Parse(Phone.Text)+",'"+Password.Text+"')", con);
                command.ExecuteNonQuery();                
                this.sellersTableAdapter.Fill(this.superMarketDataSet.Sellers);
                dataGridView1.DataSource = superMarketDataSet.Sellers;
                erase();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Adding failed \n" + ex);
            }
            
        }
        public void erase()
        {
            ID.Clear();
            seller_name.Clear();
            Age.Clear();
            Phone.Clear();
            Password.Clear();
        }

        private void del_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID.Text != "")
                {
                    SqlCommand command = new SqlCommand($"delete from Sellers where sellerID={ID.Text}", con);
                    command.ExecuteNonQuery();
                    
                    this.sellersTableAdapter.Fill(this.superMarketDataSet.Sellers);
                    dataGridView1.DataSource = superMarketDataSet.Sellers;
                    erase();
                }
                else { MessageBox.Show("you must enter an ID"); }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adding failed \n" + ex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sell_button_Click(object sender, EventArgs e)
        {

        }

        private void prod_button_Click(object sender, EventArgs e)
        {
            Admin_prod admin_Prod = new Admin_prod();
            admin_Prod.Show();
            this.Hide();
        }

        private void cat_button_Click(object sender, EventArgs e)
        {
            Admin_cat admin_Cat = new Admin_cat();
            admin_Cat.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Age_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
