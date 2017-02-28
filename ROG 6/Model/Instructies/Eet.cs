﻿
namespace ROG_6.Model.Instructies
{
    class Eet : BaseInstructie
    {

        public override int ExcecuteInstructie(Tamagotchi tamagotchi)
        {
            if (base.ExcecuteInstructie(tamagotchi) == 1)
                return 0;
            tamagotchi.hunger = 0;
            return 30;
        }

        public override string getName()
        {
            return "Eet";
        }

    }
}
