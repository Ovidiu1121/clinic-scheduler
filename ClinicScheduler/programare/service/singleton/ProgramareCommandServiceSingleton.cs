using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.programare.service.singleton
{
    public class ProgramareCommandServiceSingleton
    {
        private static readonly Lazy<ProgramareCommandService> _instance = new Lazy<ProgramareCommandService>(() => new ProgramareCommandService());

        public static ProgramareCommandService Instance => _instance.Value;

        private ProgramareCommandServiceSingleton() { }
    }
}
