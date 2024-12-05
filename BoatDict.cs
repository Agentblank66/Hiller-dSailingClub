using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSialingClub
{
    public class BoatDict
    {
        private Dictionary<int, Boat> Boats = new Dictionary<int, Boat>();

        public BoatDict() { }

		public void Add(Boat boat)
		{
			Boats.TryAdd(boat.Id, boat);
		}

		public void Update(Boat boat)
		{
			if (Boats.ContainsKey(boat.Id))
			{
				boat.BoatType = boat.BoatType;
				boat.Model = boat.Model;
				boat.BoatName = boat.BoatName;
				boat.SailingNumber = boat.SailingNumber;
				boat.EngineInformation = boat.EngineInformation;
				boat.Size = boat.Size;
				boat.BuildYear = boat.BuildYear;
			}
		}
	}
}
