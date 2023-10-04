using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.pacient.service.singleton
{
    public class PacientCommandServiceSingleton
    {
        private static readonly Lazy<PacientCommandService> _instance = new Lazy<PacientCommandService>(() => new PacientCommandService());

        public static PacientCommandService Instance => _instance.Value;

        private PacientCommandServiceSingleton() { }
    }
}
