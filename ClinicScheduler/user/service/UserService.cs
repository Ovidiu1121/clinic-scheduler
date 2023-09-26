using ClinicScheduler.exceptii;
using ClinicScheduler.user.model;
using ClinicScheduler.user.repository;
using ClinicScheduler.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.user.service
{
    public class UserService : IUserService
    {
        public UserRepository userRepo;

        //Constructors

        public UserService()
        {
            userRepo = new UserRepository();
        }

        //Methods

        public void addUser(User user)
        {
            List<User> users = this.userRepo.getAllUsers();

            foreach (User u in users)
            {
                if (u.Equals(user))
                {
                    throw new UserDejaExistentException(Constants.USER_DEJA_EXISTENT_EXCEPTION);
                }
            }

            this.userRepo.addUser(user);
        }

        public void deleteUser(int id)
        {
            List<User> users = this.userRepo.getAllUsers();
            bool flag = false;
            User user = this.userRepo.getUserById(id);

            foreach (User u in users)
            {
                if (u.Equals(user))
                {
                    flag=true;
                }
            }

            if (flag.Equals(false))
            {
                throw new UserInexistentException(Constants.USER_INEXISTENT_EXCEPTION);
            }

            this.userRepo.deleteUser(id);
        }

        public List<User> getAllUsers()
        {
            List<User> users = this.userRepo.getAllUsers();

            return users;
        }

        public User getUserById(int id)
        {
            List<User> users = this.userRepo.getAllUsers();
            bool flag = false;
            User user = this.userRepo.getUserById(id);

            foreach (User u in users)
            {
                if (u.Equals(user))
                {
                    flag=true;
                }
            }

            if (flag.Equals(false))
            {
                throw new UserInexistentException(Constants.USER_INEXISTENT_EXCEPTION);
            }

            return user;
        }

        public void updateUser(User user)
        {
            List<User> users = this.userRepo.getAllUsers();
            bool flag = false;

            foreach (User u in users)
            {
                if (u.Equals(user))
                {
                    flag=true;
                }
            }

            if (flag.Equals(false))
            {
                throw new UserInexistentException(Constants.USER_INEXISTENT_EXCEPTION);
            }

            this.userRepo.updateUser(user);
        }

        public bool isUser(User user)
        {
            List<User> users = this.userRepo.getAllUsers();
            bool flag = false;

            foreach (User u in users)
            {
                if (u.Equals(user))
                {
                    flag=true;
                }
            }

            return flag;
        }


    }
}
