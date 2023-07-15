
namespace SuperMarket
{
    partial class AdminSellers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSellers));
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.seller_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sellerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.superMarketDataSet = new SuperMarket.superMarketDataSet();
            this.add_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.del_button = new System.Windows.Forms.Button();
            this.cat_button = new System.Windows.Forms.Button();
            this.prod_button = new System.Windows.Forms.Button();
            this.sell_button = new System.Windows.Forms.Button();
            this.exiit_button = new System.Windows.Forms.Button();
            this.sellersTableAdapter = new SuperMarket.superMarketDataSetTableAdapters.SellersTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seller ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(187, 156);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(164, 27);
            this.ID.TabIndex = 1;
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            // 
            // seller_name
            // 
            this.seller_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seller_name.Location = new System.Drawing.Point(187, 212);
            this.seller_name.Name = "seller_name";
            this.seller_name.Size = new System.Drawing.Size(164, 27);
            this.seller_name.TabIndex = 3;
            this.seller_name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seller Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Age
            // 
            this.Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.Location = new System.Drawing.Point(187, 266);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(164, 27);
            this.Age.TabIndex = 5;
            this.Age.TextChanged += new System.EventHandler(this.Age_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seller Age";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Phone
            // 
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(187, 319);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(164, 27);
            this.Phone.TabIndex = 7;
            this.Phone.TextChanged += new System.EventHandler(this.Phone_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seller Phone";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(187, 374);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(164, 27);
            this.Password.TabIndex = 9;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Seller Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sellerIDDataGridViewTextBoxColumn,
            this.sellerNameDataGridViewTextBoxColumn,
            this.sellerAgeDataGridViewTextBoxColumn,
            this.sellerPhoneDataGridViewTextBoxColumn,
            this.sellerPasswordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sellersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(369, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(621, 378);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sellerIDDataGridViewTextBoxColumn
            // 
            this.sellerIDDataGridViewTextBoxColumn.DataPropertyName = "sellerID";
            this.sellerIDDataGridViewTextBoxColumn.HeaderText = "sellerID";
            this.sellerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sellerIDDataGridViewTextBoxColumn.Name = "sellerIDDataGridViewTextBoxColumn";
            this.sellerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // sellerNameDataGridViewTextBoxColumn
            // 
            this.sellerNameDataGridViewTextBoxColumn.DataPropertyName = "sellerName";
            this.sellerNameDataGridViewTextBoxColumn.HeaderText = "sellerName";
            this.sellerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sellerNameDataGridViewTextBoxColumn.Name = "sellerNameDataGridViewTextBoxColumn";
            this.sellerNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // sellerAgeDataGridViewTextBoxColumn
            // 
            this.sellerAgeDataGridViewTextBoxColumn.DataPropertyName = "sellerAge";
            this.sellerAgeDataGridViewTextBoxColumn.HeaderText = "sellerAge";
            this.sellerAgeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sellerAgeDataGridViewTextBoxColumn.Name = "sellerAgeDataGridViewTextBoxColumn";
            this.sellerAgeDataGridViewTextBoxColumn.Width = 125;
            // 
            // sellerPhoneDataGridViewTextBoxColumn
            // 
            this.sellerPhoneDataGridViewTextBoxColumn.DataPropertyName = "sellerPhone";
            this.sellerPhoneDataGridViewTextBoxColumn.HeaderText = "sellerPhone";
            this.sellerPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sellerPhoneDataGridViewTextBoxColumn.Name = "sellerPhoneDataGridViewTextBoxColumn";
            this.sellerPhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // sellerPasswordDataGridViewTextBoxColumn
            // 
            this.sellerPasswordDataGridViewTextBoxColumn.DataPropertyName = "sellerPassword";
            this.sellerPasswordDataGridViewTextBoxColumn.HeaderText = "sellerPassword";
            this.sellerPasswordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sellerPasswordDataGridViewTextBoxColumn.Name = "sellerPasswordDataGridViewTextBoxColumn";
            this.sellerPasswordDataGridViewTextBoxColumn.Width = 125;
            // 
            // sellersBindingSource
            // 
            this.sellersBindingSource.DataMember = "Sellers";
            this.sellersBindingSource.DataSource = this.superMarketDataSet;
            // 
            // superMarketDataSet
            // 
            this.superMarketDataSet.DataSetName = "superMarketDataSet";
            this.superMarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.GhostWhite;
            this.add_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(12, 470);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(108, 54);
            this.add_button.TabIndex = 11;
            this.add_button.Text = "ADD";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.GhostWhite;
            this.edit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.Location = new System.Drawing.Point(126, 470);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(114, 54);
            this.edit_button.TabIndex = 12;
            this.edit_button.Text = "EDIT";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // del_button
            // 
            this.del_button.BackColor = System.Drawing.Color.GhostWhite;
            this.del_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.del_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_button.Location = new System.Drawing.Point(246, 470);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(117, 54);
            this.del_button.TabIndex = 13;
            this.del_button.Text = "DELETE";
            this.del_button.UseVisualStyleBackColor = false;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // cat_button
            // 
            this.cat_button.BackColor = System.Drawing.Color.GhostWhite;
            this.cat_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat_button.Location = new System.Drawing.Point(40, 22);
            this.cat_button.Name = "cat_button";
            this.cat_button.Size = new System.Drawing.Size(154, 49);
            this.cat_button.TabIndex = 14;
            this.cat_button.Text = "Catagories";
            this.cat_button.UseVisualStyleBackColor = false;
            this.cat_button.Click += new System.EventHandler(this.cat_button_Click);
            // 
            // prod_button
            // 
            this.prod_button.BackColor = System.Drawing.Color.GhostWhite;
            this.prod_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_button.Location = new System.Drawing.Point(209, 22);
            this.prod_button.Name = "prod_button";
            this.prod_button.Size = new System.Drawing.Size(154, 49);
            this.prod_button.TabIndex = 15;
            this.prod_button.Text = "Products";
            this.prod_button.UseVisualStyleBackColor = false;
            this.prod_button.Click += new System.EventHandler(this.prod_button_Click);
            // 
            // sell_button
            // 
            this.sell_button.BackColor = System.Drawing.Color.GhostWhite;
            this.sell_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sell_button.Location = new System.Drawing.Point(378, 22);
            this.sell_button.Name = "sell_button";
            this.sell_button.Size = new System.Drawing.Size(154, 49);
            this.sell_button.TabIndex = 16;
            this.sell_button.Text = "Sellers";
            this.sell_button.UseVisualStyleBackColor = false;
            this.sell_button.Click += new System.EventHandler(this.sell_button_Click);
            // 
            // exiit_button
            // 
            this.exiit_button.BackColor = System.Drawing.Color.GhostWhite;
            this.exiit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exiit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exiit_button.Location = new System.Drawing.Point(894, 22);
            this.exiit_button.Name = "exiit_button";
            this.exiit_button.Size = new System.Drawing.Size(96, 54);
            this.exiit_button.TabIndex = 17;
            this.exiit_button.Text = "EXIT";
            this.exiit_button.UseVisualStyleBackColor = false;
            this.exiit_button.Click += new System.EventHandler(this.exiit_button_Click);
            // 
            // sellersTableAdapter
            // 
            this.sellersTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(313, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(303, 36);
            this.label6.TabIndex = 18;
            this.label6.Text = "Sellers Management";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // AdminSellers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 536);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.exiit_button);
            this.Controls.Add(this.sell_button);
            this.Controls.Add(this.prod_button);
            this.Controls.Add(this.cat_button);
            this.Controls.Add(this.del_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.seller_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.Name = "AdminSellers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_sellers";
            this.Load += new System.EventHandler(this.Admin_sellers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox seller_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.Button cat_button;
        private System.Windows.Forms.Button prod_button;
        private System.Windows.Forms.Button sell_button;
        private System.Windows.Forms.Button exiit_button;
        private superMarketDataSet superMarketDataSet;
        private System.Windows.Forms.BindingSource sellersBindingSource;
        private superMarketDataSetTableAdapters.SellersTableAdapter sellersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
    }
}