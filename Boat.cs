namespace HillerødSialingClub
{
	public class Boat
	{
		public int Id { get; set; }
		public double Size { get; set; }
		public string EngineInformation { get; set; }
		public int BuildYear { get; set; }
		public string Model { get; set; }
		public string BoatType { get; set; }
		public int SailingNumber { get; set; }
		public string BoatName { get; set; }

		List<string> MaintenanceLog = new List<string>();
		List<string> Repairs = new List<string>();

		public Boat(int id, double size, string motorInfo, int buildYear, string model, string type, int sailNr, string name)
		{
			Id = id;
			Size = size;
			EngineInformation = motorInfo;
			BuildYear = buildYear;
			Model = model;
			BoatType = type;
			SailingNumber = sailNr;
			BoatName = name;
		}

		public List<string> PrintLog() 
		{
			foreach (var log in MaintenanceLog) 
			{
                Console.WriteLine(log);
			}
			return MaintenanceLog;
		}


		public void RequestRepairs(string requestRepairs)
		{
			Repairs.Add(requestRepairs);
		}

		public override string ToString()
		{
			return $"Boat {BoatName} has id:{Id} and is {Size} big as model {Model} and type {BoatType} with a {EngineInformation} Engine with sailnumber {SailingNumber} build in {BuildYear}";
		}
	}
}
