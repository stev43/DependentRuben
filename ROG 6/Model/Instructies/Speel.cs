
namespace ROG_6.Model.Instructies
{
    class Speel : BaseInstructie
    {

        public override int ExcecuteInstructie(Tamagotchi tamagotchi)
        {
            if (base.ExcecuteInstructie(tamagotchi) == 1)
                return 0;
            int boredom = tamagotchi.boredom;
            if (boredom < 10)
            {
                boredom = 0;
            }
            else
            {
                boredom -= 10;
            }
            tamagotchi.boredom = boredom;
            return 30;
        }

        public override string getName()
        {
            return "Speel";
        }
    }
}
