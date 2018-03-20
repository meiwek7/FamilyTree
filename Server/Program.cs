using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SERVER";
            using (FamilyTreeEntities db = new FamilyTreeEntities())
            {
                var users = db.User;
                foreach (User u in users)
                {
                    Console.WriteLine("{0}.{1} - {2}", u.id, u.email, u.phoneNumber);
                }
            }
            Console.ReadKey();
        }
    }
}