using System;

namespace InventoryDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            string Path = "C:/Users/muskan/DesktopInventory.json";
            Console.WriteLine("Welcome to InventoryManageMent");
            ReadInventory readInventory = new ReadInventory();
            InventoryManagementModel data = readInventory.Read(Path);

            for (int i = 0; i < data.Rice.Count; i++)
            {
                Console.WriteLine("Rice Details");

                Console.WriteLine(" Name: " + data.Rice[i].name + "  " + " Weight: " + data.Rice[i].weight + "  " + " Price: " + data.Rice[i].price);
            }
            for (int i = 0; i < data.Pulses.Count; i++)
            {
                Console.WriteLine("Pulses Details");

                Console.WriteLine(" Name: " + data.Pulses[i].name + "  " + " weight : " + data.Pulses[i].weight + " " + " Price :" + data.Pulses[i].price);
            }
            for (int i = 0; i < data.Wheat.Count; i++)
            {
                Console.WriteLine("Wheat Details");

                Console.WriteLine(" Name: " + data.Wheat[i].name + " " + " Weight: " + data.Wheat[i].weight + " " + " Price: " + data.Wheat[i].price);
            }
        }
    }
}