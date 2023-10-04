using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.doctor.service.singleton
{
    public class DoctorCommandServiceSingleton
    {
        private static readonly Lazy<DoctorCommandService> _instance = new Lazy<DoctorCommandService>(() => new DoctorCommandService());

        public static DoctorCommandService Instance => _instance.Value;

        private DoctorCommandServiceSingleton() { }
    }
}
