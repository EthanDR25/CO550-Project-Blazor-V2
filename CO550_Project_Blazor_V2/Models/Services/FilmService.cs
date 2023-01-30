using Humanizer.Localisation;
using Humanizer;
using System.IO;
using Microsoft.Data.SqlClient;

namespace CO550_Project_Blazor_V2.Models.Services
{
    public class FilmService
    {
        SqlCommand com = new SqlCommand();

        List<FilmBooking> SelectedItems = new List<FilmBooking>();

        SqlDataReader dr;

        SqlConnection con = new SqlConnection();

       public DatabaseAddress dbAddress { get; set; }

       public static readonly List<DatabaseAddress> DBaddresses = new List<DatabaseAddress>();


        TicketBookingService TBS = new TicketBookingService();


        
            
    }
}
