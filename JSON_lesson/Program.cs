using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSON_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Human[] Humans = new Human[]
            {
             new Human()
            {
                Name = "Alex",
                Age = 27,
                Born = DateTime.Now,
                Nicknames = new string[]
                {
                    "alex1993",
                    "kekus771"
                }
            },

            new Human()
            {
                Name = "Ira",
                Age = 33,
                Born = DateTime.MinValue,
                Nicknames = new string[]
                {
                    "ira999",
                    "h",
                    "ggg"
                }
            }

            };

           
            string json = JsonConvert.SerializeObject(Humans, Formatting.Indented);
            Console.WriteLine(json);
            Console.ReadLine();
            var humans2 = JsonConvert.DeserializeObject<Human[]>(json);
            Console.WriteLine(humans2[1].Name);
            Console.ReadLine();
        }
    }

    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Born { get; set; }
        public string[] Nicknames { get; set; }
    }
}
