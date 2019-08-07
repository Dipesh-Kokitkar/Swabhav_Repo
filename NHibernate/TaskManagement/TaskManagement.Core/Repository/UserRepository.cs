using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.BusinessModel;
using NHibernate;

namespace TaskManagement.Core.Repository
{
    public class UserRepository
    {
        public void AddNewUser(User user)
        {

            using (ISession session = Helper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(user);
            }
        }

        public User GetUserByName(string name) {
            using (ISession session = Helper.OpenSession()) {
                var userlist = session.CreateCriteria<User>().List<User>();

                foreach (User user in userlist) {
                    if (user.Username.Equals(name)) {
                        return user;
                    }
                }
            }
            return null;
        }

        public User GetUserById(Guid id)
        {
            using (ISession session = Helper.OpenSession())
                return session.Get<User>(id);
        }

        public List<UserTask> GetUserTasks(Guid id)
        {
            User user = GetUserById(id);
            using (ISession session = Helper.OpenSession())
            {
                return user.Tasks.ToList<UserTask>();
            }
        }

        public bool ValidateUser(string username,string password) {
            using (ISession session = Helper.OpenSession()) {
                var users = session.CreateCriteria<User>().List<User>();

                foreach (User user in users) {
                    if (user.Username.Equals(username) && user.Password.Equals(password)) {
                        return true;
                    }
                }
                return false;
            }
        }

        public void UpdateUserInfo(Guid id, User Updated)
        {
            User user = GetUserById(id);
            using (ISession session = Helper.OpenSession())
            {


                user.Username = Updated.Username;
                user.MobileNumber = Updated.MobileNumber;
                user.Email = Updated.Email;

            }

        }

        public void DeleteUser(Guid id)
        {
            User user = GetUserById(id);
            using (ISession session = Helper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(user);
                transaction.Commit();
            }
        }

        public void PasswordReset(string username, string newpassword)
        {
            using (ISession session = Helper.OpenSession())
            {
                var queryResults = session.CreateCriteria<User>().List<User>();
                foreach (User user in queryResults)
                {
                    if (user.Username.Equals(username))
                    {
                        user.Password = newpassword;
                    }
                }
            }
        }
    }
}
