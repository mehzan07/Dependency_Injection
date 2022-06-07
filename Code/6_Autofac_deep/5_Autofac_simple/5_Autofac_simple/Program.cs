
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
            serialized = JsonConvert.SerializeObject(obj, indented, settings); 
            return serialized;
        }

        static void Main(string[] args)
        {            
            // Register mappings
            var builder = new Autofac.ContainerBuilder();
            builder.RegisterType<S>().As<IS>();
            builder.RegisterType<T>().As<IT>();
            builder.RegisterType<U>().As<IU>();
            builder.RegisterType<V>().As<IV>();
            builder.RegisterType<Z>().As<IZ>();
            builder.RegisterType<X>().As<IX>();
            builder.RegisterType<C>().AsSelf();   
            Autofac.IContainer Container = builder.Build();    

            //Resolve object
            var c = Container.Resolve<C>();     

            // Json serialize object to see what we got
            Console.WriteLine(MySerialize(c));

            Console.ReadLine();
        }
    }
}
