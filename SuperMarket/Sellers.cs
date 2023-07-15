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
    public partial class Sellers : Form
    {
        public Sellers()
        {
            InitializeComponent();
            
        }
        SqlConnection connection;
        public string name;
        float total;
        int prodid = 1;
        public void erase()
        {
            product_name.Clear();
            price.Clear();
            Quantity.Clear();
        }
        private void Sellers_Load(object sender, EventArgs e)
        {
            string s = "Data Source=KAREEM001;Initial Catalog=superMarket;Integrated Security=True";
            connection = new SqlConnection(s);
            connection.Open();



           
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            label7.Text ="Seller :"+ name;
            // TODO: This line of code loads data into the 'superMarketDataSet1.Catagories' table. You can move, or remove it, as needed.
            this.catagoriesTableAdapter.Fill(this.superMarketDataSet1.Catagories);
            // TODO: This line of code loads data into the 'superMarketDataSet1.Bills' table. You can move, or remove it, as needed.
            this.billsTableAdapter.Fill(this.superMarketDataSet1.Bills);
            // TODO: This line of code loads data into the 'superMarketDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.superMarketDataSet.Products);
            // TODO: This line of code loads data into the 'superMarketDataSet.Sellers' table. You can move, or remove it, as needed.
            this.sellersTableAdapter.Fill(this.superMarketDataSet.Sellers);
            ID.Text = (superMarketDataSet1.Bills.Count+1).ToString();

        
        

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            
            
            
                try
                {
                    int rowindex = dataGridView3.CurrentCell.RowIndex;
                    int columnindex = dataGridView3.CurrentCell.ColumnIndex;

                    product_name.Text = dataGridView3.Rows[rowindex].Cells[0].Value.ToString();
                    price.Text = dataGridView3.Rows[rowindex].Cells[1].Value.ToString();


                   // MessageBox.Show(dataGridView3.Rows[rowindex].Cells[1].Value.ToString());

  
                }
                catch(Exception ex)
                {
                    MessageBox.Show("somthing went Wrong" + ex.ToString());
                }
                
            
          
            
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (product_name.Text == "" || price.Text == "" || Quantity.Text == "")
            {
                MessageBox.Show("you Must Add all information");
            }
            else
            {
                float prodtotal = float.Parse(price.Text) * float.Parse(Quantity.Text);
                dataGridView2.Rows.Add(prodid, product_name.Text, price.Text, Quantity.Text, prodtotal);
                total += prodtotal;
                label6.Text = "Total  " + total + "  Pound";
                prodid++;
                erase();
            }
        }

        private void billaddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int i_d = int.Parse(ID.Text);
                string s = $"insert into Bills values ('{name}','{label8.Text}',{total})";
                
                SqlCommand sql = new SqlCommand(s, connection);
                sql.ExecuteNonQuery();
                this.billsTableAdapter.Fill(this.superMarketDataSet1.Bills);
                ID.Text = (superMarketDataSet1.Bills.Count + 1).ToString();
                dataGridView2.Rows.Clear();
                total = 0;
                label6.Text = "Total  " + total + "  Pound";
                erase();
                dataGridView2.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string doc = "";
            if (dataGridView1.SelectedRows.Count>0)
            {
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                int columnindex = dataGridView1.CurrentCell.ColumnIndex;
                doc+= dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
                doc+="\n"+ dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
                doc += "\n" + dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
                doc += "\n" + dataGridView1.Rows[rowindex].Cells[3].Value.ToString()+" pounds";
            }
            e.Graphics.DrawString(doc, new Font("Times New Roman", 24, FontStyle.Bold),Brushes.Black,new Point(25,25));
            
        }
    }
}
