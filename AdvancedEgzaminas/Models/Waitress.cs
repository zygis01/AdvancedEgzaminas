using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedEgzaminas.Models
{
    public class Waitress
    {
        public string ReceiptsPath = "C:\\Users\\Zygimantas\\source\\repos\\AdvancedEgzaminas\\AdvancedEgzaminas\\TxtData\\RestaurantReceipts.txt";
        public int Id;
        public Waitress()
        {
            Id = 1;
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
            var checkFilePath = File.Exists(ReceiptsPath);
            if (checkFilePath == false)
            {
                Console.WriteLine("Receipt was not saved in restaurants txt data, \nbecause file may have been moved or corrupted.");
            }
            File.AppendAllText(ReceiptsPath, $"{DateTime.Now}\n" +
                                             $"Transaction id - {order.TransactionNum = rnd.Next(123213, 4213213)}\n" +
                                             $"Table id - {tableId}\n" +
                                             $"Customers name : {customerName}\n" +
                                             $"{food.Name} {food.Price}\n" +
                                             $"{drink.Name} {drink.Price}\n" +
                                             $"{"\n"}" +
                                             $"{"\n"}");
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
            else if (table.isEmpty == false)
            {
                Console.WriteLine("Sorry, but this table is already taken!");
                startProgram = false;
            }
        }
        internal protected void EmptyTheTable(int Id)
        {
            var x = restaurant.tables.Find(x => x.id == Id);
            x.isEmpty = false;
        }
        public void ShowAllTables()
        {
            foreach (var table in restaurant.tables)
            {
                Console.WriteLine($"Table id - {table.id}");
                Console.WriteLine($"Seats count : {table.emptySeats}");
                Console.WriteLine($"Is empty? - {table.isEmpty}");
                Console.WriteLine();
            }
        }
        public void PrintReceipt(int tableID)
        {
            Console.WriteLine("Is receipt necessary? (y/n)");
            var read = Console.ReadLine();
            if (read == "y")
            {
                // Kazka sugalvoti su cekio informacijos isspausdinimu
            }
            else if (read == "n")
            {
                Console.WriteLine("Receipt was not printed!");
            }
            else
            {
                Console.WriteLine("Bad input!..");
            }
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
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }
            for (int i = position; i <= 31; i++)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(progress.ToString() + " of " + total.ToString() + "    ");

        }
    }
}
