using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSialingClub
{
    public class Booking
    {
        #region Proterties
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        Member Member { get; }
        Boat Boat { get; }
        #endregion

        #region Constructor
        public Booking(int id, DateTime dateTime, Member member, Boat boat) 
        { 
            Id = id;
            DateTime = dateTime;
            Member = member;
            Boat = boat;
        }
        #endregion


    }
}
