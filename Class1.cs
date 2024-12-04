namespace HillerødSialingClub
{
    public class Boat
    {
        public int Id { get; set; }
        public double Size { get; set; }
        public string MotorInfo { get; set; }
        public int BuildYear { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int SailNr { get; set; }
        public string Name { get; set; }

        public Boat(int id, double size, string motorInfo, int buildYear, string model, string type, int sailNr, string name  )
        {
            Id = id;
            Size = size;
            MotorInfo = motorInfo;
            BuildYear = buildYear;
            Model = model;
            Type = type;
            SailNr = sailNr;
            Name = name;
        }
    }
}
