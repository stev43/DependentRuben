
namespace ROG_6.Model.Instructies
{
    class Oefen : Instructie
    {

        public override int ExcecuteInstructie(Tamagotchi tamagotchi)
        {
            if (base.ExcecuteInstructie(tamagotchi) == 1)
                return 0;
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

        public override string getName()
        {
            return "Oefen";
        }
    }
}
