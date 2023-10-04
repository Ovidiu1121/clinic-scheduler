using ClinicScheduler.exceptii;
using ClinicScheduler.user.model;
using ClinicScheduler.user.repository;
using ClinicScheduler.user.service.interfaces;
using ClinicScheduler.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.user.service
{
    public class UserCommandService : IUserCommandService
    {
        public IUserRepository userRepo;

        public UserCommandService()
        {
            userRepo = new UserRepository();
        }

        public void Add(User user)
        {
            List<User> users = this.userRepo.GetAllUsers();

            foreach (User u in users)
            {
                if (u.Equals(user))
                {
                    throw new ItemDejaExistentException(Constants.ITEM_DEJA_EXISTENT_EXCEPTION);
                }
            }

            this.userRepo.Add(user);
        }

        public void EditById(int id, User user)
        {
            List<User> users = this.userRepo.GetAllUsers();
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
                throw new ItemInexistentException(Constants.ITEM_INEXISTENT_EXCEPTION);
            }

            this.userRepo.EditById(id,user);
        }

        public List<User> GetAllUsers()
        {
            List<User> users = this.userRepo.GetAllUsers();

            return users;
        }

        public void Remove(int id)
        {
            List<User> users = this.userRepo.GetAllUsers();
            bool flag = false;
            User user = this.userRepo.GetById(id);

            foreach (User u in users)
            {
                if (u.Equals(user))
                {
                    flag=true;
                }
            }

            if (flag.Equals(false))
            {
                throw new ItemInexistentException(Constants.ITEM_INEXISTENT_EXCEPTION);
            }

            this.userRepo.Remove(id);
        }


    }
}
