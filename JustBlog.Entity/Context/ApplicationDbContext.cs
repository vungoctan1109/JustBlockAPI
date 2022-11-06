using JustBlog.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JustBlog.Entity.Context;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<PostTagMap> PostTags { get; set; }
    public DbSet<Comment> Comments { get; set; }

    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=Localhost;Database=JustBlog;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=True;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<PostTagMap>(pt => pt.HasKey(pt => new { pt.PostId, pt.TagId }));

        modelBuilder.Entity<Post>(p =>
        {
            p.HasData(Seed.Posts);
            p.HasIndex(p => p.UrlSlug).IsUnique();
        });
        modelBuilder.Entity<PostTagMap>().HasData(Seed.PostTags);
        modelBuilder.Entity<Category>(c =>
        {
            c.HasData(Seed.Categories);
            c.HasIndex(p => p.UrlSlug).IsUnique();
        });
        modelBuilder.Entity<Tag>(t =>
        {
            t.HasData(Seed.Tags);
            t.HasIndex(p => p.UrlSlug).IsUnique();

        });
        modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(Seed.UserRoles);
        modelBuilder.Entity<ApplicationUser>().HasData(Seed.Users);
        modelBuilder.Entity<IdentityRole<Guid>>().HasData(Seed.Roles);
    }

}

