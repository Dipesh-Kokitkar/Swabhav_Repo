using System;
using System.Reflection;

namespace ReflectionApp
{
    class Program
    {
        public static void ClassInfo(Type type) {

            Console.WriteLine("Analysis of type: "+type.Name);
            Console.WriteLine("Name:"+type.Name);
            Console.WriteLine("Fullname:"+type.FullName);
            Console.WriteLine("Namespace:"+type.Namespace);
            Console.WriteLine("Base Type:"+type.BaseType);
        }

        public static void MethodsInfo(Type type) {

            Console.WriteLine("\t Methods");
            MethodInfo[] methodinfo = type.GetMethods();
            foreach (MethodInfo methods in methodinfo) {
                Console.WriteLine("-->"+methods.Name);
            }
        }

        public static void GetFields(Type type) {
            Console.WriteLine("\tFields");
            FieldInfo[] fieldinfo = type.GetFields();
            foreach (FieldInfo field in fieldinfo) {
                Console.WriteLine("-->"+field.Name);
            }
        }

        public static void GetProperties(Type type) {
            Console.WriteLine("\tProperties");
            PropertyInfo[] propertiesinfo = type.GetProperties();
            foreach (PropertyInfo property in propertiesinfo) {
                Console.WriteLine("-->"+property.Name);
            }
        }
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(20,30);
            Console.WriteLine("Lenght:"+rectangle1.Lenght+"\tBreath:"+rectangle1.Breath);
            Console.WriteLine("Area:"+rectangle1.CalculateArea());

            Type type = typeof(Rectangle);
            ClassInfo(type);
            MethodsInfo(type);
            GetFields(type);
            GetProperties(type);
        }
    }
}
