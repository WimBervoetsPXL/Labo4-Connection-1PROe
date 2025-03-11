using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_4___Connection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deel 1
            // Gebruik de connectionstring uit de Settings file om een connectie te openen

            // Deel 2
            // INSERT
            // Maak een hardcoded INSERT-query met een SqlCommand die een nieuwe club toevoegt

            // DELETE
            // Verwijder Arsenal uit de tabel met behulp van een SqlCommand en SqlParameter.


            // Deel 3
            // Implementeer UpdateCapacityById() en gebruik een try catch waar nodig    
            Console.WriteLine("Geef een club id in:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef een nieuwe capaciteit in:");
            int capacity = int.Parse(Console.ReadLine());

            UpdateCapacityById(id, capacity);
        }

        private static void UpdateCapacityById(int id, int capacity)
        {
            // Deel 3
            throw new NotImplementedException();
        }
    }
}
