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
    
    public class Piano: Tovar
    {
        public string Firm { get; set; }
        public string Material { get; set; }
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
