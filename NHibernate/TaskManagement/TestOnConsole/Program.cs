using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.BusinessModel;
using TaskManagement.Core;
using NHibernate;

namespace TestOnConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read");
            Console.ReadKey();

            UserSubTask subtask = new UserSubTask { Id = 11, SubTaskName = "maths", SubTaskDescription = "Dp it" };


           

            UserTask task = new UserTask
            {
                Id = 10,
                TaskName = "Homework",
                TaskDiscription = "do it",
                TaskCreationDate = DateTime.Parse("7/27/2019"),
                TaskDeadline = DateTime.Parse("7/28/2019")
            };

            User user = new User
            {
                Id = 1,
                Username = "dipesh",
                Password = "abc",
                MobileNumber = 123,
                Email = "xyz@"
            };


            subtask.UserTask = task;
            task.UserSubTasks.Add(subtask);
            task.User = user;

            user.Tasks.Add(task);

            using (ISession session = Helper.OpenSession()) {
                session.Save(user);
                session.Save(task);
                session.Save(subtask);
                Console.WriteLine("Table create");
            }
        }
    }
}
