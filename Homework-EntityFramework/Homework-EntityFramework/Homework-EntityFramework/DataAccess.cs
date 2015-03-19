namespace Homework_EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DataAccess
    {
        private static SoftUniEntities dbContext = new SoftUniEntities();

        public static void InsertEmployee(Employee employee)
        {
            dbContext.Employees.Add(employee);
            dbContext.SaveChanges();
        }

        public static void UpdateEmployee(int employeeId, string propertyName, object newValue)
        {
            var employee = dbContext.Employees.Find(employeeId);

            if (null != employee)
            {
                employee.GetType().GetProperty(propertyName).SetValue(employee, newValue);
                dbContext.SaveChanges();
            }
        }

        
        public static void DeleteEmployee(int Id)
        {
            var employeeById =
                dbContext.Employees.Where(e => e.EmployeeID == Id).FirstOrDefault();

            if (employeeById == null)
            {
                throw new ArgumentNullException();
            }

            dbContext.Employees.Remove(employeeById);
            dbContext.SaveChanges();
        }


    }
}
