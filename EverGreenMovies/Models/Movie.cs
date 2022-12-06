using EverGreenMovies.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EverGreenMovies.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Title")]
        public string Name { get; set; }
        [Display(Name = "Premise")]
        public string Description { get; set; }
        public double Price { get; set; }
        [Display(Name = "Poster")]
        public string ImageURL { get; set; }
        [Display(Name = "Premiere Date")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Available Date")]
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationships Model
        public List<Actor_Movie> Actors_Movies { get; set; }

        //Cinema Relationship Model
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Producer Relationship Model
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
