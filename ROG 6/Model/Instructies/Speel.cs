
namespace ROG_6.Model.Instructies
{
    class Speel : Instructie
    {

        public override int ExcecuteInstructie(Tamagotchi tamagotchi)
        {
            if (base.ExcecuteInstructie(tamagotchi) == 1)
                return 0;
            int boredom = tamagotchi.getBoredom();
            if (boredom < 10)
            {
                boredom = 0;
            }
            else
            {
                boredom -= 10;
            }
            tamagotchi.setBoredom(boredom);
            return 30;
        }

        public override string getName()
        {
            return "Speel";
        }
    }
}
