using System.ComponentModel.DataAnnotations.Schema;

namespace JustBlog.Entity.Entities;

public class PostTagMap
{
    [ForeignKey("Post")]
    public Guid PostId { get; set; }
    public virtual Post Post { get; set; }
    [ForeignKey("Tag")]
    public Guid TagId { get; set; }
    public virtual Tag Tag { get; set; }
}
