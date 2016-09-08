using System;
using System.Collections.Generic;
using System.ServiceModel.Web;
namespace WCFServiceWithWebHttpBindingHost
{
    public class EmployeeService : IEmployeeService
    {
       static List<Employee> Employee;

        public EmployeeService()
        {
            if(Employee==null)
            {
                Employee = new List<Employee>();
                Employee.Add(new Employee {Id= "1",Name= "Salman",DateOfBirth= DateTime.Now,Gender= Gender.Male });
                Employee.Add(new Employee { Id = "2", Name = "Shahrukh", DateOfBirth = DateTime.Now, Gender = Gender.Male });
                Employee.Add(new Employee { Id = "3", Name = "Aamir", DateOfBirth = DateTime.Now, Gender = Gender.Male });
            }

        } 

        
         public Employee GetEmployee(string id)
        {
            return Employee.Find(x => x.Id.Equals(id));
        }

        public void SaveEmployee(Employee employee)
        {
            Employee.Add(employee);
        }
    }
}
