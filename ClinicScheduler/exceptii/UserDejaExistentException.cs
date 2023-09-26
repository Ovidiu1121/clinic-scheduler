using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.exceptii
{
    public class UserDejaExistentException:Exception
    {
       public UserDejaExistentException() { }

       public UserDejaExistentException(string message) : base(message) { }

       public UserDejaExistentException(string message, Exception innerException) : base(message, innerException) { }

    }
}
