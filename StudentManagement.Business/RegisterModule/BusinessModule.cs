using Autofac;
using StudentManagement.Business.BusinessServices;
using StudentManagement.Business.Interfaces;

namespace StudentManagement.Business.RegisterModule
{
    public class BusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(StudentBusiness))
                 .As(typeof(IStudentBusiness))
                 .InstancePerLifetimeScope().PropertiesAutowired(PropertyWiringOptions.AllowCircularDependencies);
        }
    }
}
