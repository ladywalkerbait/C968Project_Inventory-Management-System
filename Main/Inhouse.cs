using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Software1Project.Main
{
    public class Inhouse : Part 
    {

        public int MachineID { get; set; }

        public Inhouse(int partID, string name, int inventory, decimal price, int min, int max, int machineID) 
        {
            PartID = partID;
            Name = name;
            Inventory = inventory;
            Price = price;
            Min = min;
            Max = max;
            MachineID = machineID;
        }

    }
}
