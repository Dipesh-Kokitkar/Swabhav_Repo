using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskManagement.Core.Repository;
using TaskManagement.Core.BusinessModel;

namespace TaskManagement.MVC.Services
{
    public class UserService
    {
        private UserRepository _respository;

        public UserService() {
            _respository = new UserRepository();
        }

        public bool ValidateUser(string username, string password) {
            return _respository.ValidateUser(username,password);
        }

        public User GetUserByName(string name) {
            return _respository.GetUserByName(name);
        }

        public User ConvertVMToUser(string username,string password,string mobileno,string email) {
            User user = new User { 
                Username = username,
                Password = password,
                MobileNumber = Convert.ToDouble(mobileno),
                Email = email };
            return user;
        }

        public void AddNewUser(User user) {
            _respository.AddNewUser(user);
        }
    }
}