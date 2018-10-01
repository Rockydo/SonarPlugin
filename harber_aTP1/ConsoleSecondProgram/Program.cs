using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSecondProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DBO.Person> people = new List<DBO.Person>();
            people = BusinessManagement.Person.ReadData("text.txt");
            foreach(DBO.Person p in people)
            {
                Console.WriteLine("New person : " + p.Firstname + " "
                    + p.Name + " living at : " + p.Address);
            }
            Console.Read();
            BusinessManagement.Person.WriteData(people, "result.txt");
        }
    }
}
