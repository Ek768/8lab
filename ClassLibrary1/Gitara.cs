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

    public class Gitara : Tovar
    {
        [DataMember]
        public string Vid_instrumenta { get; set; }
        [DataMember]
        public string Marka_instrumenta { get; set; }
        [DataMember]
        public DateTime Release_data { get; set; }
        public Gitara()
        { }

        public Gitara(Nomenklatura ID,  string Vid_instrumenta, string Marka_instrumenta,double Price, DateTime Release_data) : base(ID, Price)
        {
            this.Vid_instrumenta = Vid_instrumenta;
            this.Marka_instrumenta = Marka_instrumenta;
            this.Release_data = Release_data;
        }
        public override string tv()
        {
            return ID + ", " + Vid_instrumenta + ", " + Marka_instrumenta + ", " + Price + ", " + Release_data.ToString("dd MMMM yyyy");
        }

    }
}

