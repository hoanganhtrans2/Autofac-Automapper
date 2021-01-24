using Autofac;
using EF6CodeFirstDemo;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public static class AutofacConfig
    {
        public static IContainer Confing()
        {
            var builder = new ContainerBuilder();
            //builder.RegisterType<GenericRepository<Grade>>().As<IGenericRepository<Grade>>();
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();

            return builder.Build();
        }
    }
}
