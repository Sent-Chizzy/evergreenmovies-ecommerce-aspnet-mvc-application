using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EverGreenMovies.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Cinema Logo")]
        public string Logo { get; set; }
        [Display(Name = "Cinema Name")]
        public string FullName { get; set; }
        [Display(Name = "Cinema Address")]
        public string Description { get; set; }

        //Relationship Models
        public List<Movie> Movies { get; set; }
    }
}
