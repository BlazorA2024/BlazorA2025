using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
//dotnet ef migrations add InitialMigration --context ChatASG.UseDbContext


// dotnet ef database update --context ChatASG.UseDbContext
namespace BlazorASG
{
    public class UseDbContext : DbContext
    {

        public UseDbContext(DbContextOptions<UseDbContext> options) : base(options)
        {

        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Profiles> Profiles { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<Imagess> Imagess { get; set; }
        public DbSet<BKImage> BKImage { get; set; }



    }

    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Username { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, MinLength(8)] // Consider using a secure hashing algorithm for password storage
        public string Password { get; set; }


        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]([0-9]{3})[-. ]([0-9]{4})$")] // Basic phone number format validation
        public string PasswordMatch { get; set; }
    }

    public class Images
    {
        [Key]
        public string URL { set; get; }

        public string IdProfiles { get; set; }

    }

    public class BKImage
    {


        [Key]
        public int Id { get; set; } // Use an auto-incrementing integer as the primary key

        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] ImageData { get; set; }

        public string IdProfiles { get; set; }
    }
    public class Imagess
    {
        [Key]
        public int Id { get; set; } // Use an auto-incrementing integer as the primary key

        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] ImageData { get; set; }

        public string IdProfiles { get; set; }
    }


    public class Profiles
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public Users User { get; set; }

        public List<Images> Images { get; set; }

        public List<Imagess> Imagess { get; set; }
        public BKImage BK { get; set; }
    }




}