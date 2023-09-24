using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.user.model
{
    public interface IUserBuilder
    {
        User setId(int id);
        User setNume(string nume);
        User setParola(string parola);
        User setTip(int tip);
       
    }
}
