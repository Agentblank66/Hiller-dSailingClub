using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSialingClub
{
    public class Activity
    {
        public int Id {  get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public int Date { get; set; }
        List<Member> Participants { get; set; }

        public Activity() { }
        public Activity(int id, string name, string description, int date, List<Member> participants) 
        {
            Id = id;
            Name = name;
            Description = description;
            Date = date;
            Participants = participants;
        }

        public override string ToString()
        {
            return $"Id: {Id} Name: {Name} Description: {Description} Date: {Date} Activity Participans: {Participants}";
        }



    }
}
