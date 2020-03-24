using MovieList.Domain;
using MovieList.Models;
using System;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Movie List Application");
            bool showMenu = true;
            ArtistDomain artistDomain = new ArtistDomain();
            while (showMenu)
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Add Actor");
                Console.WriteLine("2) Add Movie");
                Console.WriteLine("3) List Movie");
                Console.WriteLine("4) Exit");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine().Trim())
                {
                    case "1":
                        {
                            Artist artist = new Artist();
                            Console.Write("Enter Name : ");
                            artist.ArtistName=Console.ReadLine().Trim();
                            Console.Write("Enter BirthDate : ");
                            artist.BirthDate = Convert.ToDateTime(Console.ReadLine().Trim());
                            Console.Write("Enter Country : ");
                            artist.Country = Console.ReadLine().Trim();
                            artistDomain.AddArtist(artist);
                            Console.Write("Artist Added");
                            Console.ReadLine();  
                            break;
                        }
                    case "2":

                        break;
                    case "3":
                        break;
                    case "4":
                        showMenu = false;
                        break;
                    default:

                        break;
                }
            }
        }
    }
}
