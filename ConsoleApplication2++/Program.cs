using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ConsoleApplication2__
{
    class Program
    {
        static void Main(string[] args)
        {
            Nomenklatura gitara_nomenklatura = new Nomenklatura("gitara", new DateTime(2018, 02, 05));
            Nomenklatura skripka_nomenklatura = new Nomenklatura("skripka", new DateTime(2018, 01, 28));
            Nomenklatura mediator_nomenklatura = new Nomenklatura("Mediator", new DateTime(2018, 01, 28));
            Nomenklatura baraban_nomenklatura = new Nomenklatura("baraban", new DateTime(2016, 09, 10));
            Nomenklatura piano_nomenklatura = new Nomenklatura("piano", new DateTime(2017, 10, 10));

            Gitara tovar1 = new Gitara(gitara_nomenklatura, "electric_guitar", "YAMAHA", 15000, new DateTime(2015, 03, 07));
            Skripka tovar2 = new Skripka(skripka_nomenklatura, "Crafter", 1, 50000, new DateTime(2017, 05, 08));
            Baraban tovar3 = new Baraban(baraban_nomenklatura, "YAMAHA", "wood - leather", 7000, new DateTime(2016, 09, 10));
            Piano tovar4 = new Piano(piano_nomenklatura, "C.Bechstein", "wood", 80000, new DateTime(2017, 10, 10));
            Accessories tovar5 = new Accessories(mediator_nomenklatura, "Mediator", 100, gitara_nomenklatura);


            List<Tovar> ListTovar = new List<Tovar>();
            ListTovar.Add(tovar1);
            ListTovar.Add(tovar2);
            ListTovar.Add(tovar3);
            ListTovar.Add(tovar4);
            ListTovar.Add(tovar5);


            List<Type> TypeList = new List<Type>();
            foreach (Tovar t in ListTovar)
            {
                try
                {
                    TypeList.Add(t.GetType());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка {0}", ex.Message);
                }
            }
         
            DataContractJsonSerializer js = new DataContractJsonSerializer(ListTovar.GetType(), TypeList.ToArray());
            using (FileStream fs = new FileStream("tovar.json", FileMode.OpenOrCreate))
            {
                js.WriteObject(fs, ListTovar);
                Console.WriteLine("Сериализация JSON прошла успешно");
            }
            using (FileStream fs = new FileStream("tovar.json", FileMode.OpenOrCreate))
            {
                List<Tovar> ListDeserTovar = js.ReadObject(fs) as List<Tovar>;
                foreach (Tovar tv in ListDeserTovar)
                {

                    Console.WriteLine("Товар: {0} ; Цена: {1}", tv.ID, tv.Price);

                }
            }
            Console.ReadLine();
        }
    }
    }

