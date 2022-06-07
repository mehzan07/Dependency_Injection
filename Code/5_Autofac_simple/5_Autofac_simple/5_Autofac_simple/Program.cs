
using Autofac;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace Example
{
    internal class Program
    {       
        public static string MySerialize(object obj)
        {
            string serialized = null;
            var indented = Newtonsoft.Json.Formatting.Indented;
            var settings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.All
            };
            serialized = JsonConvert.SerializeObject(obj, indented, settings); //(5)
            return serialized;
        }

        static void Main(string[] args)
        {            
            // Register mappings
            var builder = new Autofac.ContainerBuilder();
            builder.RegisterType<Service>().As<IService>(); //(1)
            builder.RegisterType<Client>().AsSelf();   //(2)
            Autofac.IContainer Container = builder.Build();    //(3)

            //Resolve object
            var client = Container.Resolve<Client>();     //(4)  

            // Json serialize object to see what we got
            Console.WriteLine(MySerialize(client));

            Console.ReadLine();
        }
    }
}
