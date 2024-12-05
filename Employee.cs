using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HillerødSialingClub
{
    public class Employee : Person
    {
        private string Role {  get; set; }

        public Employee(string role, int id, string name, int tlf, string email, string address) : base(id, name, tlf, email, address)
        {
            Role = role;
        }
    }
}
