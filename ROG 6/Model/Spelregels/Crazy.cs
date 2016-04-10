
namespace ROG_6.Model.Spelregels
{
    class Crazy : ISpelregels
    {
        public void ExcecuteSpelregel(Tamagotchi tamagotchi)
        {
            if (tamagotchi.status.getKrankzinnig() == true && tamagotchi.health == 100)
            {
                tamagotchi.status.setKrankzinnig(false);
            }
            if (tamagotchi.health == 100)
            {
                tamagotchi.status.setKrankzinnig(true);
            }
        }
    }
}
