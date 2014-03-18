using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Domain;

namespace learn.more.ef.command_query
{
    public class AutofacConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<DomainModule>();
            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}