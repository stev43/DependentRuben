﻿
namespace ROG_6.Model.Spelregels
{
    class Honger : ISpelregels
    {

        public void ExcecuteSpelregel(Tamagotchi tamagotchi)
        {
            int hunger = tamagotchi.hunger;
            if (tamagotchi.status.getHongerig() == true)
            {
                if (hunger > 90)
                {
                    hunger = 100;
                }
                else
                {
                    hunger += 10;
                }
            }
            else
            {
                if (hunger > 95)
                {
                    hunger = 100;
                }
                else
                {
                    hunger += 5;
                }
            }
            tamagotchi.hunger = hunger;
        }
    }
}
