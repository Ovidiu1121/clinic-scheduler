using ClinicScheduler.doctor.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.doctor.repository
{
    public interface IDoctorRepository
    {
        void Add(Doctor doctor);
        void EditById(int id, Doctor doctor);
        void Remove(int id);
        Doctor GetById(int id);
        Doctor GetByNume(string nume);
        List<Doctor> GetAllDoctors();
    }
}
