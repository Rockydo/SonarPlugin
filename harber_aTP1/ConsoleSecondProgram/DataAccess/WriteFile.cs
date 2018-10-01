using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSecondProgram.DataAccess
{
    class WriteFile : IDisposable
    {
        String _filename { get; }
        StreamWriter _file;
        public WriteFile(String input)
        {
            this._filename = input;
            Initialize();
        }

        public void Initialize()
        {
            _file = new StreamWriter(_filename);
        }

        public bool WriteData(List<DBO.Person> persons)
        {
            foreach(DBO.Person p in persons)
            {
                _file.WriteLine(p.Name + ";" + p.Firstname + ";" + p.Address);  
            }
            _file.Close();
            return true;
        }

        public void Dispose()
        {
        }

        public void Dispose(bool b)
        {
        }
    }
}
