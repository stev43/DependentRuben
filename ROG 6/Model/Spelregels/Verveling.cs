
namespace ROG_6.Model.Spelregels
{
    class Verveling : ISpelregels
    {

        public void ExcecuteSpelregel(Tamagotchi tamagotchi)
        {
            int boredom = tamagotchi.getBoredom();
            if (boredom > 85)
            {
                boredom = 100;
            }
            else
            {
                boredom += 15;
            }
            tamagotchi.setBoredom(boredom);
        }

    }
}
