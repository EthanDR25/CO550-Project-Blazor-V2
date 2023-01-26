using System.ComponentModel.DataAnnotations;

namespace CO550_Project_Blazor_V2.Models
{
    public class DatabaseAddress
    {
        [Key]
        public string FilmID { get; set; }
        public string Title { get; set; }

        public string ReleaseDate { get; set; }

        public string Duration { get; set; }

        public string Price { get; set; }

        public string Genre { get; set; }

        public string Director { get; set; }
    }
}
