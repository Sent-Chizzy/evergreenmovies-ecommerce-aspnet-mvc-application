using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EverGreenMovies.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }

        //Relationship Models
        public List<Movie> Movies { get; set; }
    }
}
