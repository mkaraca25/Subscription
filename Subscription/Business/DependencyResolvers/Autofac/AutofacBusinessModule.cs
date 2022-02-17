using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SubscriberModelManager>().As<ISubscriberModelService>().SingleInstance();
            builder.RegisterType<EfSubscriberModelDal>().As<ISubscriberModelDal>().SingleInstance();
        }

    }
}
