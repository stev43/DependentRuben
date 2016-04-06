
namespace ROG_6.Model.Instructies
{
    class Slaap : IInstructies
    {
        public int ExcecuteInstructie(Tamagotchi tamagotchi)
        {
            tamagotchi.setSleep(0);
            return 7200;
        }
    }
}
