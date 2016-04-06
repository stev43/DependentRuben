
namespace ROG_6.Model.Instructies
{
    class Knuffel : IInstructies
    {

        public int ExcecuteInstructie(Tamagotchi tamagotchi)
        {
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
