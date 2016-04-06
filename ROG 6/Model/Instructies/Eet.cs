
namespace ROG_6.Model.Instructies
{
    class Eet : IInstructies
    {

        public int ExcecuteInstructie(Tamagotchi tamagotchi)
        {
            tamagotchi.setHealth(0);
            return 30;
        }

    }
}
