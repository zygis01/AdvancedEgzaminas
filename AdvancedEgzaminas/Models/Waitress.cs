using AdvancedEgzaminas.Interfaces;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedEgzaminas.Models
{
    public class Waitress : ICommands
    {
        public string ReceiptsPath = "C:\\Users\\Zygimantas\\source\\repos\\AdvancedEgzaminas\\AdvancedEgzaminas\\TxtData\\RestaurantReceipts.txt";
        public const int Id = 1;
        public Waitress()
        {

        }

        Restaurant restaurant = new Restaurant();
        Random rnd = new Random();
        
        public void RegisterOrder(string clientName, int tableID, Food chosenFood, Drink chosenDrink)
        {
            Order order = new Order
                (
                    DateTime.Now,
                    chosenFood,
                    chosenDrink,
                    clientName,
                    tableID
                );
            SaveReceipt(chosenFood, chosenDrink, tableID, clientName, order);
        }
        internal protected void SaveReceipt(Food food, Drink drink, int tableId, string customerName, Order order)
        {
            if (File.Exists(ReceiptsPath))
            {
                File.AppendAllText(ReceiptsPath, $"{DateTime.Now}\n" +
                                             $"Transaction id - {order.TransactionNum = rnd.Next(123213, 4213213)}\n" +
                                             $"Table id - {tableId}\n" +
                                             $"Customers name : {customerName}\n" +
                                             $"{food.Name} {food.Price}\n" +
                                             $"{drink.Name} {drink.Price}\n" +
                                             $"{"\n"}" +
                                             $"{"\n"}");
            }
            else
            {
                Console.WriteLine("File path was not found!..");
            }
        }
        public void ReserveTable(int tableId, bool startProgram)
        {
            var table = restaurant.tables.Find(x => x.id == tableId);

            if (table.isEmpty == true)
            {
                table.isEmpty = false;

                for (int i = 0; i < 100; i++)
                {
                    ShowProgressBar(i, 100);
                    Thread.Sleep(20);
                    Console.Clear();
                }

                Console.WriteLine("Table was successfully reserved for you!");
            }
        }
        public void ShowAllTables(bool programStart)
        {
            try
            {
                foreach (var table in restaurant.tables)
                {
                    Console.WriteLine($"Table id - {table.id}");
                    Console.WriteLine($"Seats count : {table.emptySeats}");
                    Console.WriteLine($"Is empty? - {table.isEmpty}");
                    Console.WriteLine();
                }
            }
            catch(NotImplementedException ex)
            {
                Console.WriteLine($"Error.. {ex.Message}");
                Console.WriteLine("Try again later..");
            }
            finally
            {
                programStart = false;
            }
        }
        public void PrintReceipt(Drink chosenDrink, Food chosenFood)
        {
            Console.WriteLine("Is receipt necessary? (y/n)");
            var read = Console.ReadLine();
            if (read == "y")
            {
                Console.WriteLine("Your order: ");
                Console.WriteLine();
                Console.WriteLine(DateTime.Now);
                Console.WriteLine($"{chosenDrink.Name} - {chosenDrink.Price}");
                Console.WriteLine($"{chosenFood.Name} - {chosenFood.Price}");
                Console.WriteLine($"Price = {chosenDrink.Price + chosenFood.Price}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Receipt was not printed!");
            }
        }
        public void EmptyTheTable(int Id)
        {
            var x = restaurant.tables.Find(x => x.id == Id);
            x.isEmpty = false;
        }
        public void SendReceiptToEmail(int tableId)
        {
            Console.WriteLine("Send receipt to email? (y/n) ");
            var read = Console.ReadLine();
            if (read == "y")
            {
                Console.WriteLine("Input your email adress : @gmail.com");
                var readEmail = Console.ReadLine();

                for (int i = 0; i <= 100; i++)
                {
                    ShowProgressBar(i, 100);
                    Thread.Sleep(15);
                    Console.Clear();
                }
                Console.WriteLine($"Receipt was sent to {readEmail}@gmail.com");
                
                EmptyTheTable(tableId);
            }
            else if (read == "n")
            {
                Console.WriteLine("Email wasn't sent!.");
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
        }
        internal protected static void ShowProgressBar(int progress, int total)
        {
            float oneunit = 30.0f / total;
            int position = 1;
            for (int i = 0; i < oneunit * progress; i++)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }
            for (int i = position; i <= 31; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(progress.ToString() + " of " + total.ToString() + "    ");
        }
        void ICommands.EmptyTheTable(int Id)
        {
            var x = restaurant.tables.Find(x => x.id == Id);
            x.isEmpty = false;
        }
        
    }
}
