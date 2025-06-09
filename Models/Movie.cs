using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }

    [Display(Name = "Title")]
    public string? Title { get; set; }

    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [Display(Name = "Genre")]
    public string? Genre { get; set; }

    [Display(Name = "Price")]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
} 