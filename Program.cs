
﻿namespace InventoryManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = "/home/arivusurya/dailyclass/inventorymanagement/inventory.json";
            FetchInvertory fetchInvertory = new FetchInvertory();
            Console.WriteLine("Types of RIce");
             Console.WriteLine("*********************");
            InventoryDetails data= fetchInvertory.Read(path);
            for (int i =0 ; i < data.typesOfRice.Count;i++){
             
            Console.WriteLine(data.typesOfRice[i].name);
            Console.WriteLine(data.typesOfRice[i].weight);
            int price = data.typesOfRice[i].weight * data.typesOfRice[i].price;
            Console.WriteLine("The price of {0} for {1} is {2}",data.typesOfRice[i].name,data.typesOfRice[i].weight,price);
            Console.WriteLine(data.typesOfRice[i].price);
            Console.WriteLine("----------");
            }
            Console.WriteLine("Types of pulse");
             Console.WriteLine("*********************");
                 for (int i =0 ; i < data.typesOfPulses.Count;i++){
            Console.WriteLine(data.typesOfPulses[i].name);
            Console.WriteLine(data.typesOfPulses[i].weight);
            
            int price = data.typesOfPulses[i].weight * data.typesOfPulses[i].price;
            Console.WriteLine("The price of {0} for {1} is {2}",data.typesOfPulses[i].name,data.typesOfPulses[i].weight,price);
            Console.WriteLine(data.typesOfPulses[i].price);
                 }
            Console.WriteLine("Types of wheat");
             Console.WriteLine("*********************");
                 for (int i =0 ; i < data.typesOfWheat.Count;i++){
            Console.WriteLine(data.typesOfWheat[i].name);
            Console.WriteLine(data.typesOfWheat[i].weight);
            
            int price = data.typesOfWheat[i].weight * data.typesOfWheat[i].price;
            Console.WriteLine("The price of {0} for {1} is {2}",data.typesOfWheat[i].name,data.typesOfWheat[i].weight,price);
            Console.WriteLine(data.typesOfWheat[i].price);

            }
            

        }
    }
}

