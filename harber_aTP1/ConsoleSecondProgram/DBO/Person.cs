using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSecondProgram.DBO
{
    public class Person
    {
        String _Address { get; set; }
        String _Firstname { get; set; }
        String _Name { get; set; }

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public string Firstname
        {
            get { return _Firstname; }
            set { _Firstname = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public Person(String Address, String Firstname, String Name)
        {
            this.Address = Address;
            this.Firstname = Firstname;
            this.Name = Name;
        }

    }
}
