using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Extension
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection serviceCollection, ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(serviceCollection);//Birden falza modul ekleyebileceğimizi gösteriyor
            }
            return ServiceTool.Create(serviceCollection);
        }
    }
}
