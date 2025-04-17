using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1Project.Main
{
    public class Products
    {
        public BindingList<Part> AssociatedParts {  get; set; } //= new BindingList<Part>();
        


        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Inventory { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }


        public Products(int productID, string name, int inventory, decimal price, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Inventory = inventory;
            Price = price;
            Min = min;
            Max = max;
            AssociatedParts = new BindingList<Part>();
            
        }

        public void addAssociatedPart(Part part) 
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int PartID)   
        {
            for (int i = 0; i < AssociatedParts.Count; i++)
            {
                if (AssociatedParts[i].PartID == PartID)
                {
                    AssociatedParts.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public Part lookupAssociatedPart(int PartID) 
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == PartID)
                {
                    return part;
                }
            }
            return null;
        }

    }
}
