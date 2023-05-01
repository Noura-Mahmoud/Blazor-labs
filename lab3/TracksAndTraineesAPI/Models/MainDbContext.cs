using Microsoft.EntityFrameworkCore;
using SharedLibrary;

namespace TracksAndTraineesAPI.Models
{
    public class MainDbContext: DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options): base(options)
        {

        }
        
        public virtual DbSet<Track> Tracks { get; set; }
        public virtual DbSet<Trainee> Trainees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Track>().HasData(
                new Track { ID = 1, Name = "First Item", Description = "This is the first item." },
                new Track { ID = 2, Name = "Second Item", Description = "This is the second item." },
                new Track { ID = 3, Name = "Third Item", Description = "This is the third item." }
                );

            modelBuilder.Entity<Trainee>().HasData(
            new Trainee
            {
                ID = 1,
                Name = "Ahmed Hassan",
                Gender = Gender.Male,
                Email = "ahmedhassan@example.com",
                MobileNo = "+201234567890",
                Birthdate = new DateTime(1995, 4, 22),
                IsGraduated = false
            },
            new Trainee
            {
                ID = 2,
                Name = "Mariam Ali",
                Gender = Gender.Female,
                Email = "mariamali@example.com",
                MobileNo = "+201112345678",
                Birthdate = new DateTime(1998, 12, 5),
                IsGraduated = true
            },
            new Trainee
            {
                ID = 3,
                Name = "Omar Mahmoud",
                Gender = Gender.Male,
                Email = "omarmahmoud@example.com",
                MobileNo = "+201987654321",
                Birthdate = new DateTime(2001, 6, 10),
                IsGraduated = false
            }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
