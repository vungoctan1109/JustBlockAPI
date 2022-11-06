using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JustBlog.Entity.Entities;

public class Comment
{
    [Key]
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    [ForeignKey("Post")]
    public Guid PostId { get; set; }
    public virtual Post Post { get; set; }
    public string CommentHeader { get; set; }
    public string CommentText { get; set; }
    public DateTime Time { get; set; }
}
