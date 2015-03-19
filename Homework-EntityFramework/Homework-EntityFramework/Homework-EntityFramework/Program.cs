namespace Homework_EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    class Program
    {
        static void Main()
        {
           

            var employeeToInsert = new Employee()
            {
                FirstName = "Rumen",
                LastName = "Kunev",
                JobTitle = "Developer",
                DepartmentID = 2,
                HireDate = DateTime.Now.AddDays(15),
                Salary = 10000
            };

            DataAccess.InsertEmployee(employeeToInsert);

            var employeesProjects2000 = EmployeesWithProjectInYear(2002);
            foreach (var e in employeesProjects2000)
            {
                Console.WriteLine(e);
            }

            
            
        }
        public static IList<string> EmployeesWithProjectInYear(int year)
        {
            var dbContext = new SoftUniEntities();

            var employeesWithProject = dbContext.Employees
                .Where(e => e.Projects.Any(p => p.StartDate.Year == year))
                .Select(e => e.FirstName).ToList();

            return employeesWithProject;
        }

        public static IList<string> EmployeesByDepartmentAndManager(string departement, string firstName, string lastName)
        {
            using (var dbContext = new SoftUniEntities())
            {

                var employees = dbContext.Employees
                    .Where(e => e.Manager
                        
                    .Select(e => e.FirstName).ToList();

                return employees;
            };
        }
    }
}

