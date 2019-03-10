using DataHelper.Provider;
using DataHelper.Provider.Contract;
using DataHelper.Service;
using DataHelper.Service.Contract;
using Ninject.Modules;
using Ninject.Web.Mvc.FilterBindingSyntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BxFinTask.Code
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IArrayHelperProvider>().To<ArrayHelperProvider>();
            Bind<IArrayHelperService>().To<ArrayHelperService>();
        }
    }
}