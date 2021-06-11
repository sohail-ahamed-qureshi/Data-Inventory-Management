using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Data_Inventory_Management
{
    class Program
    {
        /// <summary>
        /// creating a json file and adding inventory to it and
        /// reading json file and deserializing it to string format
        /// also calculating the total value for inventory.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            inventory.GetData();

        }
    }
}
