﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSialingClub
{
    public class EmployeeDict
        //Her laver vi en "Dictionary" over Employees
    {
        private Dictionary<int, Employee> Employees = new Dictionary<int, Employee>();

        //Her laver vi en Add metode. Vi bruger TryAdd, da 2 ID IKKE må være ens.
        public void Add(Employee emp)
        {
            Employees.TryAdd(emp.Id,emp);
        }

        //Her laver vi en Update metode. Vi bruger nedstående metode.
        //Vores "if" statement, skal finde alle Employees ved hjælp af søgefunktionen "ID"
        //Derfra kan vi hente Employeen, og ændre i deres oplysninger.
        public void Update(Employee emp)
        {
            if (Employees.ContainsKey(emp.Id))
            {
                emp.Name = emp.Name;
                emp.Tlf = emp.Tlf;
                emp.Email = emp.Email;
                emp.Address = emp.Address;
            }
        }

        //Her laver vi metoden GetEmployee, som gør det muligt for os at søge 
        //efter Employees, ved hjælp af deres "ID".
        public Employee GetEmployee(int id)
        {
            return Employees[id];
        }

        //Her laver vi metoden DeleteEmployee, som gør det muligt for os at søge 
        //efter Employees, ved hjælp af deres "ID", og efterfølgende slette vedkommende.
        public bool DeleteEmployee(int id)
        {
            return Employees.Remove(id);
        }

        //Her laver vi en PrintAll, som gør det muligt at vise ALLE employees.
        public void PrintAllEmployees()
        {
            foreach (Employee emp in Employees.Values)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }

      

    
}
