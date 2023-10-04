using ClinicScheduler.doctor.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.doctor.service
{
    public interface IDoctorCommandService
    {
        void Add(Doctor doctor);
        void Remove(int id);
        void EditById(int id, Doctor doctor);
        List<Doctor> GetAllDoctors();

    }
}
