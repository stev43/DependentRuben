
namespace ROG_6.Model.Spelregels
{
    class Topatleet : ISpelregels
    {

        public void ExcecuteSpelregel(Tamagotchi tamagotchi)
        {
            if (tamagotchi.health < 20)
            {
                tamagotchi.status.setTopvorm(true);
            }
            else
            {
                if (tamagotchi.health >= 20 && tamagotchi.status.getTopvorm() == true)
                {
                    tamagotchi.status.setTopvorm(false);
                }
            }
        }
    }
}
