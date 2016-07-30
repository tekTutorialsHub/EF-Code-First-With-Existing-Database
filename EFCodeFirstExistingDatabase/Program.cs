using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstExistingDatabase
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new models.AdventureWorks())
            {
                var People = ctx.People.ToList();

                foreach (var person in People)
                {
                    Console.WriteLine(string.Format("{0} {1}",
                        person.FirstName,
                        person.LastName));
                }
            }

            Console.ReadLine();
        }
    }
}
