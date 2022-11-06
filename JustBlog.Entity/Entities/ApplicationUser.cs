using Microsoft.AspNetCore.Identity;

namespace JustBlog.Entity.Entities;

public class ApplicationUser : IdentityUser<Guid>
{
    public int Age { get; set; }
    public string AboutMe { get; set; }
}
