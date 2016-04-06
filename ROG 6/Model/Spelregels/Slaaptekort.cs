
namespace ROG_6.Model.Spelregels
{

    class Slaaptekort : ISpelregels
    {

        public void ExcecuteSpelregel(Tamagotchi tamagotchi)
        {
            if (tamagotchi.getHunger() == 100 && tamagotchi.getStatus().getTopvorm() == false)
            {
                tamagotchi.getStatus().setOverleden(true);
            }
        }

    }

}
