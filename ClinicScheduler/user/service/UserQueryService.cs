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
    public class UserQueryService : IUserQueryService
    {
        public UserRepository userRepo;

        public UserQueryService()
        {
            userRepo = new UserRepository();
        }

        public User GetById(int id)
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

            return user;
        }

        public User GetByNume(string nume)
        {
            List<User> users = this.userRepo.GetAllUsers();
            bool flag = false;
            User user = this.userRepo.GetByNume(nume);

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

            return user;
        }

        public List<User> GetAllUsers()
        {
            List<User> users = this.userRepo.GetAllUsers();

            return users;
        }

    }
}
