using System.ComponentModel.DataAnnotations;

namespace MoviesApp.Models
{
    public enum Genre
    {

        Drama,
        Comedy,
        Romance,
        [Display(Name = "Romantic Comedy")]
        RomCom,
        Crime,
        Mystery,
        Action,
        Fantasy,
        Thriller,
        Documentary,
        Short,
        News,
        Horror,
        [Display(Name = "Sci-Fi")]
        SciFi

    }
}