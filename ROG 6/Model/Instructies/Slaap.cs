﻿
namespace ROG_6.Model.Instructies
{
    class Slaap : BaseInstructie
    {
        public override int ExcecuteInstructie(Tamagotchi tamagotchi)
        {
            if (base.ExcecuteInstructie(tamagotchi) == 1)
                return 0;
            tamagotchi.sleep = 0;
            return 7200;
        }

        public override string getName()
        {
            return "Slaap";
        }
    }
}
