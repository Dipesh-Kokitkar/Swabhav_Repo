using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace CustomerHibernateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read key:");
            Console.ReadKey();


            Configuration config = new Configuration();
            config.Configure();
            config.AddAssembly(typeof(Customer).Assembly);
            SchemaExport schema = new SchemaExport(config);
            schema.Execute(true, true, false);
            var factory = config.BuildSessionFactory();
            InsertData(factory);
            ReadData(factory);
            
        }

        private static void InsertData(NHibernate.ISessionFactory factory)
        {
            using (var session = factory.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                Customer customer1 = new Customer();
                //customer1.Id = 1;
                customer1.FirstName = "Dipesh";
                customer1.LastName = "Kokitkar";
                transaction.Begin();
                session.Save(customer1);

                //session.Save(new Customer {FirstName="Dipesh",LastName="Kokitkar"});
                //session.Save(new Customer {FirstName = "Dipali", LastName = "Kokitkar" });
                transaction.Commit();
                Console.WriteLine("TAble Created");

            }

          
        }
        private static void ReadData(NHibernate.ISessionFactory factory)
        {
            using (var session = factory.OpenSession())
            using (var transaction = session.BeginTransaction()) {
                var customer = session.Get<Customer>(1);
                Console.WriteLine("Name:"+customer.FirstName+" "+customer.LastName);
            }
        }
    }
}
