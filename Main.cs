using Software1Project.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software1Project
{
    public partial class Parts : Form
    {
        private Inventory _inventory;
        private static int incrementMachineID = 0;
        public Parts()
        {
            InitializeComponent();

            _inventory = new Inventory();

            dgvParts.AutoGenerateColumns = true; 

            //Adds parts and products to MainScreen(Form1)
            dgvParts.DataSource = Inventory.AllParts;
            //dgvProducts.DataSource = Products.products;
            dgvProducts.DataSource = Inventory.Product;

            //removes the extra at the bottom
            dgvParts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToAddRows = false;

            //full row select
            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;   
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //take away multiselect
            dgvParts.MultiSelect = false;
            dgvProducts.MultiSelect = false;

            dgvParts.ReadOnly = true;
            dgvProducts.ReadOnly = true;
        }
        public bool IsPartAssociated(Part part) //added in 7/16
        {
            foreach (Products product in Main.Inventory.Product)
            {
                if (product.AssociatedParts.Contains(part))
                {
                    return true;
                }
            }
            return false;
        }
        //adds search button to Parts box
        private void Button1_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text.Trim().ToLower(); 
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
            dgvParts.DataSource = filter;
        }

        //adds Add button to Parts box
        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(_inventory);
            form2.ShowDialog();
            dgvParts.DataSource = null;
            dgvParts.DataSource = Inventory.AllParts;
        }

        //add Modify button to Parts box
        private void Button3_Click(object sender, EventArgs e)
        {
            if (!dgvParts.CurrentRow.Selected)
            {
                MessageBox.Show("Please make a selection!");
                return;
            }
            if (dgvParts.SelectedRows.Count > 0)  //populating the Form 3 modify boxes
            {
                Part selectedPart = (Part)dgvParts.SelectedRows[0].DataBoundItem;
                Form3 form3 = new Form3(_inventory, selectedPart);
                form3.ShowDialog();
                dgvParts.DataSource = null;
                dgvParts.DataSource = Inventory.AllParts;
            }

        }

        //adds Delete button to Parts box
        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvParts.CurrentRow == null || !dgvParts.CurrentRow.Selected)
                {
                    MessageBox.Show("Please make a selection!");
                    return;
                }
                
                //int Index = dgvParts.CurrentCell.RowIndex;
                Part selectedPart = (Part)dgvParts.CurrentRow.DataBoundItem;
                if (IsPartAssociated(selectedPart))
                {
                    MessageBox.Show("Part cannot be deleted while still associated with a Product.");
                    return;
                }
                DialogResult deletePartDialogResult = MessageBox.Show("Are you sure you want to delete this Part?", "DeletePart", MessageBoxButtons.YesNo);
                if (deletePartDialogResult == DialogResult.Yes)
                {
                    Main.Inventory.AllParts.RemoveAt(dgvParts.CurrentCell.RowIndex);
                    //dgvParts.ClearSelection();
                    //Main.Inventory.AllParts.Remove(selectedPart);
                    dgvParts.DataSource = null;
                    dgvParts.DataSource = Main.Inventory.AllParts;
                }
                foreach (Products product in Main.Inventory.Product)
                {
                    if (product.AssociatedParts.Contains(selectedPart))
                    {
                        product.AssociatedParts.Remove(selectedPart);
                    }
                }

                if (deletePartDialogResult == DialogResult.No)
                {
                    throw new Exception();
                }   
            }
            catch (Exception)
            { return; }
        }

        //add Search button to Products box
        private void Button5_Click(object sender, EventArgs e)
        {
            string search = SearchtextBox2.Text.Trim().ToLower();
            List<Products> filter = new List<Products>();
            foreach (Products products in Inventory.Product)
            {
                if (products.Name.ToLower().Contains(search))
                {
                    filter.Add(products);
                }

            }
            if (filter.Count == 0)
            {
                MessageBox.Show("No Matching Products Were Found!");
                return;
            }
            dgvProducts.DataSource = filter;
        }

        //adds Add button to Products box
        private void Button6_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(_inventory);
            form4.ShowDialog();
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = Inventory.Product;
            dgvProducts.Refresh(); 
        }

        //adds Modify button to Products box
        private void Button7_Click(object sender, EventArgs e)
        {

            if (!dgvProducts.CurrentRow.Selected)
            {
                MessageBox.Show("Please make a selection!");
                return;
            }
            if (dgvProducts.SelectedRows.Count > 0)  //populating the Form 3 modify boxes
            {
                Products selectedProduct = (Products)dgvProducts.SelectedRows[0].DataBoundItem;               
                Form5 form5 = new Form5(_inventory,selectedProduct);
                form5.ShowDialog();
                dgvProducts.Refresh();
            }
        }

        //adds Delete button to Products box
        private void Button8_Click(object sender, EventArgs e)
        {
            try
            { 
                if (dgvProducts.CurrentRow == null || !dgvProducts.CurrentRow.Selected)
                {
                MessageBox.Show("Please make a selection!");
                return;
                }

                Products selectedProduct = (Products)dgvProducts.CurrentRow.DataBoundItem;

                DialogResult deleteProductResult = MessageBox.Show("Are you sure you want to delete this Product?", "Delete Product", MessageBoxButtons.YesNo);
                if (deleteProductResult == DialogResult.No)
                {
                    throw new Exception();
                    //return;
                }
                if (deleteProductResult == DialogResult.Yes)
                {
                    Inventory.Product.Remove(selectedProduct); 
                    dgvProducts.DataSource = null;
                    dgvProducts.DataSource = Inventory.Product;
                    dgvProducts.ClearSelection();
                    dgvProducts.CurrentCell = null;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        //adds Exit button to Main Screen
        private void Button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvParts.ClearSelection();
            dgvProducts.ClearSelection();
        }

        private void bindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           
        }

        private void dgvParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Adds textbox for Products
        private void SearchtextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
