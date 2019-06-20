using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactoryMethodLib2;
using System.Reflection;
using System.Configuration;

namespace FactoryMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Case1();
            IAutomobile auto = LoadDataFromFile<IAutoFactory>().Make();
            auto.start();
            Console.ReadKey();
        }

        private static void Case1()
        {
            IAutoFactory Factory = BMWFactory.GetInstance();
            IAutomobile auto = Factory.Make();
            auto.start();
            auto.stop();
            Console.WriteLine(Factory);
        }

        static I LoadDataFromFile<I>() where I : class
        {
            string path = Environment.CurrentDirectory + "\\FactoryMethodLib2.dll";
            Assembly assembly = Assembly.LoadFrom(path);

            string factory = ConfigurationSettings.AppSettings["Factory"];
            Type type = assembly.GetType(factory);
            //MethodInfo TestMethod1 = type.GetMethod("GetInstance", BindingFlags.Static|BindingFlags.Public|BindingFlags.Instance);

            var f=type.GetMethod("GetInstance").Invoke(null, null);
            return f as I;


        }
    }
}
