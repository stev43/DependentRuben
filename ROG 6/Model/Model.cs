using ROG_6.Model.Instructies;
using ROG_6.Model.Spelregels;
using System;
using System.Collections.Generic;

namespace ROG_6.Model
{
    class Model
    {

        public Tamagotchi selectedTamagotchi
        {
            get;
            private set;
        }
        public List<Tamagotchi> tamagotchis
        {
            get;
            private set;
        }
        public List<ISpelregels> spelregels
        {
            get;
            private set;
        }
        public List<IInstructies> acties
        {
            get;
            private set;
        }

        public Model(List<IInstructies> acties, List<Tamagotchi> tamagotchis, List<ISpelregels> spelregels)
        {
            this.acties = acties;
            this.tamagotchis = tamagotchis;
            this.spelregels = spelregels;
        }

        public void rules(Tamagotchi tamagotchi)
        {
            double span = (DateTime.Now - tamagotchi.getLastAcces()).TotalHours;
            int hours = (int)(span);
            if (hours >= 1)
            {
                for (int i = hours; i > 0; i--)
                {
                    foreach (ISpelregels regel in spelregels)
                    {
                        regel.ExcecuteSpelregel(tamagotchi);
                    }
                }
                tamagotchi.setLastAcces(DateTime.Now);
            }
        }

        public void actie(Tamagotchi tamagotchi, IInstructies actie)
        {
            this.rules(tamagotchi);
            if (tamagotchi.getStatus().getOverleden() != null)
            {
                if (tamagotchi.getBezig() != true)
                {
                    int duur = actie.ExcecuteInstructie(tamagotchi);
                    tamagotchi.setBezig(duur);
                    tamagotchi.setLastAcces(DateTime.Now);
                }
            }
        }

        public void addSpelregel(ISpelregels regel)
        {
            spelregels.Add(regel);
        }

        public void addInstructie(IInstructies actie)
        {
            acties.Add(actie);
        }

        public void addTamagotchi(Tamagotchi tamagotchi)
        {
            tamagotchis.Add(tamagotchi);
        }

        public void kiesTamagotchi(int i)
        {
            i = i - 1;
            if (tamagotchis == null || tamagotchis.Count == 0)
                return;

            if (i >= 0 && i < tamagotchis.Count)
            {
                selectedTamagotchi = tamagotchis[i];
            }
        }

        public Tamagotchi createDeTamagotchi(string parameter)
        {
            Tamagotchi tamagotchi = new Tamagotchi(parameter);
            tamagotchis.Add(tamagotchi);
            selectedTamagotchi = tamagotchi;
            return tamagotchi;
        }

        public Boolean checkExsits(string parameter)
        {
            foreach (Tamagotchi t in tamagotchis)
            {
                if (t.getName() == parameter)
                    return true;
            }
            return false;
        }
    }
}
