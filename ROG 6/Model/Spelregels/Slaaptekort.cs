﻿
namespace ROG_6.Model.Spelregels
{

    class Slaaptekort : ISpelregels
    {

        public void ExcecuteSpelregel(Tamagotchi tamagotchi)
        {
            if (tamagotchi.sleep == 100 && tamagotchi.status.getTopvorm() == false)
            {
                tamagotchi.status.setOverleden(true);
            }
        }

    }

}
