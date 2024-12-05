using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSialingClub
{
    public class EmployeeDict
    {
        private Dictionary<int, Employee> Employees = new Dictionary<int, Employee>();

        public EmployeeDict() { }

        public void Add(Employee emp)
        {
            Employees.TryAdd(emp.Id,emp);
        }

        public void Update(Employee emp)
        {
            if (Employees.ContainsKey(emp.Id))
            {
                Employees[emp].Id = emp.Id;
                Employees[emp].Name = emp.Name;
                Employees[emp].Tlf = emp.Tlf;
                Employees[emp].Email = emp.Email;
                Employees[emp].Address = emp.Address;
            }
        }

        public Employee GetEmployee(int id)
        {
            return Employees[id];
        }

        public bool DeleteEmployee(int id)
        {
            return Employees.Remove(id);
        }

        public void PrintAllEmployees()
        {
            foreach (Employee emp in Employees)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }

      

    
}
