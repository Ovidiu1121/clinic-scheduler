using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.doctor.service.singleton
{
    public class DoctorQueryServiceSingleton
    {
        private static readonly Lazy<DoctorQueryService> _instance = new Lazy<DoctorQueryService>(() => new DoctorQueryService());

        public static DoctorQueryService Instance => _instance.Value;

        private DoctorQueryServiceSingleton() { }
    }
}
