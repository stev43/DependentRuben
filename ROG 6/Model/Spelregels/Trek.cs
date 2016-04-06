
namespace ROG_6.Model.Spelregels
{
    class Trek : ISpelregels
    {

        private Honger honger;

        public Trek(Honger honger)
        {
            this.honger = honger;
        }

        public void ExcecuteSpelregel(Tamagotchi tamagotchi)
        {
            int boredom = tamagotchi.getBoredom();
            if (boredom > 80)
            {
                honger.ExcecuteSpelregel(tamagotchi);
            }

        }
    }
}
