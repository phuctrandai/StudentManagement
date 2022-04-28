using Autofac;
using StudentManagement.Domain.Context;
using StudentManagement.Domain.Interfaces;

namespace StudentManagement.Domain.RegisterModule
{
    public class DomainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(StudentRepository))
                 .As(typeof(IStudentRepository))
                 .InstancePerLifetimeScope().PropertiesAutowired(PropertyWiringOptions.AllowCircularDependencies);
        }
    }
}
