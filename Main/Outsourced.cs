using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1Project.Main
{
    public class Outsourced : Part
    {
        public string CompanyName {  get; set; }

        public Outsourced(int partID, string name, int inventory, decimal price, int min, int max, string companyName)
        {
            PartID = partID;
            Name = name;
            Inventory = inventory;
            Price = price; 
            Min = min;
            Max = max;
            CompanyName = companyName;
        }
    }
}
