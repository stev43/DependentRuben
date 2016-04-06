
using System;
namespace ROG_6.Model.Instructies
{
    interface IInstructies
    {

        public int ExcecuteInstructie(Tamagotchi tamagotchi)
        {
            if (checkCrazy(tamagotchi) == true)
            {
                return 0;
            }
            return 0;

        }

        private Boolean checkCrazy(Tamagotchi tamagotchi)
        {
            Random random = new Random();
            if (tamagotchi.getStatus().getKrankzinnig() == true)
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
