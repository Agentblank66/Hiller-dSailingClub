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

        public void Update(int id, Employee emp)
        {
            if (Employees.ContainsKey(emp.Id))
            {
                Employee[id]
            }
        }
    }

      

    
}
