
namespace ROG_6.Model.Spelregels
{
    class Crazy : ISpelregels
    {
        public void ExcecuteSpelregel(Tamagotchi tamagotchi)
        {
            if (tamagotchi.getStatus().getKrankzinnig() == true && tamagotchi.getHealth() == 100)
            {
                tamagotchi.getStatus().setKrankzinnig(false);
            }
            if (tamagotchi.getHealth() == 100)
            {
                tamagotchi.getStatus().setKrankzinnig(true);
            }
        }
    }
}
