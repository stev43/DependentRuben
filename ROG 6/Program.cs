using Ninject;
using ROG_6.Model;
using ROG_6.Model.Instructies;
using ROG_6.Model.Spelregels;
using System.Collections.Generic;
using System.Reflection;

namespace ROG_6
{
    class Program
    {
        static void Main(string[] args)
        {

            var kernel = new StandardKernel(new Bindings());
            kernel.Load(Assembly.GetExecutingAssembly());
            var acties = kernel.Get<List<IInstructies>>();
            var spelregels = kernel.Get<List<ISpelregels>>();
            var tamagotchis = kernel.Get<List<Tamagotchi>>();

            var model = new Model.Model(acties, tamagotchis, spelregels);

        }
    }
}
