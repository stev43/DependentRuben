
namespace ROG_6.Model.Spelregels
{
    class Vermoeidheid : ISpelregels
    {

        public void ExcecuteSpelregel(Tamagotchi tamagotchi)
        {

            int sleep = tamagotchi.sleep;
            if (sleep > 95)
            {
                sleep = 100;
            }
            else
            {
                sleep += 5;
            }
            tamagotchi.sleep = sleep;
        }
    }
}
