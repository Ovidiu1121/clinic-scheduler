using ClinicScheduler.doctor.model;
using ClinicScheduler.doctor.repository;
using ClinicScheduler.exceptii;
using ClinicScheduler.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.doctor.service
{
    public class DoctorQueryService
    {
        public IDoctorRepository repo;

        public DoctorQueryService()
        {
            repo = new DoctorRepository();
        }

        public Doctor GetById(int id)
        {
            List<Doctor> doctors = this.repo.GetAllDoctors();
            bool flag = false;
            Doctor doctor = this.repo.GetById(id);

            foreach (Doctor d in doctors)
            {
                if (d.Equals(doctor))
                {
                    flag=true;
                }
            }

            if (flag.Equals(false))
            {
                throw new ItemInexistentException(Constants.ITEM_INEXISTENT_EXCEPTION);
            }

            return doctor;
        }

        public Doctor GetByNume(string nume)
        {
            List<Doctor> doctors = this.repo.GetAllDoctors();
            bool flag = false;
            Doctor doctor = this.repo.GetByNume(nume);

            foreach (Doctor d in doctors)
            {
                if (d.Equals(doctor))
                {
                    flag=true;
                }
            }

            if (flag.Equals(false))
            {
                throw new ItemInexistentException(Constants.ITEM_INEXISTENT_EXCEPTION);
            }

            return doctor;
        }


    }
}
