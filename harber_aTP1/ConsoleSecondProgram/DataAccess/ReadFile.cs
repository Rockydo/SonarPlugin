using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSecondProgram.DataAccess
{
    class ReadFile : IDisposable
    {
        String _filename { get; }
        StreamReader _file;
        public ReadFile(String input)
        {
            this._filename = input;
            Initialize();
        }

        public void Initialize()
        {
            _file = new StreamReader(_filename);
        }

        public List<DBO.Person> ReadData()
        {
            String line;
            List<DBO.Person> list = new List<DBO.Person>();
            try
            {
                while ((line = _file.ReadLine()) != null)
                {
                    int counter = 0;
                    foreach (Char c in line)
                    {
                        if (c == ';')
                            counter++;
                    }
                    if (counter != 2)
                        throw new Exception("err");
                    String Adress = "";
                    String Firstname = "";
                    String Name = "";
                    counter = 0;
                    foreach (Char c in line)
                    {
                        if (c == ';')
                            counter++;
                        else if (counter == 0)
                            Name += c;
                        else if (counter == 1)
                            Firstname += c;
                        else if (counter == 2)
                            Adress += c;
                    }
                    DBO.Person p = new DBO.Person(Adress, Firstname, Name);
                    list.Add(p);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "err")
                    throw new Exception("Erreur durant la lecture");
            }
            return list;
        }

        public void Dispose() { }

        public void Dispose(bool b) {}
    }
}
