using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;

namespace ClassLibrary1
   {

    [Serializable]
    [DataContract]
    public abstract class Tovar
    {
        [DataMember]
        public Nomenklatura ID { get; set; }
        [DataMember]
        public double Price { get; set; }
        public Tovar()
        { }

        public Tovar (Nomenklatura ID, double Price)
        {
            this.ID = ID;
            this.Price = Price;
        }
        public abstract string tv();

       
    }
}
