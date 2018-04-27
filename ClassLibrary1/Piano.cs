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
    public class Piano: Tovar
    {
        [DataMember]
        public string Firm { get; set; }
        [DataMember]
        public string Material { get; set; }
        [DataMember]
        public DateTime Release_data { get; set; }
        public Piano()
        { }

        public Piano(Nomenklatura ID, string Firm, string Material, double Price, DateTime Release_data) : base(ID, Price)
        {
            this.Firm = Firm;
            this.Material = Material;
            this.Release_data = Release_data;
        }
        public override string tv()
        {
            return ID.ToString() + ", " + Firm.ToString() + ", " + Material.ToString() + ", " + Price.ToString() + ", " + Release_data.ToString("dd MMMM yyyy");
        }
    }
}
