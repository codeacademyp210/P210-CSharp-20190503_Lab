using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        static List<Smartphone> smartphones = new List<Smartphone>();



        static void Main(string[] args)
        {

            Smartphone sp = new Smartphone
            {
                ID = 1,
                Manufacturer = "Man1",
                Megapixel = 11,
                Model = "Mod1",
                Name = "Name1",
                Price = 222
            };

            Smartphone sp2 = new Smartphone
            {
                ID = 2,
                Manufacturer = "Man2",
                Megapixel = 11,
                Model = "Mod2",
                Name = "Name2",
                Price = 222
            };

            Smartphone sp3 = new Smartphone
            {
                ID = 3,
                Manufacturer = "Man3",
                Megapixel = 11,
                Model = "Mod3",
                Name = "Name3",
                Price = 222
            };


            smartphones.Add(sp);
            smartphones.Add(sp2);
            smartphones.Add(sp3);
            DisplayResult();

            smartphones.RemoveAll(qeshem => qeshem.ID == 2);
            DisplayResult();
            smartphones.Find(togrul => togrul.ID == 1).Manufacturer = "New Manufacturer";
            DisplayResult();
            

            Console.ReadLine();
        }


        static void DisplayResult()
        {
            Console.WriteLine("============ ");
            foreach (var item in smartphones)
            {
                Console.WriteLine($"{item.ID} {item.Model} {item.Manufacturer}");
            }

        }
    }
}
