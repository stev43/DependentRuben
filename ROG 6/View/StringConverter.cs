using ROG_6.Model;
using ROG_6.Model.Instructies;
using System.Collections.Generic;

namespace ROG_6.View
{
    static class StringConverter
    {
        public static List<string> getTamagotchis(List<Tamagotchi> tamagotchis)
        {
            List<string> result = new List<string>();
            foreach (Tamagotchi tamagotchi in tamagotchis)
            {
                string record = tamagotchi.name;
                result.Add(record);
            }
            return result;
        }

        public static List<string> getActies(List<IInstructies> instructies)
        {
            List<string> result = new List<string>();
            foreach (IInstructies instructie in instructies)
            {
                string record = instructie.getName();
                result.Add(record);
            }
            return result;
        }

        public static List<string> getTamagotchiInformation(Tamagotchi tamagotchi)
        {
            if (tamagotchi == null)
            {
                return null;
            }
            else
            {

                List<string> returnStrings = new List<string>();

                returnStrings.Add("Name:    " + tamagotchi.name);
                returnStrings.Add("Hunger:  " + tamagotchi.hunger);
                returnStrings.Add("Sleep:   " + tamagotchi.sleep);
                returnStrings.Add("Boredom: " + tamagotchi.boredom);
                returnStrings.Add("Health:  " + (100 - tamagotchi.health) + "%");
                if (tamagotchi.status.getBezig() == true)
                    returnStrings.Add(tamagotchi.name + " is momenteel zeer actief bezig.");
                else
                    returnStrings.Add(tamagotchi.name + " is momenteel aan het uitrusten.");

                return returnStrings;
            }
        }
    }
}
