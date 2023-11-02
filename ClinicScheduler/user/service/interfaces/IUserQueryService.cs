using ClinicScheduler.user.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.user.service.interfaces
{
    public interface IUserQueryService
    {
        User GetById(int id);
        User GetByNume(string nume);
        List<User> GetAllUsers();
    }
}
