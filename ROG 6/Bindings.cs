using ROG_6.Model.Instructies;
using ROG_6.Model.Spelregels;

namespace ROG_6
{
    class Bindings : Ninject.Modules.NinjectModule
    {

        public override void Load()
        {

            Bind<IInstructies>().To<Eet>();
            Bind<IInstructies>().To<Knuffel>();
            Bind<IInstructies>().To<Oefen>();
            Bind<IInstructies>().To<Slaap>();
            Bind<IInstructies>().To<Speel>();

            Bind<ISpelregels>().To<Isolatie>();
            Bind<ISpelregels>().To<Topatleet>();
            Bind<ISpelregels>().To<Crazy>();
            Bind<ISpelregels>().To<Vermoeidheid>();
            Bind<ISpelregels>().To<Slaaptekort>();
            Bind<ISpelregels>().To<Verveling>();
            Bind<ISpelregels>().To<Trek>();
            Bind<ISpelregels>().To<Honger>();
            Bind<ISpelregels>().To<Voedseltekort>();

        }

    }
}
