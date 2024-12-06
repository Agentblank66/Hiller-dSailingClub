using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace HillerødSialingClub
{
    public class Activity
    {
        public int Id {  get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public DateOnly Date { get; set; }

        List<Member> Participants = new List<Member>();

        public Activity() { }
        public Activity(int id, string name, string description, int year, int month, int day) 
        {
            Id = id;
            Name = name;
            Description = description;
            Date = date;
        }
        
        //Method which overrrides the base ConsoleWriteLine
        public override string ToString()
        {
            return $"Id: {Id} Name: {Name} Description: {Description} Date: {Date}";
        }

        //Method which adds a member to an activity, by chechking if the activity is valid and makes sure the same member can't join mulitple times. 
        public void JoinActivity(Member member, Activity activity)
        {
            if (activity != null && !Participants.Contains(member))
            {
                Participants.Add(member);
            }
           
        }

    }
}
