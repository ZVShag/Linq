using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Manufacturing { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}",this.Name,this.Price,this.Manufacturing,this.Count); 
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            first_q();
            
        }
        private static void first_q()
        {
            string[] country = {"Albania", "UK",
                                "Lithuania", "Andorra", "Austria",
                                "Latvia", "Liechtenstein", "Switzerland",
                                "Ireland", "Sweden","Italy", "France",
                                "Liechtenstein", "Spain", "Turkey", "Germany",
                                "Switzerland", "Monaco", "Montenegro",
                                "Norway", "Finland", "Turkey", "UK", "Poland",
                                "Portugal", "Lithuania", "Luxembourg"
                                 };

            var result = from i in country where i.StartsWith("L")  select i; // запрос к коллекции
            foreach (var item in result) Console.WriteLine(item);// запрос к коллекции
            /// select * from datatable - вывести данные из таблицы базы данных
            /// foreach,while,for - для массива данных в программе
        }
        public static void Linq_method()
        {
            string[] country = {"Albania", "UK",
                                "Lithuania", "Andorra", "Austria",
                                "Latvia", "Liechtenstein", "Switzerland",
                                "Ireland", "Sweden","Italy", "France",
                                "Liechtenstein", "Spain", "Turkey", "Germany",
                                "Switzerland", "Monaco", "Montenegro",
                                "Norway", "Finland", "Turkey", "UK", "Poland",
                                "Portugal", "Lithuania", "Luxembourg"
                                 };
            List<Product> products = new List<Product>();
            for (int i = 0; i < 100; i++)
            {

            }
        }

    }
}
