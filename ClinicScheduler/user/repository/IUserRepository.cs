using ClinicScheduler.user.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.user.repository
{
    public interface IUserRepository
    {

        void addUser(User user);
        void updateUser(User user);
        void deleteUser(int id);
        User getUserById(int id);
        List<User> getAllUsers();

    }
}
