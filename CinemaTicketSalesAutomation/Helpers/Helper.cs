using CinemaTicketSalesAutomation.Enums;
using CinemaTicketSalesAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSalesAutomation.Helpers
{
    public class Helper
    {
        public static List<Movie> CreateMovies()
        {
            string basePath = "C:\\Users\\Enes Orhan\\Desktop\\Lessons\\CinemaTicketSalesAutomation\\CinemaTicketSalesAutomation\\Pictures\\";
            return new List<Movie>()
            {
                new Movie()
                {
                    movieName = "Interstaller",
                    category = Category.scienceFiction,
                    minute = "2 hours 49 minutes",
                    price = 50,
                    picturePath = basePath + "interstaller.jpg"
                },
                new Movie()
                {
                    movieName = "Don't Breathe",
                    category = Category.thriller,
                    minute = "1 hours 28 minutes",
                    price = 40,
                    picturePath = basePath + "dontBreathe.png"
                },
                new Movie()
                {
                    movieName = "3 Idiots",
                    category = Category.comedy,
                    minute = "2 hours 51 minutes",
                    price = 60,
                    picturePath = basePath + "ThreeIdiots.jpg"
                },
                new Movie()
                {
                    movieName = "Back to The Future",
                    category = Category.adventure,
                    minute = "1 hours 56 minutes",
                    price = 50,
                    picturePath = basePath + "bakToFuture.jpg"
                },
                new Movie()
                {
                    movieName = "Jumanji",
                    category = Category.adventure,
                    minute = "1 hours 44 minutes",
                    price = 50,
                    picturePath = basePath + "Jumanji.jpg"
                },
                new Movie()
                {
                    movieName = "Warcraft",
                    category = Category.fantastic,
                    minute = "2 hours 3 minutes",
                    price = 40,
                    picturePath = basePath + "warcraft.jpg"
                },
            };
        }
    }
}
