using System;
using Autofac;
using Envoc.Mediator;

namespace Domain
{
    public class DomainModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            RegisterGeneric(builder, typeof(ICommandHandler<>));
            RegisterGeneric(builder, typeof(ICommandHandler<,>));
            RegisterGeneric(builder, typeof(IQueryHandler<,>));
            builder.Register(x =>
            {
                var ctx = x.Resolve<IComponentContext>();
                return new Mediator(ctx.Resolve);
            }).As<IMediator>();
        }

        private void RegisterGeneric(ContainerBuilder builder, Type type)
        {
            builder.RegisterAssemblyTypes(ThisAssembly)
                .AsClosedTypesOf(type)
                .AsImplementedInterfaces();
        }
    }
}