using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace Data_Inventory_Management
{
    class DataInventortyManagement
    {
        /// <summary>
        /// GetData() method of Inventory class, 
        /// getting data from Json file - consisting of data inventories.
        /// file - DataInventory.json
        /// </summary>
        public void GetData()
        {
            string filepath = @"C:\Users\Admin\Desktop\BridgeLabs Assignments\Inventory Management\Data-Inventory-Management\Data-Inventory-Management\DataInventory.json";
            try
            {
                if (File.Exists(filepath))
                {
                    string inverntoryData = File.ReadAllText(filepath);
                    Root root  = JsonConvert.DeserializeObject<Root>(inverntoryData);
                    List<Inventory> inventories = root.inventories;
                    foreach (Inventory inventory in inventories)
                    {
                        Console.WriteLine($" Name: {inventory.Name} \n Weight: {inventory.Weight}kg(s) \n Price: Rs.{inventory.Price}/kg");
                        double totalPrice = CalulateInventory(inventory.Weight, inventory.Price);
                        Console.WriteLine($"Total Price of {inventory.Name}: Rs.{totalPrice} \n");
                    }
                }
                else
                {
                    Console.WriteLine("File Not found");
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private double CalulateInventory(int weight, double price)
        {
            double totalPrice = weight * price;
            return totalPrice;   
        }
    }
}
