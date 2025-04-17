using Software1Project.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Software1Project
{
    public partial class Form2 : Form
    {
        private Inventory _inventory;

        //adding autoincrement
        private static int IDBox = 0;

        public Form2(Inventory inventory)
        {
            InitializeComponent();

            _inventory = inventory;

            MachineIDBox1.Text = Main.Inventory.GetMachineID().ToString();

            NameBox1.BackColor = Color.Orange;
            InventoryBox1.BackColor = Color.Orange;
            PriceBox1.BackColor = Color.Orange;
            MinBox1.BackColor = Color.Orange;
            MaxBox1.BackColor = Color.Orange;
            MachineIDBox1.BackColor = Color.Orange;
       
            //autoincrement for ID textbox
            IDBox++;
            IDBox1.Text = IDBox.ToString("0");
            IDBox1.ReadOnly = true;
        }


        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MachineID.Text = "Machine ID";
            MachineIDBox1.Name = "MachineIDText";

            try
            {
                CheckifNum(MachineIDBox1.Text);
                System.Windows.Forms.ToolTip toolTipNum = new System.Windows.Forms.ToolTip();
                toolTipNum.SetToolTip(MachineIDBox1, "Machine ID number required.");
                MachineIDBox1.BackColor = Color.White;
            }
            catch (Exception)
            {
                System.Windows.Forms.ToolTip toolTipNum = new System.Windows.Forms.ToolTip();
                toolTipNum.SetToolTip(MachineIDBox1, "Machine ID number required.");
                MachineIDBox1.BackColor = Color.Orange;
            }

            if ((radioButton1.Checked) || (string.IsNullOrWhiteSpace(radioButton1.Text)))
            {
                Savebutton.Enabled = false;    
            }
            else
            { 
                Savebutton.Enabled = true; 
            }
        }

        public void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MachineID.Text = "Company Name";
            MachineIDBox1.Name = "CompanyNameText";

            if(string.IsNullOrEmpty(MachineIDBox1.Text))
            {
                System.Windows.Forms.ToolTip toolTipEmpty = new System.Windows.Forms.ToolTip();
                toolTipEmpty.SetToolTip(MachineIDBox1, "Please enter Company Name");
                MachineIDBox1.BackColor = Color.Orange;
            }
            else
            {
                System.Windows.Forms.ToolTip toolTipEmpty = new System.Windows.Forms.ToolTip();
                toolTipEmpty.SetToolTip(MachineIDBox1, "Please enter Company Name");
                MachineIDBox1.BackColor= Color.White;
            }

            if ((radioButton2.Checked) || (string.IsNullOrWhiteSpace(radioButton2.Text)))
            {  
                Savebutton.Enabled = false; 
            }
            else 
            { 
                Savebutton.Enabled = true; 
            }
        }
        private void CheckifNum(string checkData)
        {
            var isNum = int.TryParse(checkData, out int n);
            if (isNum == false) 
            {
                throw new Exception();
            }
        }
        private void CheckIfDeci(string checkDeci) 
        {
            decimal decNum;
            var isDecimal = decimal.TryParse(checkDeci, out decNum);
            if(isDecimal == false) 
            {
                MessageBox.Show("Price textbox accepts only numbers and decimals! Please check input and try again.");
            }
        }

        private void IDBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameBox1.Text))
            {
                NameBox1.BackColor = Color.Orange;
                Savebutton.Enabled = false;
            }
            else 
            { 
                NameBox1.BackColor = Color.White;
                EnableSavebutton(); 
            }
        }

        private void InventoryBox1_TextChanged(object sender, EventArgs e)
        {
   
            if (string.IsNullOrEmpty(InventoryBox1.Text))
            {
                InventoryBox1.BackColor = Color.Orange;
                Savebutton.Enabled = false;
            }
            else
            {
                InventoryBox1.BackColor = Color.White;
                EnableSavebutton();
            }
        }

        private void PriceBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PriceBox1.Text))
            {
                PriceBox1.BackColor = Color.Orange;
                Savebutton.Enabled = false;
            }
            else
            {
                CheckIfDeci(PriceBox1.Text);
                PriceBox1.BackColor = Color.White;
                EnableSavebutton();
            }
        }

        private void MaxBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MaxBox1.Text))
            {
                MaxBox1.BackColor = Color.Orange;
                Savebutton.Enabled = false;
            }
            else
            {
                CheckifNum(MaxBox1.Text);
                MaxBox1.BackColor = Color.White;
                EnableSavebutton();
            }
        }

        private void MinBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MinBox1.Text))
            {
                MinBox1.BackColor = Color.Orange;
                Savebutton.Enabled = false;
            }
            else
            {
                CheckifNum(MinBox1.Text);
                MinBox1.BackColor = Color.White;
                EnableSavebutton();
            }
        }

        private void MachineIDBox1_TextChanged(object sender, EventArgs e)
        {
           if(radioButton1.Checked)
            {
                if (string.IsNullOrWhiteSpace(MachineIDBox1.Text) || !(int.TryParse(MachineIDBox1.Text, out int x)))
                {
                    MachineIDBox1.BackColor = Color.Orange;
                    Savebutton.Enabled = false;
                }
                else
                {
                    MachineIDBox1.BackColor = Color.White;
                    EnableSavebutton();
                }
            }
           if(radioButton2.Checked)
            {
                if(string.IsNullOrWhiteSpace(MachineIDBox1.Text))
                {
                    MachineIDBox1.BackColor = Color.Orange;
                    Savebutton.Enabled = false;
                }
                else
                {
                    MachineIDBox1.BackColor = Color.White;
                    EnableSavebutton();
                }
            }
        }
       private void EnableSavebutton()
        {
            if ((NameBox1.BackColor == Color.White) && (InventoryBox1.BackColor == Color.White) && (PriceBox1.BackColor == Color.White) && (MaxBox1.BackColor == Color.White) && (MinBox1.BackColor == Color.White) && (MachineIDBox1.BackColor == Color.White))
            {
                Savebutton.Enabled = true;
            }
        }

        private static void CompareMinMax(int min, int max)
        {
            if (min > max)
            {
                throw new Exception("Min cannot be greater than Max");
            }
        }

        private static void CheckInventoryValues(int inv, int min, int max)
        {
            if (inv < min || inv > max)
            {
                throw new Exception("Inventory cannot be less than Min or greater than Max");
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                CompareMinMax(Int32.Parse(MinBox1.Text), Int32.Parse(MaxBox1.Text));
                CheckInventoryValues(Int32.Parse(InventoryBox1.Text), Int32.Parse(MinBox1.Text), Int32.Parse(MaxBox1.Text));

                if (radioButton1.Checked)
                {
                    Part inHouse = new Inhouse((Main.Inventory.AllParts.Count + 1), NameBox1.Text, Int32.Parse(InventoryBox1.Text), Decimal.Parse(PriceBox1.Text), Int32.Parse(MinBox1.Text), Int32.Parse(MaxBox1.Text), Int32.Parse(MachineIDBox1.Text));
                    _inventory.addPart(inHouse);
                }
                else if (radioButton2.Checked)
                {
                    Part outSourced = new Outsourced((Main.Inventory.AllParts.Count + 1), NameBox1.Text, Int32.Parse(InventoryBox1.Text), Decimal.Parse(PriceBox1.Text), Int32.Parse(MinBox1.Text), Int32.Parse(MaxBox1.Text), MachineIDBox1.Text);
                    _inventory.addPart(outSourced);
                }
                this.Close();
            }
            catch (Exception x) 
            { 
                MessageBox.Show(x.Message);
            }

        }


        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Alerts user to improper input
        private void NameBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Name textbox may accept only letters! Please check your input and try again.");
                //NameBox1.Text = string.Empty;
                e.Handled = true;
                return;
            }           
        }

        //Alerts user to improper input
        private void InventoryBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("Inventory textbox may accept only numbers! Please check your input and try again.");
                //InventoryBox1.Text = string.Empty;
                e.Handled = true;
                return;
            }
        }

        //Alerts user to improper input
        private void MaxBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("Max textbox may accept only numbers! Please check your input and try again.");
                //MaxBox1.Text = string.Empty;
                e.Handled = true;
                return;
            }
        }

        //Alerts user to improper input
        private void MinBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("Min textbox may accept only numbers! Please check your input and try again.");
                //MinBox1.Text = string.Empty;
                e.Handled = true;
                return;
            }
        }

        private void Savebutton_TextChanged(object sender, EventArgs e)
        {
            Savebutton.Enabled = true; 

        }

    }
}
