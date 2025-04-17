using Software1Project.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Software1Project
{
    public partial class Form3 : Form
    {
        private Inventory _inventory;
        private Part _selectedPart;

        //adding autoincrement
        private static int ID = 0;

        public Form3(Inventory inventory, Part selectedPart)
        {
            InitializeComponent();

            _inventory = inventory;
            _selectedPart = selectedPart;

            NametextBox1.BackColor = Color.Orange;
            InventorytextBox1.BackColor = Color.Orange;
            PricetextBox1.BackColor = Color.Orange;
            MintextBox1.BackColor = Color.Orange;
            MaxtextBox1.BackColor = Color.Orange;

            IDtextBox1.ReadOnly = true;

            //autoincrement for ID textbox
            ID++;
            IDtextBox1.Text = ID.ToString("0");

            MachineIDtextBox1.Text = Main.Inventory.GetMachineID().ToString();

            PopulateForm3();
        }
        public void PopulateForm3()
        {
            IDtextBox1.Text = _selectedPart.PartID.ToString();
            NametextBox1.Text = _selectedPart.Name;
            InventorytextBox1.Text = _selectedPart.Inventory.ToString();
            PricetextBox1.Text = _selectedPart.Price.ToString();
            MaxtextBox1.Text = _selectedPart.Max.ToString();
            MintextBox1.Text = _selectedPart.Min.ToString();
            if (_selectedPart is Inhouse inHouse)
            {
                MachineIDtextBox1.Text = inHouse.MachineID.ToString();
                InHouseButton1.Checked = true;
            }
            else if (_selectedPart is Outsourced outSourced)
            {
                MachineIDtextBox1.Text = outSourced.CompanyName;
                OutsourcedButton1.Checked = true;
            }
        }

        private void InHouseButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Machine ID";
            
        }

        private void OutsourcedButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Company Name";
        }

        private void IDtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NametextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void InventorytextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PricetextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaxtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MintextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MachineIDtextBox1_TextChanged(object sender, EventArgs e)
        {

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
        private void Savebutton1_Click(object sender, EventArgs e)
        {
            try
            {
                CompareMinMax(Int32.Parse(MintextBox1.Text), Int32.Parse(MaxtextBox1.Text));
                CheckInventoryValues(Int32.Parse(InventorytextBox1.Text), Int32.Parse(MintextBox1.Text), Int32.Parse(MaxtextBox1.Text));

                _selectedPart.Name = NametextBox1.Text;
                _selectedPart.Inventory = Int32.Parse(InventorytextBox1.Text);
                _selectedPart.Price = decimal.Parse(PricetextBox1.Text);
                _selectedPart.Min = Int32.Parse(MintextBox1.Text);
                _selectedPart.Max = Int32.Parse(MaxtextBox1.Text);

                int ModID = Int32.Parse(IDtextBox1.Text); //Is this correct?
                if (InHouseButton1.Checked)
                {
                    Part inhouse = new Inhouse(Int32.Parse(IDtextBox1.Text), NametextBox1.Text, Int32.Parse(InventorytextBox1.Text), Decimal.Parse(PricetextBox1.Text), Int32.Parse(MintextBox1.Text), Int32.Parse(MaxtextBox1.Text), Int32.Parse(MachineIDtextBox1.Text));

                    _inventory.updatePart(ModID, inhouse);
                }

                else if (OutsourcedButton1.Checked)
                {
                    Part outSourced = new Outsourced(Int32.Parse(IDtextBox1.Text), NametextBox1.Text, Int32.Parse(InventorytextBox1.Text), Decimal.Parse(PricetextBox1.Text), Int32.Parse(MintextBox1.Text), Int32.Parse(MaxtextBox1.Text), MachineIDtextBox1.Text);

                    _inventory.updatePart(ModID, outSourced);
                }
                this.Close();
            }
            catch (Exception x)
                { MessageBox.Show(x.Message); }
        }

        private void Cancelbutton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Alerts user to improper input
        private void NametextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Name textbox may accept only letters! Please check your input and try again.");
                //NametextBox1.Text = string.Empty;
                e.Handled = true;
                return;
            }
        }

        //Alerts user to improper input
        private void InventorytextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("Inventory textbox may accept only numbers! Please check your input and try again.");
                //InventorytextBox1.Text = string.Empty;
                e.Handled = true;
                return;
            }
        }

        //Alerts user to improper input
        private void MaxtextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("Max textbox may accept only numbers! Please check your input and try again.");
                //MaxtextBox1.Text = string.Empty;
                e.Handled = true;
                return;
            }
        }

        //Alerts user to improper input
        private void MintextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("Min textbox may accept only numbers! Please check your input and try again.");
                //MintextBox1.Text = string.Empty;
                e.Handled = true;
                return;
            }
        }
    }
}
