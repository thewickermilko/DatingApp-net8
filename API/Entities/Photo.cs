using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities;

[Table("Photos")]
public class Photo
{
    public int Id { get; set; }
    public required string Url { get; set; }
    public bool IsMian { get; set; }
    public string? PublicId { get; set; }

    //Navigation properties
    public int AppUserId { get; set; }
    public AppUser AppUser { get; set; } = null!; //null forgiving operator

}