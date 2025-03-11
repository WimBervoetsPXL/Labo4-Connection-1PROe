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

        if(Data.CreateClub() == 1)
        {
            Console.WriteLine("Club succesvol aangemaakt.");
        }

        // DELETE
        // Verwijder Arsenal uit de tabel met behulp van een SqlCommand en SqlParameter.
        Console.WriteLine("Welke ploeg wilt u verwijderen?");
        string clubName = Console.ReadLine();

        if(Data.DeleteClub(clubName) == 1)
        {
            Console.WriteLine("Club succesvol verwijderd.");
        }

        // Deel 3
        // Implementeer UpdateCapacityById() en gebruik een try catch waar nodig    
        Console.WriteLine("Geef een club id in:");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("Geef een nieuwe capaciteit in:");
        int capacity = int.Parse(Console.ReadLine());

        if(Data.UpdateCapacityById(id, capacity) == 1)
        {
            Console.WriteLine("Capaciteit succesvol aangepast.");
        }

        foreach(FootballClub club in Data.GetAllClubs())
        {
            Console.WriteLine(club.ToString());
        }
    }
}
