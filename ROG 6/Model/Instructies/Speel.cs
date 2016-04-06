
namespace ROG_6.Model.Instructies
{
    class Speel : IInstructies
    {

        public int ExcecuteInstructie(Tamagotchi tamagotchi)
        {
            int boredom = tamagotchi.getBoredom();
            if (boredom < 10)
            {
                boredom = 0;
            }
            else
            {
                boredom -= 10;
            }
            tamagotchi.setBoredom(boredom);
            return 30;
        }

    }
}
