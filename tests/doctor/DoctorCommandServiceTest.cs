using ClinicScheduler.doctor.model;
using ClinicScheduler.doctor.repository;
using ClinicScheduler.programare.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace tests.doctor
{
    public class DoctorCommandServiceTest
    {
        private IDoctorRepository _repository = new DoctorRepository(TestConnectionString.GetConnection("Test"));

        [Fact]
        public void addTest()
        {
            Doctor doctor = Doctor.DoctorBuild()
                .setId(1)
                .setNume("numedoctor")
                .setParola("paroladoctor")
                .setTelefon(10000)
                .setNumeClinica("numeclinica")
                .setProgramari(new List<Programare>());

            _repository.Add(doctor);

            int id = _repository.GetLastId();

            doctor.setId(id);

            Doctor result = _repository.GetById(id);

            Assert.Equal(doctor, result);

            _repository.Clean();
        }

        [Fact]
        public void removeTest()
        {
            Doctor doctor = Doctor.DoctorBuild()
                 .setId(1)
                 .setNume("numedoctor")
                 .setParola("paroladoctor")
                 .setTelefon(10000)
                 .setNumeClinica("numeclinica")
                 .setProgramari(new List<Programare>());

            _repository.Add(doctor);

            int id = _repository.GetLastId();

            _repository.Remove(id);

            Assert.Empty(_repository.GetAllDoctors());

            _repository.Clean();
        }

        [Fact]
        public void getAllDoctorsTest()
        {
            Doctor doctor = Doctor.DoctorBuild()
                 .setId(1)
                 .setNume("numedoctor")
                 .setParola("paroladoctor")
                 .setTelefon(10000)
                 .setNumeClinica("numeclinica")
                 .setProgramari(new List<Programare>());
            Doctor doctor2 = Doctor.DoctorBuild()
                .setId(2)
                .setNume("numedoctor2")
                .setParola("paroladoctor2")
                .setTelefon(20000)
                .setNumeClinica("numeclinica2")
                .setProgramari(new List<Programare>());

            _repository.Add(doctor);
            _repository.Add(doctor2);

            List<Doctor> users = _repository.GetAllDoctors();
            int count = users.Count();
            int result = 2;

            Assert.Equal(count, result);

            _repository.Clean();
        }

        [Fact]
        public void editByIdTest()
        {
            Doctor doctor = Doctor.DoctorBuild()
                  .setId(1)
                  .setNume("numedoctor")
                  .setParola("paroladoctor")
                  .setTelefon(10000)
                  .setNumeClinica("numeclinica")
                  .setProgramari(new List<Programare>());
            Doctor doctor2 = Doctor.DoctorBuild()
                .setId(2)
                .setNume("numedoctor2")
                .setParola("paroladoctor2")
                .setTelefon(20000)
                .setNumeClinica("numeclinica2")
                .setProgramari(new List<Programare>());

            _repository.Add(doctor);

            int id = _repository.GetLastId();

            doctor.setId(id);
            doctor2.setId(id);

            _repository.EditById(id, doctor2);

            Doctor result = _repository.GetById(id);

            Assert.Equal(doctor2, result);

            _repository.Clean();
        }

    }
}
