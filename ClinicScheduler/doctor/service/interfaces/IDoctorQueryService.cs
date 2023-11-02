using ClinicScheduler.doctor.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.doctor.service.interfaces
{
    public interface IDoctorQueryService
    {
        Doctor GetById(int id);
        Doctor GetByNume(string nume);
        List<Doctor> GetAllDoctors();
    }
}
