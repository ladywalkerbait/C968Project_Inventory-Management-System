using Software1Project.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Software1Project
{
    public partial class Form4 : Form
    {
        private BindingList<Part> AssociatedParts = new BindingList<Part>();
        private Inventory _inventory;


        public static int Id = 0;

        public Form4(Inventory inventory)
        {
            InitializeComponent();

            _inventory = inventory;
           
            DataGrid1.DataSource = Inventory.AllParts;

            DataGrid2.DataSource = AssociatedParts; 


            NameBox1.BackColor = Color.Orange;
            InventoryBox1.BackColor = Color.Orange;
            PriceBox1.BackColor = Color.Orange;
            MinBox1.BackColor = Color.Orange;
            MaxBox1.BackColor = Color.Orange;
            


            //removes the extra at the bottom
            DataGrid1.AllowUserToAddRows = false;
            DataGrid2.AllowUserToAddRows = false;

            //full row select
            DataGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGrid2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //take away multiselect
            DataGrid1.MultiSelect = false;
            DataGrid2.MultiSelect = false;

            DataGrid1.ReadOnly = true;
            DataGrid2.ReadOnly = true;

            Id++;
            IDBox1.Text = Id.ToString("0");
            IDBox1.ReadOnly = true;
        }

        private void IDBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InventoryBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaxBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MinBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            string search = SearchtextBox1.Text.Trim().ToLower();
            List<Part> filter = new List<Part>();
            foreach (Part part in Inventory.AllParts)
            {
                if (part.Name.ToLower().Contains(search))
                {
                    filter.Add(part);
                }

            }
            if (filter.Count == 0)
            {
                MessageBox.Show("No Matching Parts Were Found!");
                return;
            }
            DataGrid1.DataSource = filter;
        }

        private void SearchtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addbutton1_Click(object sender, EventArgs e)
        {
            if (DataGrid1.CurrentRow != null)
            {
                Part selectedPart = (Part)DataGrid1.CurrentRow.DataBoundItem;
                AssociatedParts.Add(selectedPart);
            }
        }

        private void Deletebutton1_Click(object sender, EventArgs e)
        {
            Part selection = (Part)DataGrid2.SelectedRows[0].DataBoundItem;
            try
            {
                DialogResult result = MessageBox.Show("Confirm Part(s) delete?", "Parts", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    throw new Exception();
                }
                if (result == DialogResult.Yes)
                {
                    for (int i = DataGrid2.RowCount - 1; i >= 0; i--)
                    {
                        DataGridViewRow row = DataGrid2.Rows[i];
                        Part selectedPart = (Part)DataGrid2.CurrentRow.DataBoundItem;
                    }
                    DataGrid2.ClearSelection();
                }
            }
            catch (Exception)
            {
                return;
            }

            if (DataGrid2.CurrentRow != null)
            {
                Part selectedPart = (Part)DataGrid2.CurrentRow.DataBoundItem;
                AssociatedParts.Remove(selectedPart);
            }
        }
        private static void CompareValues(int min, int max)
        { 
            if (min > max)
            {
                throw new Exception("The value of Min cannot be greater than Max.");
            }
        }
        private static void ValuesInBetween(int inv, int min, int max)
        {
            if (inv < min || inv > max)
            {
                throw new Exception("Inventory cannot be greater than Max or less than Min.");
            }
        }

        private void Savebutton1_Click(object sender, EventArgs e)
        {
            try
            {
                CompareValues(Int32.Parse(MinBox1.Text), Int32.Parse(MaxBox1.Text));
                ValuesInBetween(Int32.Parse(InventoryBox1.Text), Int32.Parse(MinBox1.Text), Int32.Parse(MaxBox1.Text));

                Products newProduct = new Products(Main.Inventory.Product.Count + 1, NameBox1.Text, Int32.Parse(InventoryBox1.Text), decimal.Parse(PriceBox1.Text), Int32.Parse(MinBox1.Text), Int32.Parse(MaxBox1.Text));      

                foreach (Part part in AssociatedParts.ToList())
                {
                    newProduct.addAssociatedPart(part); 
                }
                _inventory.addProduct(newProduct);
            this.Close();
            }
            catch (Exception x) 
            { 
                MessageBox.Show(x.Message); 
            }
        }

        private void Cancelbutton1_Click(object sender, EventArgs e)
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
                MessageBox.Show("Input may accept only letters! Please check your input and try again.");
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
                MessageBox.Show("Input may accept only numbers! Please check your input and try again.");
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
                MessageBox.Show("Input may accept only numbers! Please check your input and try again.");
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
                MessageBox.Show("Input may accept only numbers! Please check your input and try again.");
                e.Handled = true;
                return;
            }
        }

        private void DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGrid1.ClearSelection();
            DataGrid2.ClearSelection(); 
        }
    }
}
