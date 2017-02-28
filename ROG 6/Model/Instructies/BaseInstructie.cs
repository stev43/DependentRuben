using System;

namespace ROG_6.Model.Instructies
{
    class BaseInstructie : IInstructies
    {
        public virtual int ExcecuteInstructie(Tamagotchi tamagotchi)
        {
            if (checkCrazy(tamagotchi))
                return 1;
            return 0;
        }

        private Boolean checkCrazy(Tamagotchi tamagotchi)
        {
            Random random = new Random();
            if (tamagotchi.status.getKrankzinnig() == true && tamagotchi.status.getTopvorm() == false)
            {
                if (random.Next(0, 2) == 1)
                {
                    tamagotchi.status.setOverleden(true);
                    return true;
                }
                return false;
            }
            return false;
        }

        public virtual string getName()
        {
            return "";
        }
    }
}