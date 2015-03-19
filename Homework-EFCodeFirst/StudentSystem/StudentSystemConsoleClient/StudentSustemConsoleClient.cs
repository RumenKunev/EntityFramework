namespace StudentSystemConsoleClient
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    

    using StudentSystem.Data;
    using StudentSystem.Model;
    using StudentSystem.Data.Migrations;
    
    

    public class StudentSustemConsoleClient
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext,Configuration>());

            var dbContext = new StudentSystemDbContext();

            var student = new Student
            {
                Name = "Rumen",
                PhoneNumber = "+359 887 334 446",
                RegistrationDate = DateTime.Now,
                Birthday = new DateTime(1977, 08, 31)
            };

            dbContext.Students.Add(student);
            dbContext.SaveChanges();

            var firstCourse = new Course
            {
                Name = "EntityGramework",
                Description = "How the magic works!",
                StartDate = new DateTime(2015, 02, 15),
                EndDate = new DateTime(2015, 03, 15),
                Price = null
            };

            student.Courses.Add(firstCourse);
            dbContext.SaveChanges();

            var savedStudent = dbContext.Students.First();
            Console.WriteLine(savedStudent.Id + savedStudent.Name);
        }
    }
}
