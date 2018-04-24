using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;


namespace ClassLibrary1
{
    [Serializable]
    public class Nomenklatura
    {
        public string Name { get; set; }
        public DateTime Data_registration { get; set; }
   
        public Nomenklatura (string Name, DateTime Data_registration)

        {
            this.Name = Name;
            this.Data_registration = Data_registration;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
