using System.ComponentModel.DataAnnotations;

namespace JustBlog.Model.Category;

public class CategoryUM
{
    public Guid Id { get; set; } = Guid.NewGuid();
    [Required]
    [StringLength(255)]
    public string Name { get; set; }
    [StringLength(255)]
    public string UrlSlug { get; set; }
    [StringLength(1024)]
    public string Description { get; set; }
}
