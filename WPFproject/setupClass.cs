using ROG_6.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFproject
{
    public class setupClass
    {
        public List<Tamagotchi> tamagotchis { get; set; }
        public setupClass()
        {
            tamagotchis = new List<Tamagotchi>();
            tamagotchis.Add(new Tamagotchi("Steven", 80, 80, 80, 80, DateTime.Now.AddDays(-3)));
            tamagotchis.Add(new Tamagotchi("Peter", 47, 25, 95, 30, DateTime.Now));
            tamagotchis.Add(new Tamagotchi("Jean-Pierre", 20, 20, 20, 20, DateTime.Now.AddDays(-1)));
        }


        public Tamagotchi getByName(String name)
        {
            return tamagotchis.SingleOrDefault(e => e.name == name);
        }


        public String statusToString(Tamagotchi tamagotchi)
        {
            String status = "";
            if (tamagotchi.status.getOverleden() == true)
                return "Dead";
            if (tamagotchi.status.getTopvorm() == true)
                status += "Topvorm, ";
            else
            {
                if (tamagotchi.status.getKrankzinnig() == true)
                    status += "Crazy, ";
            }
            if (tamagotchi.status.getHongerig() == true)
                status += "Hungry, ";
            if (tamagotchi.status.getBezig() == true)
                status += "Active, ";

            if (status.Length == 0)
                status = "Relaxing";
            else
                status = status.Substring(0, status.Length - 2);

            return status;
        }


    }
}
