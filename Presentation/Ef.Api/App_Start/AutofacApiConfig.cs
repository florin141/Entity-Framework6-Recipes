using Autofac;
using Autofac.Integration.WebApi;
using Ef.Core.Data;
using Ef.Data;
using Ef.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace Ef.Api
{
    public class AutofacApiConfig
    {
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            // REGISTER DEPENDENCIES
            builder.Register<DbContext>(ctx => new EfObjectContext()).InstancePerRequest();
            builder.RegisterGeneric(typeof(EfRepository<>)).As(typeof(IRepository<>)).InstancePerRequest();

            builder.RegisterType<SimpleModelService>().As<ISimpleModelService>().InstancePerRequest();
            builder.RegisterType<AlbumService>().As<IAlbumService>().InstancePerRequest();
            builder.RegisterType<ArtistService>().As<IArtistService>().InstancePerRequest();
            builder.RegisterType<AssociateService>().As<IAssociateService>().InstancePerRequest();
            builder.RegisterType<AssociateSalaryService>().As<IAssociateSalaryService>().InstancePerRequest();

            // REGISTER CONTROLLERS SO DEPENDENCIES ARE CONSTRUCTOR INJECTED
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // BUILD THE CONTAINER
            var container = builder.Build();

            // REPLACE THE MVC DEPENDENCY RESOLVER WITH AUTOFAC
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}