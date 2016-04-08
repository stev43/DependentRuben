
namespace ROG_6.Model.Instructies
{
    class Knuffel : Instructie
    {

        public override int ExcecuteInstructie(Tamagotchi tamagotchi)
        {
            if (base.ExcecuteInstructie(tamagotchi) == 1)
                return 0;
            int health = tamagotchi.getHealth();
            if (health < 10)
            {
                health = 0;
            }
            else
            {
                health -= 10;
            }
            tamagotchi.setHealth(health);
            return 60;
        }

    }
}
