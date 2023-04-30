using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary
{
    public class MockData
    {
        public static List<Track> Tracks { get; set; } = new List<Track>()
        {
            new Track() { ID = 1, Name = "Web Development", Description = "Learn to build web applications" },
            new Track() { ID = 2, Name = "Data Science", Description = "Learn to analyze and visualize data" },
            new Track() { ID = 3, Name = "Mobile Development", Description = "Learn to build mobile apps" }
        };

        public static List<Trainee> Trainees = new List<Trainee>()
        {
            new Trainee() { ID = 1, Name = "Mohamed Ali", Gender = Gender.Male, Email = "mohamed.ali@example.com", MobileNo = "+20-10-1234-5678", Birthdate = new DateTime(1993, 4, 15), IsGraduated = true },
            new Trainee() { ID = 2, Name = "Fatima Ahmed", Gender = Gender.Female, Email = "fatima.ahmed@example.com", MobileNo = "+20-11-2345-6789", Birthdate = new DateTime(1995, 7, 26), IsGraduated = false },
            new Trainee() { ID = 3, Name = "Ahmed Hassan", Gender = Gender.Male, Email = "ahmed.hassan@example.com", MobileNo = "+20-12-3456-7890", Birthdate = new DateTime(1991, 11, 10), IsGraduated = true }
        };


    }
}
