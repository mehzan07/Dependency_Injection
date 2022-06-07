using System;

namespace _1_DependecyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Injector injector = new Injector();
            
            Client cli= injector.ResolveClient();
            cli.UseService();

            Console.ReadLine();
        }
    }
}
