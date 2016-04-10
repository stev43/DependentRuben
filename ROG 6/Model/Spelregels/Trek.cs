
namespace ROG_6.Model.Spelregels
{
    class Trek : ISpelregels
    {

        public void ExcecuteSpelregel(Tamagotchi tamagotchi)
        {
            int boredom = tamagotchi.boredom;
            if (boredom > 80)
            {
                tamagotchi.status.setHongerig(true);
            }
            else
            {
                if (tamagotchi.status.getHongerig() == true && boredom <= 80)
                {
                    tamagotchi.status.setHongerig(false);
                }
            }

        }
    }
}
