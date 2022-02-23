using System.ComponentModel.DataAnnotations;
namespace CDAPI;

public class Artist {
    public int artistId { get; set; }

    [Display(Name="Artist")]
    public string? artistTitle { get; set; }

    [Display(Name ="År bildat")]
    public string? year { get; set; }

    public List<Album>? albums { get; set; }
}