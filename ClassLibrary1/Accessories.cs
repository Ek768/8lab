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

    public class Accessories: Tovar, IAccessories
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Product_Accessory { get; set; }
        [DataMember]
        public Nomenklatura TovarCcategory { get; set; }
        public Accessories()
        { }
       
        public Accessories(Nomenklatura ID, string Name, double Price, Nomenklatura TovarCcategory) :base (ID, Price)
        {
            this.Name = Name;
            this.Price = Price;
            this.Product_Accessory = Product_Accessory;
        }
        public override string tv()
        {
            return Name + ", " + Price;
        }  
    }
}
