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
    public class DoctorQueryServiceTest
    {
        private IDoctorRepository _repository = new DoctorRepository(TestConnectionString.GetConnection("Test"));

        [Fact]
        public void getByIdTest()
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
        public void getByNameTest()
        {
            Doctor doctor = Doctor.DoctorBuild()
              .setId(1)
              .setNume("numedoctor2")
              .setParola("paroladoctor")
              .setTelefon(10000)
              .setNumeClinica("numeclinica")
              .setProgramari(new List<Programare>());

            _repository.Add(doctor);

            int id = _repository.GetLastId();

            doctor.setId(id);

            Doctor result = _repository.GetByNume("numedoctor2");

            Assert.Equal(doctor, result);

            _repository.Clean();
        }


    }
}
