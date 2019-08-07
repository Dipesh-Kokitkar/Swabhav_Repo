using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.BusinessModel;
using NHibernate;

namespace TaskManagement.Core.Repository
{
    public class TaskRespository
    {

        public void AddNewTask(Guid id,UserTask task) {
            
            using (ISession session = Helper.OpenSession())
            using (ITransaction transaction=session.BeginTransaction())
            {
                var user = session.Get<User>(id);
                user.Tasks.Add(task);
                task.User = user;
                session.SaveOrUpdate(user);
                transaction.Commit();
            }
        }

        public string GetUsername(Guid id) {
            using (ISession session = Helper.OpenSession()) {
                return session.Get<User>(id).Username;
            }
        }

        public void UpdateTask(Guid id, UserTask updated) {
            using (ISession session = Helper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                UserTask task = GetTaskById(id);
                task.TaskName = updated.TaskName;
                task.TaskDiscription = updated.TaskDiscription;
                task.TaskDeadline = updated.TaskDeadline;

                session.Save(task);
                transaction.Commit();
            }

        }

        public void DeleteTask(Guid id) {
            UserTask task = GetTaskById(id);
            using (ISession session = Helper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction()) {
                session.Delete(task);
                transaction.Commit();
            }

        }

        public UserTask GetTaskById(Guid id) {
            using (ISession session = Helper.OpenSession()) {
                return session.Get<UserTask>(id);
            }
        }

        public UserSubTask GetSubTaskById(Guid id)
        {
            using (ISession session = Helper.OpenSession())
            {
                return session.Get<UserSubTask>(id);
            }
        }

        public List<UserSubTask> GetAllSubTasks( UserTask task) {
            return task.UserSubTasks.ToList();
        }

        public List<UserTask> GetAllTasks(User user) {
            return user.Tasks.ToList();
        }

        public void AddNewSubTask(Guid id, UserSubTask subtask) {
            using (ISession session = Helper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction()) {

                UserTask task = GetTaskById(id);

                task.UserSubTasks.Add(subtask);
                subtask.UserTask = task;
                session.SaveOrUpdate(task);
                transaction.Commit();
            }

        }

        public void UpdateSubTask(Guid id,UserSubTask updated) {
            UserSubTask subtask = GetSubTaskById(id);

            subtask.SubTaskName = updated.SubTaskName;
            subtask.SubTaskDescription = updated.SubTaskDescription;

            using (ISession session = Helper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction()) {
                session.SaveOrUpdate(subtask);
                transaction.Commit();
            }
        }

        public void DeleteSubTask(Guid id) {
            UserSubTask subtask = GetSubTaskById(id);

            using (ISession session = Helper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(subtask);
                transaction.Commit();
            }
        }
    }
}
