using Labo4_NET8.Shared;
using Microsoft.Data.SqlClient;

namespace Labo4_NET8;

internal class Program
{
    static void Main(string[] args)
    {
        // Deel 1
        // Gebruik de connectionstring uit de Settings file om een connectie te openen
        Data.ConnectionString = Settings.Default.ConnectionString;

        Data.CreateClub();

        // DELETE
        // Verwijder Arsenal uit de tabel met behulp van een SqlCommand en SqlParameter.
        Console.WriteLine("Welke ploeg wilt u verwijderen?");
        string clubName = Console.ReadLine();

        Data.DeleteClub(clubName);

        // Deel 3
        // Implementeer UpdateCapacityById() en gebruik een try catch waar nodig    
        Console.WriteLine("Geef een club id in:");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("Geef een nieuwe capaciteit in:");
        int capacity = int.Parse(Console.ReadLine());

        Data.UpdateCapacityById(id, capacity);
    }

    
}
