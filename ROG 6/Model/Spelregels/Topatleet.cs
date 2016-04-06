
using ROG_6.Model.Status;
using System.Collections.Generic;
namespace ROG_6.Model.Spelregels
{
    class Topatleet : ISpelregels
    {

        public void ExcecuteSpelregel(Tamagotchi tamagotchi)
        {
            if (tamagotchi.getHealth() < 20)
            {
                List<IStatus> Status = tamagotchi.getStatus();

            }
        }
    }
}
