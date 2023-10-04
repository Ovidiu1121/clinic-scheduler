using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.serviciu.service.singleton
{
    public class ServiciuQueryServiceSingleton
    {
        private static readonly Lazy<ServiciuQueryService> _instance = new Lazy<ServiciuQueryService>(() => new ServiciuQueryService());

        public static ServiciuQueryService Instance => _instance.Value;

        private ServiciuQueryServiceSingleton() { }
    }
}
