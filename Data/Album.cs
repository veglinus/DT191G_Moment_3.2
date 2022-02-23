using System.ComponentModel.DataAnnotations;
namespace CDAPI;

public class Album {
    public int AlbumId { get; set; }

    [Display(Name ="Albumtitel")]
    public string? title { get; set; }

    [Display(Name ="Genre")]
    public string? genre { get; set; }

    [Display(Name ="Releaseår")]
    public int? year {  get; set; }


    [Display(Name="Artist")]
    public int artistId { get; set; }
    public Artist? Artist { get; set; }
}