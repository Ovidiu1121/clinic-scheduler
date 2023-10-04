using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.programare.service.singleton
{
    public class ProgramareQueryServiceSingleton
    {
        private static readonly Lazy<ProgramareQueryService> _instance = new Lazy<ProgramareQueryService>(() => new ProgramareQueryService());

        public static ProgramareQueryService Instance => _instance.Value;

        private ProgramareQueryServiceSingleton() { }
    }
}
