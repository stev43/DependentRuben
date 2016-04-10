
namespace ROG_6.Model.Instructies
{
    protected class Eet : Instructie
    {

        public override int ExcecuteInstructie(Tamagotchi tamagotchi)
        {
            if (base.ExcecuteInstructie(tamagotchi) == 1)
                return 0;
            tamagotchi.health = 0;
            return 30;
        }

        public override string getName()
        {
            return "Eet";
        }

    }
}
