using Ninject;
using ROG_6.Model;
using ROG_6.Model.Instructies;
using ROG_6.Model.Repo;
using ROG_6.Model.Spelregels;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ROG_6
{
    class Program
    {

        static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork(new TamaContext()))
            {
                if (unitOfWork.Tamagotchis == null)
                {
                    unitOfWork.Tamagotchis.Add(new Tamagotchi("steven", 0, 0, 0, 0, DateTime.Now));
                }
                var kernel = new StandardKernel(new Bindings());
                kernel.Load(Assembly.GetExecutingAssembly());
                var acties = kernel.Get<List<IInstructies>>();
                var spelregels = kernel.Get<List<ISpelregels>>();
                List<Tamagotchi> tamagotchis = new List<Tamagotchi>(unitOfWork.Tamagotchis.GetAll());

                Model.Model model = new Model.Model(acties, tamagotchis, spelregels, unitOfWork);
                View.View view = new View.View();
                Controller controller = new Controller(model, view);

                controller.Start();
            }
        }
    }
}
