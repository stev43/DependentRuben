
namespace ROG_6.Model.Instructies
{
    class Oefen : IInstructies
    {

        public int ExcecuteInstructie(Tamagotchi tamagotchi)
        {
            int health = tamagotchi.getHealth();
            if (health < 5)
            {
                health = 0;
            }
            else
            {
                health -= 5;
            }
            tamagotchi.setHealth(health);
            return 60;
        }

    }
}
