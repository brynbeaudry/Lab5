namespace Lab5.Migrations
{
    using Lab5.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Lab5.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations";
        }

        protected override void Seed(Lab5.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            // 
                context.Students.AddOrUpdate(
                  s => new { s.FirstName, s.LastName },
                    getStudents(context).ToArray()
                );
            context.SaveChanges();
            
            
        }

        private List<Student> getStudents(ApplicationDbContext ctx)
        {
            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    StudentId = "A00111111",
                    FirstName = "John",
                    LastName = "Archer",
                    Program = "CIT",
                },
                new Student()
                {
                    StudentId = "A00222222",
                    FirstName = "Jane",
                    LastName = "Baker",
                    Program = "CST",
                },
                new Student()
                {
                    StudentId = "A00444444",
                    FirstName = "Judy",
                    LastName = "Fisher",
                    Program = "Nursing",
                },
                new Student()
                {
                    StudentId = "A00333333",
                    FirstName = "Bill",
                    LastName = "Carter",
                    Program = "BTECH",
                }
            };

            return students;
        }
    }
}
