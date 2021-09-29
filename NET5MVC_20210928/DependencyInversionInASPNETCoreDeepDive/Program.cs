using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyInversionInASPNETCoreDeepDive
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<ICar, Car>();

            //Diese Codezeile wird im Hintergrund ausgeführt 
            ServiceProvider provider = serviceCollection.BuildServiceProvider();


            ICar car = provider.GetRequiredService<ICar>(); //Bei Drittanbieter wie AutoFac oder Ninject, wird die Provider-Klasse ausgetauscht. 

            Console.WriteLine(car.Brand);
            Console.WriteLine(car.Model);
            Console.WriteLine(car.ConstructionYear);
        }
    }

    public interface ICar
    {
        string Brand { get; set; }
        string Model { get; set; }
        int ConstructionYear { get; set; }
    }

    public class Car : ICar
    {
        public string Brand { get; set; } = "VM";
        public string Model { get; set; } = "Polo";
        public int ConstructionYear { get; set; } = 2018;
    }
}
