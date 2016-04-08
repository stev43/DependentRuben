
namespace ROG_6.Model.Spelregels
{
    class Topatleet : ISpelregels
    {

        public void ExcecuteSpelregel(Tamagotchi tamagotchi)
        {
            if (tamagotchi.getHealth() < 20)
            {
                tamagotchi.getStatus().setTopvorm(true);
            }
            else
            {
                if (tamagotchi.getHealth() >= 20 && tamagotchi.getStatus().getTopvorm() == true)
                {
                    tamagotchi.getStatus().setTopvorm(false);
                }
            }
        }
    }
}
