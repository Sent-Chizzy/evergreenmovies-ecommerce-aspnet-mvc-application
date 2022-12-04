using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EverGreenMovies.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationships Model
        public List<Actor_Movie>Actors_Movies { get; set; }
    }
}
