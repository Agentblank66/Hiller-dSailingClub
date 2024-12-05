using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HillerødSialingClub
{
    //Her opretter vi en "Employee" som skal nedarve fra klassen "Person"
    //Måden vi gør det på, er at gøre som illustreret nedenfor.
    public class Employee : Person
        //For at nedarve fra klassen "Person", skal vi bruge ":".
 
        //Her begynder vi på vores property.
    {
        private string Role {  get; set; }


        //Her laver vi en constructor. 
        public Employee(string role, int id, string name, int tlf, string email, string address) : base(id, name, tlf, email, address)
        {
            Role = role;
        }
    }
}
