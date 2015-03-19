namespace StudentSystem.Data.Migrations
{
    using StudentSystem.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<StudentSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(StudentSystemDbContext context)
        {
            if (context.Students.Any())
            {
                return;
            }

            var seededStudent = new Student
            {
                Name = "Sees Seeder",
                PhoneNumber = "iu009029092"
            };

            context.Students.Add(seededStudent);
            context.SaveChanges();
        }
    }
}
