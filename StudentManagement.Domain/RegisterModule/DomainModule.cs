using Autofac;
using StudentManagement.Domain.Interfaces;
using StudentManagement.Domain.Services;

namespace StudentManagement.Domain.RegisterModule
{
    public class DomainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(StudentService))
                 .As(typeof(IStudentService))
                 .InstancePerLifetimeScope().PropertiesAutowired(PropertyWiringOptions.AllowCircularDependencies);
        }
    }
}
