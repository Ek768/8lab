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

    public class Baraban: Tovar
    {
        [DataMember]
        public string material { get; set; }
        [DataMember]
        public string Marka_instrumenta { get; set; }
        [DataMember]
        public DateTime Release_data { get; set; }
        public Baraban()
        { }

        public Baraban(Nomenklatura ID, string Marka_instrumenta, string material,  double Price, DateTime Release_data) : base(ID, Price)
        {
            this.material = material;
            this.Marka_instrumenta = Marka_instrumenta;
            this.Release_data = Release_data;
        }
        public override string tv()
        {
            return ID.ToString() + ", " +  Marka_instrumenta.ToString() + ", " + material.ToString()+ ", " +Price.ToString() + ", " + Release_data.ToString("dd MMMM yyyy");
        }
    }
}
