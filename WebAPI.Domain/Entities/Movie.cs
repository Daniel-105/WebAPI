using System.ComponentModel.DataAnnotations;

namespace WebAPI.Domain.Entities;
public class Movie
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public string Url { get; set; }
    public int Duration { get; set; }
}
