
namespace ROG_6.Model.Instructies
{
    class Knuffel : BaseInstructie
    {

        public override int ExcecuteInstructie(Tamagotchi tamagotchi)
        {
            if (base.ExcecuteInstructie(tamagotchi) == 1)
                return 0;
            int health = tamagotchi.health;
            if (health < 10)
            {
                health = 0;
            }
            else
            {
                health -= 10;
            }
            tamagotchi.health = health;
            return 60;
        }

        public override string getName()
        {
            return "Knuffel";
        }
    }
}
