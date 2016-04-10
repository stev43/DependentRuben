using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Moq;
using Ninject;
using ROG_6.Model;
using ROG_6.Model.Instructies;
using ROG_6.Model.Spelregels;
using Ninject.MockingKernel;
using System.Reflection;

namespace UnitTestProject1
{
    class MockBinding : Ninject.Modules.NinjectModule
    {

        public override void Load()
        {

            Bind<IInstructies>().ToMock<Eet>();
            Bind<IInstructies>().ToMock<Knuffel>();
            Bind<IInstructies>().ToMock<Oefen>();
            Bind<IInstructies>().ToMock<Slaap>();
            Bind<IInstructies>().ToMock<Speel>();

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
