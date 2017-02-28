using Ninject;
using ROG_6.Model;
using ROG_6.Model.Instructies;
using ROG_6.Model.Spelregels;
using System.Collections.Generic;
using System.Reflection;

namespace ROG_6
{
    public class LogicTestClass
    {
        List<IInstructies> acties;
        List<ISpelregels> spelregels;
        public LogicTestClass()
        {
            var kernel = new StandardKernel(new Bindings());
            kernel.Load(Assembly.GetExecutingAssembly());
            acties = kernel.Get<List<IInstructies>>();
            spelregels = kernel.Get<List<ISpelregels>>();
            acties.Add(new BaseInstructie());
        }
        public int doActie(Tamagotchi t, int i)
        {
            return acties[i].ExcecuteInstructie(t);
        }

        public string getName(int i)
        {
            return acties[i].getName();
        }

        public void doSpelregel(Tamagotchi t, int i)
        {
            spelregels[i].ExcecuteSpelregel(t);
        }
    }
}
