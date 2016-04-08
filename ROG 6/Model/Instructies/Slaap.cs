
namespace ROG_6.Model.Instructies
{
    class Slaap : Instructie
    {
        public override int ExcecuteInstructie(Tamagotchi tamagotchi)
        {
            if (base.ExcecuteInstructie(tamagotchi) == 1)
                return 0;
            tamagotchi.setSleep(0);
            return 7200;
        }
    }
}
