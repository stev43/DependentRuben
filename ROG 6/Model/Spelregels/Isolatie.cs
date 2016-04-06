
namespace ROG_6.Model.Spelregels
{
    class Isolatie : ISpelregels
    {

        public void ExcecuteSpelregel(Tamagotchi tamagotchi)
        {
            int health = tamagotchi.getHealth();
            if (health > 95)
            {
                health = 100;
            }
            else
            {
                health += 5;
            }
            tamagotchi.setHealth(health);
        }

    }
}
