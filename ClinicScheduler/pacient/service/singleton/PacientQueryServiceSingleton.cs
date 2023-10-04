using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.pacient.service.singleton
{
    public class PacientQueryServiceSingleton
    {
        private static readonly Lazy<PacientQueryService> _instance = new Lazy<PacientQueryService>(() => new PacientQueryService());

        public static PacientQueryService Instance => _instance.Value;

        private PacientQueryServiceSingleton() { }
    }
}
