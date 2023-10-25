using ClinicScheduler.doctor.model;
using ClinicScheduler.doctor.repository;
using ClinicScheduler.pacient.model;
using ClinicScheduler.pacient.repository;
using ClinicScheduler.programare.model;
using ClinicScheduler.programare.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace tests.programare
{
    public class ProgramareCommandServiceTest
    {
        private IProgramareRepository _repository = new ProgramareRepository(TestConnectionString.GetConnection("Test"));
        private IDoctorRepository _doctorRepository = new DoctorRepository(TestConnectionString.GetConnection("Test"));
        private IPacientRepository _pacientRepository = new PacientRepository(TestConnectionString.GetConnection("Test"));

        [Fact]
        public void addTest()
        {
            Pacient pacient = Pacient.PacientBuild()
                .setId(1)
                .setNume("numepacient")
                .setParola("parolapacient")
                .setDob(new DateTime(2022, 4, 21));

            Doctor doctor = Doctor.DoctorBuild()
                .setId(1)
                .setNume("numedoctor")
                .setParola("paroladoctor")
                .setTelefon(10000)
                .setNumeClinica("numeclinica")
                .setProgramari(new List<Programare>());

            _doctorRepository.Add(doctor);
            _pacientRepository.Add(pacient);

            Programare programare = Programare.ProgramareBuild()
                .setId(1)
                .setPacientId(1)
                .setDoctorId(1)
                .setDataInceput(new DateTime(2020, 3, 21))
                .setDataSfarsit(new DateTime(2020, 3, 25));

            _repository.Add(programare);

            int id = _repository.GetLastId();

            programare.setId(id);

            Programare result = _repository.GetById(id);

            Assert.Equal(programare, result);

            _repository.Clean();
            _doctorRepository.Clean();
            _pacientRepository.Clean();
        }






    }
}
