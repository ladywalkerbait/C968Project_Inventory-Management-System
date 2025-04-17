using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Software1Project.Main
{
    public class Inventory
    {
        public static BindingList<Products> Product { get; set; } //= new BindingList<Products>();
        public static BindingList<Part> AllParts { get; set; } = new BindingList<Part>();
        private int nextPartID = 4;
        
        public Inventory()
        {
            AllParts = new BindingList<Part>();
            AllParts.Add(new Inhouse(0, "Wheel", 15, 12.11m, 5, 25, 50));
            AllParts.Add(new Inhouse(1, "Pedal", 11, 8.22m, 5, 25, 51));
            AllParts.Add(new Inhouse(2, "Chain", 12, 8.33m, 5, 25, 52));
            AllParts.Add(new Outsourced(3, "Seat", 8, 4.55m, 2, 15, "ABC Company"));

            Product = new BindingList<Products>();
            Product.Add(new Products(0, "Red Bicycle", 15, 11.44m, 1, 25));  
            Product.Add(new Products(1, "Yellow Bicycle", 19, 9.66m, 1, 20));
            Product.Add(new Products(2, "Blue Bicycle", 5, 12.77m, 1, 25));

            Product[0].AssociatedParts.Add(AllParts[0]); //added to populate associated parts grid
            Product[1].AssociatedParts.Add(AllParts[1]);
            Product[2].AssociatedParts.Add(AllParts[2]);
           
        }

        public void addProduct(Products product)
        {
            product.ProductID = nextProductID++;
            Product.Add(product);
        }

        public bool removeProduct(int ProductID)
        {
            for (int i = 0; i < Product.Count; i++)
            {
                if (Product[i].ProductID == ProductID)
                {
                    Product.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public Products lookupProduct(int ProductID)
        {
            foreach (Products product in Product) 
            {
                if (product.ProductID == ProductID)
                {
                    return product;
                }
            }
            return null;
        }
        public static void updateProduct(Products updateProduct)
        {
            foreach (Products product in Product)
            {
                for (int i = 0; i < Product.Count; i++)
                {
                    if (Product[i].ProductID == updateProduct.ProductID)
                    {
                        Product[i] = updateProduct;
                        break;
                    }
                }
            }
        }
        
        public void addPart(Part part) 
        {
            part.PartID = nextPartID++; 
            AllParts.Add(part);
        }

        public bool deletePart(int PartID)
        {
            for (int i = 0; i < AllParts.Count; i++) 
            {
                if (AllParts[i].PartID == PartID)
                {
                    AllParts.RemoveAt(i);
                    return true;
                }
            }
            return false;
        
        }
        public Part lookupPart(int PartID)
        {
            foreach (var part in AllParts)
            {
                if (part.PartID == PartID)
                {
                    return part;
                }
            }
            return null;
        }

        public void updatePart(int PartID, Part updatepart)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == updatepart.PartID) 
                { 
                    AllParts[i] = updatepart; 
                    break;
                }
            }
        }

        private static int incrementMachineID = 50;
        public static int GetMachineID()
        {
        return incrementMachineID++; 
        }

        private static int nextProductID = 3;
        public static int GetProductID()
        {
            return nextProductID++;
        }
    }
    
}
