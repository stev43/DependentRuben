using ROG_6.Model.Instructies;
using ROG_6.Model.Repo;
using ROG_6.Model.Spelregels;
using System;
using System.Collections.Generic;

namespace ROG_6.Model
{
    class Model
    {
        private UnitOfWork unitOfWork;
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

        public Model(List<IInstructies> acties, List<Tamagotchi> tamagotchis, List<ISpelregels> spelregels, UnitOfWork unitOfWork)
        {
            this.acties = acties;
            this.tamagotchis = tamagotchis;
            this.spelregels = spelregels;
            this.unitOfWork = unitOfWork;
        }

        public void rules(Tamagotchi tamagotchi)
        {
            double span = (DateTime.Now - tamagotchi.lastAcces).TotalHours;
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
                tamagotchi.lastAcces = (DateTime.Now);
            }
        }

        public void actie(Tamagotchi tamagotchi, IInstructies actie)
        {
            this.rules(tamagotchi);
            if (tamagotchi.status.getOverleden() != true)
            {
                if (tamagotchi.status.getBezig() != true)
                {
                    int duur = actie.ExcecuteInstructie(tamagotchi);
                    tamagotchi.status.setBezig(duur);
                    tamagotchi.lastAcces = DateTime.Now;
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

        public Tamagotchi createTamagotchi(string parameter)
        {
            Tamagotchi tamagotchi = new Tamagotchi(parameter);
            unitOfWork.Tamagotchis.Add(tamagotchi);
            tamagotchis = new List<Tamagotchi>(unitOfWork.Tamagotchis.GetAll());
            selectedTamagotchi = tamagotchi;
            return tamagotchi;
        }

        public Boolean checkExsits(string parameter)
        {
            foreach (Tamagotchi t in tamagotchis)
            {
                if (t.name == parameter)
                    return true;
            }
            return false;
        }
    }
}
