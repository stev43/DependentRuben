
namespace ROG_6.Model.Instructies
{
    class Eet : Instructie
    {

        public override int ExcecuteInstructie(Tamagotchi tamagotchi)
        {
            if (base.ExcecuteInstructie(tamagotchi) == 1)
                return 0;
            tamagotchi.setHealth(0);
            return 30;
        }

    }
}
