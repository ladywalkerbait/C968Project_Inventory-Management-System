namespace Software1Project
{
    partial class Form3
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
            this.InHouseButton1 = new System.Windows.Forms.RadioButton();
            this.OutsourcedButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.IDtextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NametextBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InventorytextBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PricetextBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MaxtextBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MintextBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MachineIDtextBox1 = new System.Windows.Forms.TextBox();
            this.Savebutton1 = new System.Windows.Forms.Button();
            this.Cancelbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modify Part";
            // 
            // InHouseButton1
            // 
            this.InHouseButton1.AutoSize = true;
            this.InHouseButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.InHouseButton1.Location = new System.Drawing.Point(268, 12);
            this.InHouseButton1.Name = "InHouseButton1";
            this.InHouseButton1.Size = new System.Drawing.Size(89, 22);
            this.InHouseButton1.TabIndex = 1;
            this.InHouseButton1.TabStop = true;
            this.InHouseButton1.Text = "In-House";
            this.InHouseButton1.UseVisualStyleBackColor = true;
            this.InHouseButton1.CheckedChanged += new System.EventHandler(this.InHouseButton1_CheckedChanged);
            // 
            // OutsourcedButton1
            // 
            this.OutsourcedButton1.AutoSize = true;
            this.OutsourcedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.OutsourcedButton1.Location = new System.Drawing.Point(473, 14);
            this.OutsourcedButton1.Name = "OutsourcedButton1";
            this.OutsourcedButton1.Size = new System.Drawing.Size(107, 22);
            this.OutsourcedButton1.TabIndex = 2;
            this.OutsourcedButton1.TabStop = true;
            this.OutsourcedButton1.Text = "Outsourced";
            this.OutsourcedButton1.UseVisualStyleBackColor = true;
            this.OutsourcedButton1.CheckedChanged += new System.EventHandler(this.OutsourcedButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(199, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // IDtextBox1
            // 
            this.IDtextBox1.Location = new System.Drawing.Point(268, 68);
            this.IDtextBox1.Name = "IDtextBox1";
            this.IDtextBox1.Size = new System.Drawing.Size(221, 22);
            this.IDtextBox1.TabIndex = 4;
            this.IDtextBox1.TextChanged += new System.EventHandler(this.IDtextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(173, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // NametextBox1
            // 
            this.NametextBox1.Location = new System.Drawing.Point(268, 122);
            this.NametextBox1.Name = "NametextBox1";
            this.NametextBox1.Size = new System.Drawing.Size(221, 22);
            this.NametextBox1.TabIndex = 6;
            this.NametextBox1.TextChanged += new System.EventHandler(this.NametextBox1_TextChanged);
            this.NametextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NametextBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(154, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Inventory";
            // 
            // InventorytextBox1
            // 
            this.InventorytextBox1.Location = new System.Drawing.Point(268, 174);
            this.InventorytextBox1.Name = "InventorytextBox1";
            this.InventorytextBox1.Size = new System.Drawing.Size(221, 22);
            this.InventorytextBox1.TabIndex = 8;
            this.InventorytextBox1.TextChanged += new System.EventHandler(this.InventorytextBox1_TextChanged);
            this.InventorytextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InventorytextBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(143, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price/Cost";
            // 
            // PricetextBox1
            // 
            this.PricetextBox1.Location = new System.Drawing.Point(268, 228);
            this.PricetextBox1.Name = "PricetextBox1";
            this.PricetextBox1.Size = new System.Drawing.Size(221, 22);
            this.PricetextBox1.TabIndex = 10;
            this.PricetextBox1.TextChanged += new System.EventHandler(this.PricetextBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(177, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Max";
            // 
            // MaxtextBox1
            // 
            this.MaxtextBox1.Location = new System.Drawing.Point(268, 285);
            this.MaxtextBox1.Name = "MaxtextBox1";
            this.MaxtextBox1.Size = new System.Drawing.Size(123, 22);
            this.MaxtextBox1.TabIndex = 12;
            this.MaxtextBox1.TextChanged += new System.EventHandler(this.MaxtextBox1_TextChanged);
            this.MaxtextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxtextBox1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(435, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Min";
            // 
            // MintextBox1
            // 
            this.MintextBox1.Location = new System.Drawing.Point(508, 285);
            this.MintextBox1.Name = "MintextBox1";
            this.MintextBox1.Size = new System.Drawing.Size(117, 22);
            this.MintextBox1.TabIndex = 14;
            this.MintextBox1.TextChanged += new System.EventHandler(this.MintextBox1_TextChanged);
            this.MintextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MintextBox1_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(106, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Machine ID";
            // 
            // MachineIDtextBox1
            // 
            this.MachineIDtextBox1.Location = new System.Drawing.Point(268, 339);
            this.MachineIDtextBox1.Name = "MachineIDtextBox1";
            this.MachineIDtextBox1.Size = new System.Drawing.Size(221, 22);
            this.MachineIDtextBox1.TabIndex = 16;
            this.MachineIDtextBox1.TextChanged += new System.EventHandler(this.MachineIDtextBox1_TextChanged);
            // 
            // Savebutton1
            // 
            this.Savebutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Savebutton1.Location = new System.Drawing.Point(534, 386);
            this.Savebutton1.Name = "Savebutton1";
            this.Savebutton1.Size = new System.Drawing.Size(75, 37);
            this.Savebutton1.TabIndex = 17;
            this.Savebutton1.Text = "Save";
            this.Savebutton1.UseVisualStyleBackColor = true;
            this.Savebutton1.Click += new System.EventHandler(this.Savebutton1_Click);
            // 
            // Cancelbutton1
            // 
            this.Cancelbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Cancelbutton1.Location = new System.Drawing.Point(630, 386);
            this.Cancelbutton1.Name = "Cancelbutton1";
            this.Cancelbutton1.Size = new System.Drawing.Size(75, 37);
            this.Cancelbutton1.TabIndex = 18;
            this.Cancelbutton1.Text = "Cancel";
            this.Cancelbutton1.UseVisualStyleBackColor = true;
            this.Cancelbutton1.Click += new System.EventHandler(this.Cancelbutton1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancelbutton1);
            this.Controls.Add(this.Savebutton1);
            this.Controls.Add(this.MachineIDtextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MintextBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MaxtextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PricetextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InventorytextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NametextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDtextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutsourcedButton1);
            this.Controls.Add(this.InHouseButton1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton InHouseButton1;
        private System.Windows.Forms.RadioButton OutsourcedButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDtextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NametextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InventorytextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PricetextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MaxtextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MintextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MachineIDtextBox1;
        private System.Windows.Forms.Button Savebutton1;
        private System.Windows.Forms.Button Cancelbutton1;
    }
}