﻿
namespace ROG_6.Model.Spelregels
{
    class Voedseltekort : ISpelregels
    {
        public void ExcecuteSpelregel(Tamagotchi tamagotchi)
        {
            if (tamagotchi.hunger == 100 && tamagotchi.status.getTopvorm() == false)
            {
                tamagotchi.status.setOverleden(true);
            }
        }
    }
}
