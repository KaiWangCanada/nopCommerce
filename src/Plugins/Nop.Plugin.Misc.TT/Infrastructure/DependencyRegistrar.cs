using Nop.Core.Infrastructure.DependencyManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Nop.Core.Configuration;
using Nop.Core.Infrastructure;
using Nop.Web.Framework.Mvc;
using Nop.Plugin.Misc.TT.Data;
using Nop.Plugin.Misc.TT.Domain;
using Nop.Core.Data;
using Autofac.Core;
using Nop.Data;

namespace Nop.Plugin.Misc.TT.Infrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        private const string CONTEXT_NAME = "nop_object_context_product_view_tracker";

        //public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        //{
        //    //data context
        //    this.RegisterPluginDataContext<TTRecordObjectContext>(builder, CONTEXT_NAME);

        //    //override required repository with our custom context
        //    builder.RegisterType<EfRepository<TTRecord>>()
        //        .As<IRepository<TTRecord>>()
        //        .WithParameter(ResolvedParameter.ForNamed<IDbContext>(CONTEXT_NAME))
        //        .InstancePerLifetimeScope();
        //}

        public void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config)
        {
            //data context
            this.RegisterPluginDataContext<TTRecordObjectContext>(builder, CONTEXT_NAME);

            //override required repository with our custom context
            builder.RegisterType<EfRepository<TTRecord>>()
                .As<IRepository<TTRecord>>()
                .WithParameter(ResolvedParameter.ForNamed<IDbContext>(CONTEXT_NAME))
                .InstancePerLifetimeScope();
        }

        public int Order
        {
            get { return 1; }
        }
    }
}
