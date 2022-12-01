using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedEgzaminas.Models
{
    public class Padaveja
    {
        public int Id { get; set; }

        public Padaveja(int id)
        {
            Id = id;
        }
        public void RegistruotiUzsakyma(int staliukoNumeris)
        {
            Console.WriteLine($"Staliuko numeris: {staliukoNumeris}");
            Console.WriteLine($"Preke - ....\nKaina - ....€");
            
            //Funkcija uzimamas staliukas.
            //Taip pat turi buti galimybe pazymeti kad staliukas atsilaisvino.

            //Parodyti visus staliukus ir pazymeti kurie yra uzimti.

            //Prekes ir gerimai failuose - food.txt || drinks.txt

        }
        public void SpausdintiCeki(int staliukoNumeris)
        {
            //Leisti klientui pasirinkti ar nori cekio,
            //jei taip, isspausdinti konsoleje.
            
            //Issaugoti cekio informacija ir restoranui reikalingus cekio duomenis i faila.

        }
        public void SiustiCekiEmailu(int cekioNumeris)
        {

        }
    }
}
