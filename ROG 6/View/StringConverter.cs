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
                string record = tamagotchi.getName();
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

                returnStrings.Add("Name:    " + tamagotchi.getName());
                returnStrings.Add("Hunger:  " + tamagotchi.getHunger());
                returnStrings.Add("Sleep:   " + tamagotchi.getSleep());
                returnStrings.Add("Boredom: " + tamagotchi.getBoredom());
                returnStrings.Add("Health:  " + (100 - tamagotchi.getHealth()) + "%");
                if (tamagotchi.getBezig() == true)
                    returnStrings.Add(tamagotchi.getName() + " is momenteel zeer actief bezig.");
                else
                    returnStrings.Add(tamagotchi.getName() + " is momenteel aan het uitrusten.");

                return returnStrings;
            }
        }
    }
}
