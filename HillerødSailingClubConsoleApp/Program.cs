// See https://aka.ms/new-console-template for more information
using HillerødSialingClub;

Console.WriteLine("Hello, World!");
Console.ReadLine();


Boat boat = new Boat(1, 4, "BodNavn", 2000, "benut", "macedes", 234, "julie");
Activity activity = new Activity(1, "juleaften", "der holdes juleaften event", 2024, 12, 24);
Blog blog = new Blog(1, "blogTitel", "text text text");
// booking create 
Employee employee = new Employee("kunde", 1, "casper", 42418990, "test@mail.com", "addresseTest1");
Member member = new Member(1, "casper", 42418990, "test@mail.com", "addresseTest1");


BoatDict boatDict = new BoatDict();

Console.WriteLine(boat);
Console.WriteLine(activity);
Console.WriteLine(blog);


boat.AddToMaintenanceLog("testtexttoMaintencelog");
boat.RequestRepairs("testtextToReapairlog");
boat.PrintMaintenanceLog();
boat.PrintRepairsLog();

boatDict.Add(boat);
boatDict.PrintAllBoat();
boatDict.Update(1, "type", "model", "name", 123, "engineinfo", 12, 1990);
boatDict.PrintAllBoat();
boatDict.GetBoat(1);
boatDict.GetBoat(2);
boatDict.DeleteBoat(1);
boatDict.PrintAllBoat();
