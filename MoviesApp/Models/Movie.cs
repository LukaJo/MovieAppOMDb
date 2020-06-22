using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60,MinimumLength =3)]
        [JsonProperty("Title")]
        public string Title { get; set; }

        //[Required]
        //[JsonProperty("Genre")]
        //public Genre Genre { get; set; }

        [Required]
        [JsonProperty("Genre")]
        public string Genre { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:0.0#}")]
        [JsonProperty("imdbRating")]
        public string Rating { get; set; }

        [Required]
        [DataType(DataType.Url)]
        [Display(Name ="IMDb Link")]
        public string ImdbUrl { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        [Display(Name ="Poster")]
        [JsonProperty("Poster")]
        public string ImageUrl { get; set; }

        [JsonProperty("imdbID")]
        public string ImdbID { get; set; }

    }
}
