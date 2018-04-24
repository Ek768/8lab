using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Xml.Serialization;




namespace ClassLibrary1
   {
    [Serializable]
    public abstract class Tovar
    {
        public Nomenklatura ID { get; set; }
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
