
namespace ROG_6.Model.Spelregels
{
    class Honger : ISpelregels
    {

        public void ExcecuteSpelregel(Tamagotchi tamagotchi)
        {
            int hunger = tamagotchi.getHunger();
            if (hunger > 95)
            {
                hunger = 100;
            }
            else
            {
                hunger += 5;
            }
            tamagotchi.setHunger(hunger);
        }
    }
}
