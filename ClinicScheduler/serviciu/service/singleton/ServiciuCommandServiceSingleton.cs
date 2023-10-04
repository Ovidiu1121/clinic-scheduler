using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.serviciu.service.singleton
{
    public class ServiciuCommandServiceSingleton
    {
        private static readonly Lazy<ServiciuCommandService> _instance = new Lazy<ServiciuCommandService>(() => new ServiciuCommandService());

        public static ServiciuCommandService Instance => _instance.Value;

        private ServiciuCommandServiceSingleton() { }
    }
}
