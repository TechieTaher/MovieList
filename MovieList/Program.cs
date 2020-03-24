using MovieList.Domain;
using MovieList.Models;
using System;
using System.Collections.Generic;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Movie List Application");
            bool showMenu = true;
            ArtistDomain artistDomain = new ArtistDomain();
            MovieDomain movieDomain = new MovieDomain();
            IndustryDomain industryDomain = new IndustryDomain();
            CategoryDomain categoryDomain = new CategoryDomain();
            MovieCategoryDomain movieCategoryDomain= new MovieCategoryDomain();
            MovieArtistDomain movieArtistDomain= new MovieArtistDomain();
            HashSet<MovieArtist> movieArtists = new HashSet<MovieArtist>();
            HashSet<MovieCategory> movieCategories= new HashSet<MovieCategory>();
            while (showMenu)
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Add Actor");
                Console.WriteLine("2) Add Industry");
                Console.WriteLine("3) Add Category");
                Console.WriteLine("4) Add Movie");
                Console.WriteLine("5) List Movie");
                Console.WriteLine("6) Exit");
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
                        {
                            Industry industry= new Industry();
                            Console.Write("Enter Name : ");
                            industry.IndustryName = Console.ReadLine().Trim();
                            Console.Write("Enter Country : ");
                            industry.Country = Console.ReadLine().Trim();
                            industryDomain.AddIndustry(industry);
                            Console.Write("Industry Added");
                            Console.ReadLine();
                            break;
                        }
                    case "3":
                        {
                            Category category= new Category();
                            Console.Write("Enter Name : ");
                            category.CategoryName = Console.ReadLine().Trim();
                            categoryDomain.AddCategory(category);
                            Console.Write("Category Added");
                            Console.ReadLine();
                            break;
                        }
                    case "4":
                        {
                            Movie movie = new Movie();
                            Console.Write("Enter Movie Name : ");
                            movie.MovieName = Console.ReadLine().Trim();
                            Console.Write("Enter Rating (4.5) : ");
                            movie.Rating = Convert.ToDecimal(Console.ReadLine().Trim());
                            Console.Write("Enter Relase Date : ");
                            movie.ReleaseDate = Convert.ToDateTime(Console.ReadLine().Trim()).Date;
                            Console.WriteLine("No     Industry Name     Country");
                            foreach (Industry industry in industryDomain.GetIndustries())
                            {
                                Console.WriteLine($"{industry.IndustryId}     {industry.IndustryName}     {industry.Country}");
                            }
                            Console.Write("Select Industry by No : ");
                            movie.IndustryId = Convert.ToInt32(Console.ReadLine().Trim());
                            movieDomain.AddMovie(movie);
                            Console.WriteLine("No     Artist Name");
                            foreach (Artist artist in artistDomain.GetArtists())
                            {
                                Console.WriteLine($"{artist.ArtistId}     {artist.ArtistName}");
                            }
                        addArist:
                            Console.Write("Select Artist by No : ");
                            MovieArtist movieArtist = new MovieArtist();
                            movieArtist.ArtistId = Convert.ToInt32(Console.ReadLine());
                            movieArtist.MovieId = movie.MovieId;
                            movieArtists.Add(movieArtist);
                            Console.WriteLine("You want to add More Artist?");
                            Console.WriteLine("1) Yes");
                            Console.WriteLine("2) No");
                            Console.Write("Enter your option : ");
                            string option = Console.ReadLine().Trim();
                            if (option.Equals("1"))
                            {
                                goto addArist;
                            }
                            else
                            {
                                movieArtistDomain.AddMovieArtist(movieArtists);
                                option = "";
                            }

                            Console.WriteLine("No     Category Name");
                            foreach (Category category in categoryDomain.GetCategories())
                            {
                                Console.WriteLine($"{category.CategoryId}     {category.CategoryName}");
                            }
                        addCategory:
                            Console.Write("Select Category by No : ");
                            MovieCategory movieCategory = new MovieCategory();
                            movieCategory.CategoryId = Convert.ToInt32(Console.ReadLine());
                            movieCategory.MovieId = movie.MovieId;
                            movieCategories.Add(movieCategory);
                            Console.WriteLine("You want to add More Category?");
                            Console.WriteLine("1) Yes");
                            Console.WriteLine("2) No");
                            Console.Write("Enter your option : ");
                            option = Console.ReadLine().Trim();
                            if (option.Equals("1"))
                            {
                                goto addCategory;
                            }
                            else
                            {
                                movieCategoryDomain.AddMovieCategory(movieCategories);
                            }
                            Console.Write("Movie Added");
                            Console.ReadLine();
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("No     Movie Name     Rating     IndustryId     ReleaseDate");
                            foreach (Movie movie in movieDomain.GetMovies())
                            {
                                Console.WriteLine($"{movie.MovieId}     {movie.MovieName}     {movie.Rating}     {movie.Industry.IndustryName}     {movie.ReleaseDate}");
                                foreach(MovieArtist movieArtist in movie.MovieArtists)
                                {
                                    Console.WriteLine(movieArtist.Artist.ArtistName);
                                }
                                foreach (MovieCategory movieCategory in movie.MovieCategories)
                                {
                                    Console.WriteLine(movieCategory.Category.CategoryName);
                                }

                            }
                            Console.ReadLine();
                            break;
                        }
                    case "6":
                        showMenu = false;
                        break;
                    default:
                        Console.WriteLine("please enter correct option");
                        break;
                }
            }
        }
        
    }
    



}
