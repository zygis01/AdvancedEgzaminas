
using AdvancedEgzaminas.Models;
using System.Security.Cryptography.X509Certificates;

string gerimaiPath = "C:\\Users\\Zygimantas\\source\\repos\\AdvancedEgzaminas\\AdvancedEgzaminas\\TxtData\\Gerimai.txt";
//StreamReader sr = new StreamReader(patiekalaiPath);
//var str = sr.ReadToEnd();

Console.WriteLine("Pasirinkite gerima :");
Console.WriteLine("[1] - Coca Cola\n" +
                  "[2] - Sprite\n" +
                  "[3] - Fanta\n" +
                  "[4] - Gira\n" +
                  "[5] - Redbull\n" +
                  "[6] - Negazuotas vanduo\n" +
                  "[7] - Nereikia");
var read = Int32.Parse(Console.ReadLine());

foreach (string line in File.ReadAllLines(gerimaiPath))
{
    if (line.Contains(read.ToString()))
    {
        switch (read)
        {
            case 1:
                Console.WriteLine(line);
                Console.WriteLine($"Kaina - {Gerimas.CocaCola}");
                break;
            case 2:
                Console.WriteLine(line);
                Console.WriteLine($"Kaina - {Gerimas.Sprite}");
                break;
            case 3:
                Console.WriteLine(line);
                Console.WriteLine($"Kaina - {Gerimas.Fanta}");
                break;
            case 4:
                Console.WriteLine(line);
                Console.WriteLine($"Kaina - {Gerimas.Gira}");
                break;
            case 5:
                Console.WriteLine(line);
                Console.WriteLine($"Kaina - {Gerimas.RedBull}");
                break;
            case 6:
                Console.WriteLine(line);
                Console.WriteLine($"Kaina - {Gerimas.NegazVanduo}");
                break;
            case 7:
                Console.WriteLine("Be gerimo");
                break;
            default:
                Console.WriteLine("Blogas pasirinkimas..");
                break;
        }
    }
}

