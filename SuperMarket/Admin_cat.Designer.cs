
namespace SuperMarket
{
    partial class Admin_cat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_cat));
            this.exiit_button = new System.Windows.Forms.Button();
            this.sell_button = new System.Windows.Forms.Button();
            this.prod_button = new System.Windows.Forms.Button();
            this.cat_button = new System.Windows.Forms.Button();
            this.del_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.catagoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.superMarketDataSet = new SuperMarket.superMarketDataSet();
            this.catagoriesTableAdapter = new SuperMarket.superMarketDataSetTableAdapters.CatagoriesTableAdapter();
            this.Descrip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cat_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.catIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // exiit_button
            // 
            this.exiit_button.BackColor = System.Drawing.Color.GhostWhite;
            this.exiit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exiit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exiit_button.Location = new System.Drawing.Point(894, 21);
            this.exiit_button.Name = "exiit_button";
            this.exiit_button.Size = new System.Drawing.Size(96, 54);
            this.exiit_button.TabIndex = 21;
            this.exiit_button.Text = "EXIT";
            this.exiit_button.UseVisualStyleBackColor = false;
            this.exiit_button.Click += new System.EventHandler(this.exiit_button_Click);
            // 
            // sell_button
            // 
            this.sell_button.BackColor = System.Drawing.Color.GhostWhite;
            this.sell_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sell_button.Location = new System.Drawing.Point(378, 21);
            this.sell_button.Name = "sell_button";
            this.sell_button.Size = new System.Drawing.Size(154, 49);
            this.sell_button.TabIndex = 20;
            this.sell_button.Text = "Sellers";
            this.sell_button.UseVisualStyleBackColor = false;
            this.sell_button.Click += new System.EventHandler(this.sell_button_Click);
            // 
            // prod_button
            // 
            this.prod_button.BackColor = System.Drawing.Color.GhostWhite;
            this.prod_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_button.Location = new System.Drawing.Point(209, 21);
            this.prod_button.Name = "prod_button";
            this.prod_button.Size = new System.Drawing.Size(154, 49);
            this.prod_button.TabIndex = 19;
            this.prod_button.Text = "Products";
            this.prod_button.UseVisualStyleBackColor = false;
            this.prod_button.Click += new System.EventHandler(this.prod_button_Click);
            // 
            // cat_button
            // 
            this.cat_button.BackColor = System.Drawing.Color.GhostWhite;
            this.cat_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat_button.Location = new System.Drawing.Point(40, 21);
            this.cat_button.Name = "cat_button";
            this.cat_button.Size = new System.Drawing.Size(154, 49);
            this.cat_button.TabIndex = 18;
            this.cat_button.Text = "Catagories";
            this.cat_button.UseVisualStyleBackColor = false;
            // 
            // del_button
            // 
            this.del_button.BackColor = System.Drawing.Color.GhostWhite;
            this.del_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.del_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_button.Location = new System.Drawing.Point(246, 470);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(117, 54);
            this.del_button.TabIndex = 25;
            this.del_button.Text = "DELETE";
            this.del_button.UseVisualStyleBackColor = false;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.GhostWhite;
            this.edit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.Location = new System.Drawing.Point(126, 470);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(114, 54);
            this.edit_button.TabIndex = 24;
            this.edit_button.Text = "EDIT";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.GhostWhite;
            this.add_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(12, 470);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(108, 54);
            this.add_button.TabIndex = 23;
            this.add_button.Text = "ADD";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catIDDataGridViewTextBoxColumn,
            this.catNameDataGridViewTextBoxColumn,
            this.catDescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.catagoriesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(369, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(621, 378);
            this.dataGridView1.TabIndex = 22;
            // 
            // catagoriesBindingSource
            // 
            this.catagoriesBindingSource.DataMember = "Catagories";
            this.catagoriesBindingSource.DataSource = this.superMarketDataSet;
            // 
            // superMarketDataSet
            // 
            this.superMarketDataSet.DataSetName = "superMarketDataSet";
            this.superMarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catagoriesTableAdapter
            // 
            this.catagoriesTableAdapter.ClearBeforeFill = true;
            // 
            // Descrip
            // 
            this.Descrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descrip.Location = new System.Drawing.Point(199, 323);
            this.Descrip.Name = "Descrip";
            this.Descrip.Size = new System.Drawing.Size(164, 27);
            this.Descrip.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Catagory description";
            // 
            // cat_name
            // 
            this.cat_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat_name.Location = new System.Drawing.Point(199, 269);
            this.cat_name.Name = "cat_name";
            this.cat_name.Size = new System.Drawing.Size(164, 27);
            this.cat_name.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Catagory Name";
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(199, 213);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(164, 27);
            this.ID.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Catagory ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 36);
            this.label4.TabIndex = 32;
            this.label4.Text = "Catagory Management";
            // 
            // catIDDataGridViewTextBoxColumn
            // 
            this.catIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.catIDDataGridViewTextBoxColumn.DataPropertyName = "catID";
            this.catIDDataGridViewTextBoxColumn.HeaderText = "catID";
            this.catIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.catIDDataGridViewTextBoxColumn.Name = "catIDDataGridViewTextBoxColumn";
            // 
            // catNameDataGridViewTextBoxColumn
            // 
            this.catNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.catNameDataGridViewTextBoxColumn.DataPropertyName = "catName";
            this.catNameDataGridViewTextBoxColumn.HeaderText = "catName";
            this.catNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.catNameDataGridViewTextBoxColumn.Name = "catNameDataGridViewTextBoxColumn";
            // 
            // catDescriptionDataGridViewTextBoxColumn
            // 
            this.catDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.catDescriptionDataGridViewTextBoxColumn.DataPropertyName = "catDescription";
            this.catDescriptionDataGridViewTextBoxColumn.HeaderText = "catDescription";
            this.catDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.catDescriptionDataGridViewTextBoxColumn.Name = "catDescriptionDataGridViewTextBoxColumn";
            // 
            // Admin_cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 536);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Descrip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cat_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.del_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exiit_button);
            this.Controls.Add(this.sell_button);
            this.Controls.Add(this.prod_button);
            this.Controls.Add(this.cat_button);
            this.Name = "Admin_cat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_cat";
            this.Load += new System.EventHandler(this.Admin_cat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exiit_button;
        private System.Windows.Forms.Button sell_button;
        private System.Windows.Forms.Button prod_button;
        private System.Windows.Forms.Button cat_button;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private superMarketDataSet superMarketDataSet;
        private System.Windows.Forms.BindingSource catagoriesBindingSource;
        private superMarketDataSetTableAdapters.CatagoriesTableAdapter catagoriesTableAdapter;
        private System.Windows.Forms.TextBox Descrip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cat_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catDescriptionDataGridViewTextBoxColumn;
    }
}