using Software1Project.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Software1Project
{
    public partial class Form5 : Form
    {
        private BindingList<Part> AssociatedParts = new BindingList<Part>();
        private Inventory _inventory;
        private Products _products;

        private static int id = 0;

        public Form5(Inventory inventory, Products products) 
        {
            InitializeComponent();

            _products = products;

            DataGrid1.DataSource = Inventory.AllParts;

            DataGrid1.ClearSelection();
            DataGrid2.ClearSelection();
            DataGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGrid2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGrid1.MultiSelect = false;
            DataGrid2.MultiSelect = false;
            DataGrid1.ReadOnly = true;
            DataGrid2.ReadOnly = true;
            DataGrid1.AllowUserToAddRows = false;
            DataGrid2.AllowUserToAddRows = false;

            NametextBox.BackColor = Color.Orange;
            InventorytextBox.BackColor = Color.Orange;
            PricetextBox.BackColor = Color.Orange;
            MintextBox.BackColor = Color.Orange;
            MaxtextBox.BackColor = Color.Orange;

            id++;
            IDtextBox.Text = id.ToString("0");

            IDtextBox.ReadOnly = true;

            PopulateForm5();
            _products = products;
        }
        public void PopulateForm5()
        {
            // IDtextBox.Text = _products.ProductID.ToString();
            NametextBox.Text = _products.Name;
            InventorytextBox.Text = _products.Inventory.ToString();
            PricetextBox.Text = _products.Price.ToString();
            MaxtextBox.Text = _products.Max.ToString();
            MintextBox.Text = _products.Min.ToString();

            DataGrid2.DataSource = _products.AssociatedParts;
        }

        private void IDtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InventorytextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PricetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaxtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MintextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addbutton2_Click(object sender, EventArgs e)
        {
            if (DataGrid1.CurrentRow != null)
            {
                Part selectedPart = (Part)DataGrid1.CurrentRow.DataBoundItem;
                AssociatedParts.Add(selectedPart);

            }
        }

        private void Deletebutton2_Click(object sender, EventArgs e)
        {
            try
            {
                Part selection = (Part)DataGrid2.SelectedRows[0].DataBoundItem; 
                DialogResult result = MessageBox.Show("Confirm Part(s) delete?", "Parts", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    throw new Exception();
                    //return;
                }
                if (result == DialogResult.Yes)
                {
                    for (int i = DataGrid2.RowCount - 1; i >= 0; i--)
                    {
                        DataGridViewRow row = DataGrid2.Rows[i];
                        Part selectedPart = (Part)DataGrid2.CurrentRow.DataBoundItem;
                        if (row.Selected)
                        {
                            _products.removeAssociatedPart(selectedPart.PartID);
                        }
                    }
                    DataGrid2.ClearSelection();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        //testing instructor help
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

        private void Savebutton2_Click(object sender, EventArgs e)
        {
            try
            {
                CompareValues(Int32.Parse(MintextBox.Text), Int32.Parse(MaxtextBox.Text));
                ValuesInBetween(Int32.Parse(InventorytextBox.Text), Int32.Parse(MintextBox.Text), Int32.Parse(MaxtextBox.Text));

                _products.Name = NametextBox.Text;
                _products.Inventory = Int32.Parse(InventorytextBox.Text);
                _products.Price = decimal.Parse(PricetextBox.Text);
                _products.Max = Int32.Parse(MaxtextBox.Text);
                _products.Min = Int32.Parse(MintextBox.Text);

                Products updateProduct = new Products(Inventory.Product.Count + 1, NametextBox.Text, Int32.Parse(InventorytextBox.Text), decimal.Parse(PricetextBox.Text), Int32.Parse(MintextBox.Text), Int32.Parse(MaxtextBox.Text));
                foreach (Part part in AssociatedParts)
                {
                    updateProduct.addAssociatedPart(part); 
                }
                //Inventory.addProduct(updateProduct);
                Inventory.updateProduct(updateProduct);

                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void Cancelbutton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Alerts user to improper input
        private void NametextBox_KeyPress(object sender, KeyPressEventArgs e)
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
        private void IDtextBox_KeyPress(object sender, KeyPressEventArgs e)
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
        private void InventorytextBox_KeyPress(object sender, KeyPressEventArgs e)
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
        private void MaxtextBox_KeyPress(object sender, KeyPressEventArgs e)
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
        private void MintextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void SearchButton1_Click(object sender, EventArgs e)
        {
            string search = SearchtextBox.Text.Trim().ToLower();
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
    }
}
