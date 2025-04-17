namespace Software1Project
{
    partial class Form2
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.ID = new System.Windows.Forms.Label();
            this.IDBox1 = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameBox1 = new System.Windows.Forms.TextBox();
            this.Inventory = new System.Windows.Forms.Label();
            this.InventoryBox1 = new System.Windows.Forms.TextBox();
            this.Cost = new System.Windows.Forms.Label();
            this.PriceBox1 = new System.Windows.Forms.TextBox();
            this.Max = new System.Windows.Forms.Label();
            this.MaxBox1 = new System.Windows.Forms.TextBox();
            this.Min = new System.Windows.Forms.Label();
            this.MinBox1 = new System.Windows.Forms.TextBox();
            this.MachineID = new System.Windows.Forms.Label();
            this.MachineIDBox1 = new System.Windows.Forms.TextBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.radioButton1.Location = new System.Drawing.Point(242, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 22);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "In-House";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.radioButton2.Location = new System.Drawing.Point(471, 14);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(107, 22);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Outsourced";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ID.Location = new System.Drawing.Point(239, 75);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(22, 18);
            this.ID.TabIndex = 3;
            this.ID.Text = "ID";
            // 
            // IDBox1
            // 
            this.IDBox1.Location = new System.Drawing.Point(289, 71);
            this.IDBox1.Name = "IDBox1";
            this.IDBox1.ReadOnly = true;
            this.IDBox1.Size = new System.Drawing.Size(241, 22);
            this.IDBox1.TabIndex = 4;
            this.IDBox1.TextChanged += new System.EventHandler(this.IDBox1_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.NameLabel.Location = new System.Drawing.Point(213, 125);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(48, 18);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Name";
            // 
            // NameBox1
            // 
            this.NameBox1.Location = new System.Drawing.Point(289, 121);
            this.NameBox1.Name = "NameBox1";
            this.NameBox1.Size = new System.Drawing.Size(241, 22);
            this.NameBox1.TabIndex = 6;
            this.NameBox1.TextChanged += new System.EventHandler(this.NameBox1_TextChanged);
            this.NameBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox1_KeyPress);
            // 
            // Inventory
            // 
            this.Inventory.AutoSize = true;
            this.Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Inventory.Location = new System.Drawing.Point(194, 178);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(67, 18);
            this.Inventory.TabIndex = 7;
            this.Inventory.Text = "Inventory";
            // 
            // InventoryBox1
            // 
            this.InventoryBox1.Location = new System.Drawing.Point(289, 174);
            this.InventoryBox1.Name = "InventoryBox1";
            this.InventoryBox1.Size = new System.Drawing.Size(241, 22);
            this.InventoryBox1.TabIndex = 8;
            this.InventoryBox1.TextChanged += new System.EventHandler(this.InventoryBox1_TextChanged);
            this.InventoryBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InventoryBox1_KeyPress);
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Cost.Location = new System.Drawing.Point(183, 234);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(78, 18);
            this.Cost.TabIndex = 9;
            this.Cost.Text = "Price/Cost";
            // 
            // PriceBox1
            // 
            this.PriceBox1.Location = new System.Drawing.Point(289, 230);
            this.PriceBox1.Name = "PriceBox1";
            this.PriceBox1.Size = new System.Drawing.Size(241, 22);
            this.PriceBox1.TabIndex = 10;
            this.PriceBox1.TextChanged += new System.EventHandler(this.PriceBox1_TextChanged);
            // 
            // Max
            // 
            this.Max.AutoSize = true;
            this.Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Max.Location = new System.Drawing.Point(225, 287);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(36, 18);
            this.Max.TabIndex = 11;
            this.Max.Text = "Max";
            // 
            // MaxBox1
            // 
            this.MaxBox1.Location = new System.Drawing.Point(289, 283);
            this.MaxBox1.Name = "MaxBox1";
            this.MaxBox1.Size = new System.Drawing.Size(100, 22);
            this.MaxBox1.TabIndex = 12;
            this.MaxBox1.TextChanged += new System.EventHandler(this.MaxBox1_TextChanged);
            this.MaxBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxBox1_KeyPress);
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Min.Location = new System.Drawing.Point(448, 287);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(32, 18);
            this.Min.TabIndex = 13;
            this.Min.Text = "Min";
            // 
            // MinBox1
            // 
            this.MinBox1.Location = new System.Drawing.Point(505, 283);
            this.MinBox1.Name = "MinBox1";
            this.MinBox1.Size = new System.Drawing.Size(121, 22);
            this.MinBox1.TabIndex = 14;
            this.MinBox1.TextChanged += new System.EventHandler(this.MinBox1_TextChanged);
            this.MinBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinBox1_KeyPress);
            // 
            // MachineID
            // 
            this.MachineID.AutoSize = true;
            this.MachineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.MachineID.Location = new System.Drawing.Point(147, 338);
            this.MachineID.Name = "MachineID";
            this.MachineID.Size = new System.Drawing.Size(82, 18);
            this.MachineID.TabIndex = 15;
            this.MachineID.Text = "Machine ID";
            // 
            // MachineIDBox1
            // 
            this.MachineIDBox1.Location = new System.Drawing.Point(289, 334);
            this.MachineIDBox1.Name = "MachineIDBox1";
            this.MachineIDBox1.Size = new System.Drawing.Size(241, 22);
            this.MachineIDBox1.TabIndex = 16;
            this.MachineIDBox1.TextChanged += new System.EventHandler(this.MachineIDBox1_TextChanged);
            // 
            // Savebutton
            // 
            this.Savebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Savebutton.Location = new System.Drawing.Point(558, 388);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(68, 37);
            this.Savebutton.TabIndex = 17;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.TextChanged += new System.EventHandler(this.Savebutton_TextChanged);
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Cancelbutton.Location = new System.Drawing.Point(644, 388);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(78, 37);
            this.Cancelbutton.TabIndex = 18;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.MachineIDBox1);
            this.Controls.Add(this.MachineID);
            this.Controls.Add(this.MinBox1);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.MaxBox1);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.PriceBox1);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.InventoryBox1);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.NameBox1);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IDBox1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox IDBox1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameBox1;
        private System.Windows.Forms.Label Inventory;
        private System.Windows.Forms.TextBox InventoryBox1;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.TextBox PriceBox1;
        private System.Windows.Forms.Label Max;
        private System.Windows.Forms.TextBox MaxBox1;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.TextBox MinBox1;
        private System.Windows.Forms.Label MachineID;
        private System.Windows.Forms.TextBox MachineIDBox1;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Cancelbutton;
    }
}