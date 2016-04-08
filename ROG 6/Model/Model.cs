﻿using ROG_6.Model.Instructies;
using ROG_6.Model.Spelregels;
using System.Collections.Generic;

namespace ROG_6.Model
{
    class Model
    {

        private Tamagotchi selectedTamagotchi;
        private List<Tamagotchi> tamagotchis;
        private List<ISpelregels> spelregels;
        private List<IInstructies> acties;

        public Model(List<IInstructies> acties, List<Tamagotchi> tamagotchis, List<ISpelregels> spelregels)
        {
            this.acties = acties;
            this.tamagotchis = tamagotchis;
            this.spelregels = spelregels;
        }

        public void run()
        {
            foreach (Tamagotchi tamagotchi in tamagotchis)
            {
                foreach (ISpelregels regel in spelregels)
                {
                    regel.ExcecuteSpelregel(tamagotchi);
                }
            }
        }

        public void actie(Tamagotchi tamagotchi, IInstructies actie)
        {
            int duur = actie.ExcecuteInstructie(tamagotchi);
            tamagotchi.setBezig(duur);
        }

        public void addSpelregel(ISpelregels regel)
        {
            spelregels.Add(regel);
        }

        public void addInstructie(IInstructies actie)
        {
            acties.Add(actie);
        }

        public void kiesTamagotchi(int i)
        {
            if (tamagotchis == null || tamagotchis.Count == 0)
                return;

            if (i >= 0 || i < tamagotchis.Count)
            {
                selectedTamagotchi = tamagotchis[i];
            }
        }


    }
}
