using CO550_Project_Blazor_V2.Pages;
using Microsoft.Data.SqlClient;
using CO550_Project_Blazor_V2.Models.Services;

namespace CO550_Project_Blazor_V2.Models.Services
{
    public class TicketBookingService
    {
        public static List<FilmBooking> SelectedItems { get; set; } = new List<FilmBooking>();

        public FilmService FS { get; set; }

        public static List<string> FilmTitles = new List<string>();

        public static List<string> FilmGenres = new List<string>();

        public static List<string> CanceledBookings = new List<string>();


        public FilmBooking booking { get; set; }

        DatabaseAddress dbAddress = new DatabaseAddress();

        List<DatabaseAddress> DBaddresses = new List<DatabaseAddress>();

        public bool IsBooked { get; set; }

        public void BookTicket(string filmID)
        {

            if (FilmIsBooked(filmID) is false)
            {
                FilmBooking booking = new FilmBooking();
                var DBAddress = FilmService.DBaddresses.First(DBAddress => DBAddress.FilmID == filmID);
                booking.MovieService.dbAddress = DBAddress;
                booking.PurchasePrice = DBAddress.Price;
                SelectedItems.Add(booking);
            }


        }

        public bool FilmIsBooked(string filmID)
        {
            foreach (FilmBooking booking in SelectedItems)
            {
                if (booking.DBAddress.FilmID == filmID)
                {
                    booking.Quantity++;
                    return true;
                }
            }
            return false;
        }

        public void BookMovie(DatabaseAddress address)
        {
            FilmTitles.Add(address.Title);
            FilmTitles.ToArray();
            
        }

        public void CancelBooking(string MovieName)
        {
           FilmTitles = new List<string>();
            FilmTitles.Add(MovieName);
            if(MovieName == "Top Gun: Maverick")
            {
                FilmTitles.Remove(MovieName);
            }
            else if(MovieName == "Inception")
            {
               FilmTitles.Remove("Inception");
            }
            else if (MovieName == "Cloud 9")
            {
                FilmTitles.Remove("Cloud 9");
            }
            else if (MovieName == "The Man from U.N.C.L.E")
            {
                FilmTitles.Remove("The Man from U.N.C.L.E");
            }
            else if (MovieName == "Guardians of the Galaxy")
            {
                FilmTitles.Remove("Guardians of the Galaxy");
            }
            else if (MovieName == "Bird Box")
            {
                FilmTitles.Remove("Bird Box");
            }
            else if (MovieName == "Iron Man")
            {
                FilmTitles.Remove("Iron Man");
            }
            else if (MovieName == "Scarface")
            {
                FilmTitles.Remove("Scarface");
            }
            else if (MovieName == "Black Adam")
            {
                FilmTitles.Remove("Black Adam");
            }
            else if (MovieName == "Jurassic World")
            {
                FilmTitles.Remove("Jurassic World");
            }
        }
    }
}
