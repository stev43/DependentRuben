
namespace ROG_6.Model.Spelregels
{
    class Trek : ISpelregels
    {

        public void ExcecuteSpelregel(Tamagotchi tamagotchi)
        {
            int boredom = tamagotchi.getBoredom();
            if (boredom > 80)
            {
                tamagotchi.getStatus().setHongerig(true);
            }
            else
            {
                if (tamagotchi.getStatus().getHongerig() == true && boredom <= 80)
                {
                    tamagotchi.getStatus().setHongerig(false);
                }
            }

        }
    }
}
