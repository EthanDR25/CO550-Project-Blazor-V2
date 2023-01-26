using CO550_Project_Blazor_V2.Models.Services;
using System.ComponentModel.DataAnnotations;

namespace CO550_Project_Blazor_V2.Models
{
    public class FilmBooking
    {
        public int FilmBookingID { get; set; }

        public DatabaseAddress address { get; set; }

        public FilmService MovieService { get; set; }

        public DatabaseAddress DBAddress { get; set; }

        public string MovieTitle { get; set; }

        public int Quantity { get; set; } = 1;

        [Required]
        public string PurchasePrice { get; set; }


        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }
    }
}
