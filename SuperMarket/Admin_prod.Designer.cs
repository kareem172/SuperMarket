
namespace SuperMarket
{
    partial class Admin_prod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_prod));
            this.label6 = new System.Windows.Forms.Label();
            this.exiit_button = new System.Windows.Forms.Button();
            this.sell_button = new System.Windows.Forms.Button();
            this.prod_button = new System.Windows.Forms.Button();
            this.cat_button = new System.Windows.Forms.Button();
            this.del_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.superMarketDataSet = new SuperMarket.superMarketDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prod_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_cat2 = new System.Windows.Forms.ComboBox();
            this.catagoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.catagoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ref_button = new System.Windows.Forms.Button();
            this.productsTableAdapter = new SuperMarket.superMarketDataSetTableAdapters.ProductsTableAdapter();
            this.combo_cat1 = new System.Windows.Forms.ComboBox();
            this.catagoriesTableAdapter = new SuperMarket.superMarketDataSetTableAdapters.CatagoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(313, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(316, 36);
            this.label6.TabIndex = 37;
            this.label6.Text = "Product Management";
            // 
            // exiit_button
            // 
            this.exiit_button.BackColor = System.Drawing.Color.GhostWhite;
            this.exiit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exiit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exiit_button.Location = new System.Drawing.Point(894, 17);
            this.exiit_button.Name = "exiit_button";
            this.exiit_button.Size = new System.Drawing.Size(96, 54);
            this.exiit_button.TabIndex = 36;
            this.exiit_button.Text = "EXIT";
            this.exiit_button.UseVisualStyleBackColor = false;
            this.exiit_button.Click += new System.EventHandler(this.exiit_button_Click);
            // 
            // sell_button
            // 
            this.sell_button.BackColor = System.Drawing.Color.GhostWhite;
            this.sell_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sell_button.Location = new System.Drawing.Point(378, 17);
            this.sell_button.Name = "sell_button";
            this.sell_button.Size = new System.Drawing.Size(154, 49);
            this.sell_button.TabIndex = 35;
            this.sell_button.Text = "Sellers";
            this.sell_button.UseVisualStyleBackColor = false;
            this.sell_button.Click += new System.EventHandler(this.sell_button_Click);
            // 
            // prod_button
            // 
            this.prod_button.BackColor = System.Drawing.Color.GhostWhite;
            this.prod_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_button.Location = new System.Drawing.Point(209, 17);
            this.prod_button.Name = "prod_button";
            this.prod_button.Size = new System.Drawing.Size(154, 49);
            this.prod_button.TabIndex = 34;
            this.prod_button.Text = "Products";
            this.prod_button.UseVisualStyleBackColor = false;
            // 
            // cat_button
            // 
            this.cat_button.BackColor = System.Drawing.Color.GhostWhite;
            this.cat_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat_button.Location = new System.Drawing.Point(40, 17);
            this.cat_button.Name = "cat_button";
            this.cat_button.Size = new System.Drawing.Size(154, 49);
            this.cat_button.TabIndex = 33;
            this.cat_button.Text = "Catagories";
            this.cat_button.UseVisualStyleBackColor = false;
            this.cat_button.Click += new System.EventHandler(this.cat_button_Click);
            // 
            // del_button
            // 
            this.del_button.BackColor = System.Drawing.Color.GhostWhite;
            this.del_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.del_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_button.Location = new System.Drawing.Point(246, 465);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(117, 54);
            this.del_button.TabIndex = 32;
            this.del_button.Text = "DELETE";
            this.del_button.UseVisualStyleBackColor = false;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.GhostWhite;
            this.edit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.Location = new System.Drawing.Point(126, 465);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(114, 54);
            this.edit_button.TabIndex = 31;
            this.edit_button.Text = "EDIT";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.GhostWhite;
            this.add_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(12, 465);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(108, 54);
            this.add_button.TabIndex = 30;
            this.add_button.Text = "ADD";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(369, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(621, 312);
            this.dataGridView1.TabIndex = 29;
            // 
            // superMarketDataSet
            // 
            this.superMarketDataSet.DataSetName = "superMarketDataSet";
            this.superMarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Product Catagory";
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(187, 314);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(164, 27);
            this.Price.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Product Price";
            // 
            // Quantity
            // 
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(187, 261);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(164, 27);
            this.Quantity.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Product Quantity";
            // 
            // prod_name
            // 
            this.prod_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_name.Location = new System.Drawing.Point(187, 207);
            this.prod_name.Name = "prod_name";
            this.prod_name.Size = new System.Drawing.Size(164, 27);
            this.prod_name.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Product Name";
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(187, 151);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(164, 27);
            this.ID.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Product ID";
            // 
            // combo_cat2
            // 
            this.combo_cat2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.catagoriesBindingSource1, "catName", true));
            this.combo_cat2.DataSource = this.catagoriesBindingSource;
            this.combo_cat2.DisplayMember = "catName";
            this.combo_cat2.FormattingEnabled = true;
            this.combo_cat2.Location = new System.Drawing.Point(443, 151);
            this.combo_cat2.Name = "combo_cat2";
            this.combo_cat2.Size = new System.Drawing.Size(173, 24);
            this.combo_cat2.TabIndex = 38;
            this.combo_cat2.ValueMember = "catName";
            // 
            // catagoriesBindingSource1
            // 
            this.catagoriesBindingSource1.DataMember = "Catagories";
            this.catagoriesBindingSource1.DataSource = this.superMarketDataSet;
            // 
            // catagoriesBindingSource
            // 
            this.catagoriesBindingSource.DataMember = "Catagories";
            this.catagoriesBindingSource.DataSource = this.superMarketDataSet;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.superMarketDataSet;
            // 
            // ref_button
            // 
            this.ref_button.BackColor = System.Drawing.Color.GhostWhite;
            this.ref_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ref_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ref_button.Location = new System.Drawing.Point(684, 133);
            this.ref_button.Name = "ref_button";
            this.ref_button.Size = new System.Drawing.Size(124, 54);
            this.ref_button.TabIndex = 39;
            this.ref_button.Text = "Refresh";
            this.ref_button.UseVisualStyleBackColor = false;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // combo_cat1
            // 
            this.combo_cat1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.catagoriesBindingSource1, "catName", true));
            this.combo_cat1.DataSource = this.catagoriesBindingSource1;
            this.combo_cat1.DisplayMember = "catName";
            this.combo_cat1.FormattingEnabled = true;
            this.combo_cat1.Location = new System.Drawing.Point(187, 372);
            this.combo_cat1.Name = "combo_cat1";
            this.combo_cat1.Size = new System.Drawing.Size(164, 24);
            this.combo_cat1.TabIndex = 40;
            this.combo_cat1.ValueMember = "catName";
            // 
            // catagoriesTableAdapter
            // 
            this.catagoriesTableAdapter.ClearBeforeFill = true;
            // 
            // Admin_prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 536);
            this.Controls.Add(this.combo_cat1);
            this.Controls.Add(this.ref_button);
            this.Controls.Add(this.combo_cat2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.exiit_button);
            this.Controls.Add(this.sell_button);
            this.Controls.Add(this.prod_button);
            this.Controls.Add(this.cat_button);
            this.Controls.Add(this.del_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prod_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.Name = "Admin_prod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_prod";
            this.Load += new System.EventHandler(this.Admin_prod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button exiit_button;
        private System.Windows.Forms.Button sell_button;
        private System.Windows.Forms.Button prod_button;
        private System.Windows.Forms.Button cat_button;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prod_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_cat2;
        private System.Windows.Forms.Button ref_button;
        private superMarketDataSet superMarketDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private superMarketDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.ComboBox combo_cat1;
        private System.Windows.Forms.BindingSource catagoriesBindingSource;
        private superMarketDataSetTableAdapters.CatagoriesTableAdapter catagoriesTableAdapter;
        private System.Windows.Forms.BindingSource catagoriesBindingSource1;
    }
}