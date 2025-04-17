namespace Software1Project
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InventoryBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MaxBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MinBox1 = new System.Windows.Forms.TextBox();
            this.DataGrid1 = new System.Windows.Forms.DataGridView();
            this.DataGrid2 = new System.Windows.Forms.DataGridView();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.SearchtextBox1 = new System.Windows.Forms.TextBox();
            this.Addbutton1 = new System.Windows.Forms.Button();
            this.Deletebutton1 = new System.Windows.Forms.Button();
            this.Savebutton1 = new System.Windows.Forms.Button();
            this.Cancelbutton1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(91, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // IDBox1
            // 
            this.IDBox1.Location = new System.Drawing.Point(148, 116);
            this.IDBox1.Name = "IDBox1";
            this.IDBox1.Size = new System.Drawing.Size(159, 22);
            this.IDBox1.TabIndex = 2;
            this.IDBox1.TextChanged += new System.EventHandler(this.IDBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(69, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // NameBox1
            // 
            this.NameBox1.Location = new System.Drawing.Point(148, 154);
            this.NameBox1.Name = "NameBox1";
            this.NameBox1.Size = new System.Drawing.Size(159, 22);
            this.NameBox1.TabIndex = 4;
            this.NameBox1.TextChanged += new System.EventHandler(this.NameBox1_TextChanged);
            this.NameBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(46, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Inventory";
            // 
            // InventoryBox1
            // 
            this.InventoryBox1.Location = new System.Drawing.Point(148, 196);
            this.InventoryBox1.Name = "InventoryBox1";
            this.InventoryBox1.Size = new System.Drawing.Size(159, 22);
            this.InventoryBox1.TabIndex = 6;
            this.InventoryBox1.TextChanged += new System.EventHandler(this.InventoryBox1_TextChanged);
            this.InventoryBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InventoryBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(69, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price";
            // 
            // PriceBox1
            // 
            this.PriceBox1.Location = new System.Drawing.Point(148, 235);
            this.PriceBox1.Name = "PriceBox1";
            this.PriceBox1.Size = new System.Drawing.Size(159, 22);
            this.PriceBox1.TabIndex = 8;
            this.PriceBox1.TextChanged += new System.EventHandler(this.PriceBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(69, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Max";
            // 
            // MaxBox1
            // 
            this.MaxBox1.Location = new System.Drawing.Point(148, 272);
            this.MaxBox1.Name = "MaxBox1";
            this.MaxBox1.Size = new System.Drawing.Size(80, 22);
            this.MaxBox1.TabIndex = 10;
            this.MaxBox1.TextChanged += new System.EventHandler(this.MaxBox1_TextChanged);
            this.MaxBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxBox1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(282, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Min";
            // 
            // MinBox1
            // 
            this.MinBox1.Location = new System.Drawing.Point(344, 272);
            this.MinBox1.Name = "MinBox1";
            this.MinBox1.Size = new System.Drawing.Size(100, 22);
            this.MinBox1.TabIndex = 12;
            this.MinBox1.TextChanged += new System.EventHandler(this.MinBox1_TextChanged);
            this.MinBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinBox1_KeyPress);
            // 
            // DataGrid1
            // 
            this.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DataGrid1.Location = new System.Drawing.Point(554, 92);
            this.DataGrid1.Name = "DataGrid1";
            this.DataGrid1.RowHeadersWidth = 51;
            this.DataGrid1.RowTemplate.Height = 24;
            this.DataGrid1.Size = new System.Drawing.Size(507, 150);
            this.DataGrid1.TabIndex = 13;
            this.DataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid1_CellContentClick);
            this.DataGrid1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataBindingComplete);
            // 
            // DataGrid2
            // 
            this.DataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.DataGrid2.Location = new System.Drawing.Point(554, 309);
            this.DataGrid2.Name = "DataGrid2";
            this.DataGrid2.RowHeadersWidth = 51;
            this.DataGrid2.RowTemplate.Height = 24;
            this.DataGrid2.Size = new System.Drawing.Size(507, 150);
            this.DataGrid2.TabIndex = 14;
            this.DataGrid2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid2_CellContentClick);
            // 
            // Searchbutton
            // 
            this.Searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Searchbutton.Location = new System.Drawing.Point(796, 42);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(75, 31);
            this.Searchbutton.TabIndex = 15;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // SearchtextBox1
            // 
            this.SearchtextBox1.Location = new System.Drawing.Point(888, 47);
            this.SearchtextBox1.Name = "SearchtextBox1";
            this.SearchtextBox1.Size = new System.Drawing.Size(173, 22);
            this.SearchtextBox1.TabIndex = 16;
            this.SearchtextBox1.TextChanged += new System.EventHandler(this.SearchtextBox1_TextChanged);
            // 
            // Addbutton1
            // 
            this.Addbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Addbutton1.Location = new System.Drawing.Point(986, 248);
            this.Addbutton1.Name = "Addbutton1";
            this.Addbutton1.Size = new System.Drawing.Size(75, 31);
            this.Addbutton1.TabIndex = 17;
            this.Addbutton1.Text = "Add";
            this.Addbutton1.UseVisualStyleBackColor = true;
            this.Addbutton1.Click += new System.EventHandler(this.Addbutton1_Click);
            // 
            // Deletebutton1
            // 
            this.Deletebutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Deletebutton1.Location = new System.Drawing.Point(986, 465);
            this.Deletebutton1.Name = "Deletebutton1";
            this.Deletebutton1.Size = new System.Drawing.Size(75, 35);
            this.Deletebutton1.TabIndex = 18;
            this.Deletebutton1.Text = "Delete";
            this.Deletebutton1.UseVisualStyleBackColor = true;
            this.Deletebutton1.Click += new System.EventHandler(this.Deletebutton1_Click);
            // 
            // Savebutton1
            // 
            this.Savebutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Savebutton1.Location = new System.Drawing.Point(905, 506);
            this.Savebutton1.Name = "Savebutton1";
            this.Savebutton1.Size = new System.Drawing.Size(75, 37);
            this.Savebutton1.TabIndex = 19;
            this.Savebutton1.Text = "Save";
            this.Savebutton1.UseVisualStyleBackColor = true;
            this.Savebutton1.Click += new System.EventHandler(this.Savebutton1_Click);
            // 
            // Cancelbutton1
            // 
            this.Cancelbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Cancelbutton1.Location = new System.Drawing.Point(986, 506);
            this.Cancelbutton1.Name = "Cancelbutton1";
            this.Cancelbutton1.Size = new System.Drawing.Size(75, 34);
            this.Cancelbutton1.TabIndex = 20;
            this.Cancelbutton1.Text = "Cancel";
            this.Cancelbutton1.UseVisualStyleBackColor = true;
            this.Cancelbutton1.Click += new System.EventHandler(this.Cancelbutton1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label8.Location = new System.Drawing.Point(551, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "All candidate Parts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label9.Location = new System.Drawing.Point(551, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Parts Associated with this Product";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PartID";
            this.Column1.HeaderText = "Part ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 75;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Inventory";
            this.Column3.HeaderText = "Inventory";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 75;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Price";
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 75;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Min";
            this.Column5.HeaderText = "Min";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 75;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Max";
            this.Column6.HeaderText = "Max";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 85;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "PartID";
            this.Column7.HeaderText = "Part ID";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 75;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Name";
            this.Column8.HeaderText = "Name";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 75;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Inventory";
            this.Column9.HeaderText = "Inventory";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 75;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Price";
            this.Column10.HeaderText = "Price";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 75;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Min";
            this.Column11.HeaderText = "Min";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 75;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Max";
            this.Column12.HeaderText = "Max";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 80;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 552);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Cancelbutton1);
            this.Controls.Add(this.Savebutton1);
            this.Controls.Add(this.Deletebutton1);
            this.Controls.Add(this.Addbutton1);
            this.Controls.Add(this.SearchtextBox1);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.DataGrid2);
            this.Controls.Add(this.DataGrid1);
            this.Controls.Add(this.MinBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MaxBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PriceBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InventoryBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InventoryBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PriceBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MaxBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MinBox1;
        private System.Windows.Forms.DataGridView DataGrid1;
        private System.Windows.Forms.DataGridView DataGrid2;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.TextBox SearchtextBox1;
        private System.Windows.Forms.Button Addbutton1;
        private System.Windows.Forms.Button Deletebutton1;
        private System.Windows.Forms.Button Savebutton1;
        private System.Windows.Forms.Button Cancelbutton1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}