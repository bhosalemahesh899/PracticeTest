using System.Linq;

namespace Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DB_Test1Entities1 dB_Test1Entities1 = new DB_Test1Entities1();
            //dB_Test1Entities1.Projects.Add(new Project { Id = 1, Name = "PRohecasx" });
            //dB_Test1Entities1.SaveChanges();

            DBEntities dBEntities = new DBEntities();
            //dBEntities.users.Add(new user { Id = 3, Name = "dfg", poject = new poject { Name = "dfgdfg", ID = 1 } });
            //dBEntities.pojects.Add(new poject { Name = "dfgdfg", ID = 2, user = new user { Id = 4, Name = "dfg" } });
            var users = dBEntities.users.Where(X => X.Name = "sdfsd").ToList();
            foreach (var u in users)
            {
                System.Console.WriteLine(u.Name);
            }
            var us = dBEntities.users.Find(1);
            //us.Name = "User updated";
            dBEntities.users.Remove(us);
            dBEntities.SaveChanges();

            System.Console.Read();
        }
    }
}
