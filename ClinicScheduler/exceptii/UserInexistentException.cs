using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.exceptii
{
    public class UserInexistentException:Exception
    {
        public UserInexistentException() { }

        public UserInexistentException(string message) : base(message) { }

        public UserInexistentException(string message, Exception innerException) : base(message, innerException) { }
    }
}
