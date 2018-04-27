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
   
    public class Accessories: Tovar, IAccessories
    {
        public string Name { get; set; }
        public string Product_Accessory { get; set; }
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
