using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Data_Inventory_Management
{
    /// <summary>
    /// Inventory class with Methods GetData().
    /// </summary>
    public class Inventory
    {
        /// <summary>
        /// GetData() method of Inventory class, 
        /// getting data from Json file - consisting of data inventories.
        /// file - DataInventory.json
        /// </summary>
        public void GetData()
        {
            string filepath = @"C:\Users\Admin\Desktop\BridgeLabs Assignments\Inventory Management\Data-Inventory-Management\Data-Inventory-Management\DataInventory.json";
            var jsonOutput = File.ReadAllText(filepath);
            var jObject = JObject.Parse(jsonOutput);
            var inventoryArray = (JArray)jObject["inventories"];
            if (jObject != null)
            {
                Console.WriteLine("Inventories");
                foreach (var item in inventoryArray)
                {
                    Console.WriteLine($"Name: {item["name"]}");
                    Console.WriteLine($"Weight: {item["weight"]}kg(s)");
                    Console.WriteLine($"price: {item["price"]}.Rs/kg");
                    GetValue(item["weight"], item["price"]);
                    Console.WriteLine();
                }
            }
        }
        /// <summary>
        /// Calculating value of each inventory.
        /// passing Jtokens of weight and price 
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="price"></param>
        public void GetValue(JToken weight, JToken price)
        {
            int weightConv = weight.ToObject<int>();
            int priceConv = price.ToObject<int>();
            int totalValue = weightConv * priceConv;
            Console.WriteLine($"Value of Inventory : {totalValue}.Rs");
        }

    }
}
