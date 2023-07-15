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
    
    public partial class Admin_prod : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;

        public Admin_prod()
        {
            InitializeComponent();
        }

        private void Admin_prod_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'superMarketDataSet.Catagories' table. You can move, or remove it, as needed.
            this.catagoriesTableAdapter.Fill(this.superMarketDataSet.Catagories);
            // TODO: This line of code loads data into the 'superMarketDataSet.Products' table. You can move, or remove it, as needed.

            sell_button.Enabled = true;
            prod_button.Enabled = false;
            cat_button.Enabled = true;
            try
            {
                string s = "Data Source=KAREEM001;Initial Catalog=superMarket;Integrated Security=True";
                con = new SqlConnection(s);
                con.Open();
                this.productsTableAdapter.Fill(this.superMarketDataSet.Products);
                dataGridView1.DataSource = superMarketDataSet.Products;


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

        private void sell_button_Click(object sender, EventArgs e)
        {
            AdminSellers sellers = new AdminSellers();
            sellers.Show();
            this.Hide();
        }

        private void cat_button_Click(object sender, EventArgs e)
        {
            Admin_cat admin_Cat = new Admin_cat();
            admin_Cat.Show();
            this.Hide();
        }
        public void erase()
        {
            ID.Clear();
            prod_name.Clear();
            Quantity.Clear();
            Price.Clear();
            
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                 
                SqlCommand command = new SqlCommand($"insert into Products values({int.Parse(ID.Text)},'" + prod_name.Text + "'," + int.Parse(Quantity.Text) + "," + float.Parse(Price.Text) + ",'" + Convert.ToString(combo_cat1.Text) + "')", con);
                command.ExecuteNonQuery();
                this.productsTableAdapter.Fill(this.superMarketDataSet.Products);
                dataGridView1.DataSource = superMarketDataSet.Products;
                erase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adding failed \n" + ex);
            }
        }

        private void del_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID.Text != "")
                {
                    SqlCommand command = new SqlCommand($"delete from Products where prodID={ID.Text}", con);
                    command.ExecuteNonQuery();

                    this.productsTableAdapter.Fill(this.superMarketDataSet.Products);
                    dataGridView1.DataSource = superMarketDataSet.Products;
                    erase();
                }
                else { MessageBox.Show("you must enter an ID"); }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Deleting failed \n" + ex);
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID.Text != "")
                {
                    //foreach (DataRow r in superMarketDataSet.Products)
                    //{
                    //    if (Convert.ToInt32(r["prodID"]) == int.Parse(ID.Text))
                    //    {
                    //        r["prodName"] = prod_name.Text;
                    //        r["prodQty"] = int.Parse(Quantity.Text);
                    //        r["prodPrice"] =float.Parse( Price.Text);
                    //        r["prodCatagory"] = combo_cat1.Text;
                    //    }
                    //    // else { MessageBox.Show("Not Found"); }
                    //}
                    //this.productsTableAdapter.Update(this.superMarketDataSet.Products);


                    string s = $"update Products set prodName='{ prod_name.Text }',prodQty={int.Parse(Quantity.Text)},prodPrice={float.Parse(Price.Text)},prodCatagory='{combo_cat1.Text}' where prodID={int.Parse(ID.Text)}";
                    SqlCommand sql = new SqlCommand(s, con);
                    sql.ExecuteNonQuery();
                    
                    this.productsTableAdapter.Fill(this.superMarketDataSet.Products);
                    dataGridView1.DataSource = superMarketDataSet.Products;
                    erase();
                }
                else { MessageBox.Show("you must enter an ID"); }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Editing failed \n" + ex);
            }
        }
    }
}
