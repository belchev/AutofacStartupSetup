using Autofac;
using AutofacStartupSetup.Controllers;
using AutofacStartupSetup.Repositories.UserRepo;
using AutofacStartupSetup.Utils.Data;

namespace AutofacStartupSetup.Utils
{
    public class DatabaseModelModule : Module
    {
        protected override void Load(ContainerBuilder moduleBuilder)
        {
            moduleBuilder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();

            moduleBuilder.RegisterType<DbConfiguration>().As<IDbConfiguration>().SingleInstance();
            moduleBuilder.RegisterType<UserRepo>().As<IUserRepo>().InstancePerLifetimeScope();

            moduleBuilder.RegisterType<UserController>().InstancePerLifetimeScope();
        }
    }
}