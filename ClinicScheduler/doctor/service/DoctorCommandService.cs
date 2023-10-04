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
    public class DoctorCommandService:IDoctorCommandService
    {
        private IDoctorRepository repo;

        public DoctorCommandService()
        {
            this.repo = new DoctorRepository();
        }

        public void Add(Doctor doctor)
        {
            List<Doctor> doctors = this.repo.GetAllDoctors();

            foreach (Doctor d in doctors)
            {
                if (d.Equals(doctor))
                {
                    throw new ItemDejaExistentException(Constants.ITEM_DEJA_EXISTENT_EXCEPTION);
                }
            }

            this.repo.Add(doctor);
        }

        public void EditById(int id, Doctor doctor)
        {
            List<Doctor> doctors = this.repo.GetAllDoctors();
            bool flag = false;

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

            this.repo.EditById(id, doctor);
        }

        public List<Doctor> GetAllDoctors()
        {
            List<Doctor> doctors = this.repo.GetAllDoctors();

            return doctors;
        }

        public void Remove(int id)
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

            this.repo.Remove(id);
        }
    }
}
