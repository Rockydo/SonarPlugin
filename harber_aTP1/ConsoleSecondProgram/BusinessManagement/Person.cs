using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSecondProgram.BusinessManagement
{
    class Person
    {
        public static List<DBO.Person> ReadData(String input)
        {
            DataAccess.ReadFile file = new DataAccess.ReadFile(input);
            return file.ReadData();
        }

        public static bool WriteData(List<DBO.Person> persons, String input)
        {
            DataAccess.WriteFile file = new DataAccess.WriteFile(input);
            return file.WriteData(persons);
        }
    }
}
