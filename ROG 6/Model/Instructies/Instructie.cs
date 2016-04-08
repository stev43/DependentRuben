using System;

namespace ROG_6.Model.Instructies
{
    protected class Instructie : IInstructies
    {
        protected int ExcecuteInstructie(Tamagotchi tamagotchi)
        {
            if (checkCrazy(tamagotchi))
                return 1;
            return 0;
        }

        private Boolean checkCrazy(Tamagotchi tamagotchi)
        {
            Random random = new Random();
            if (tamagotchi.getStatus().getKrankzinnig() == true && tamagotchi.getStatus().getTopvorm() == false)
            {
                if (random.Next(0, 1) == 1)
                {
                    tamagotchi.getStatus().setOverleden(true);
                    return true;
                }
                return false;
            }
            return false;
        }

    }
}