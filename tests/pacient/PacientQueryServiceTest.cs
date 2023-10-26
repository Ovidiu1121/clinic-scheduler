using ClinicScheduler.pacient.model;
using ClinicScheduler.pacient.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace tests.pacient
{
    public class PacientQueryServiceTest
    {
        private IPacientRepository _repository = new PacientRepository(TestConnectionString.GetConnection("Test"));

        [Fact]
        public void getByIdTest()
        {
            Pacient pacient = Pacient.PacientBuild()
                .setId(1)
                .setNume("nume")
                .setParola("parola")
                .setDob(new DateTime(2022, 4, 21));

            _repository.Add(pacient);

            int id = _repository.GetLastId();
            pacient.setId(id);

            Pacient result = _repository.GetById(id);

            Assert.Equal(pacient, result);

            _repository.Clean();
        }

        [Fact]
        public void getByNameTest()
        {
            Pacient pacient = Pacient.PacientBuild()
                .setId(1)
                .setNume("nume2")
                .setParola("parola2")
                .setDob(new DateTime(2022, 4, 21));

            _repository.Add(pacient);

            int id = _repository.GetLastId();

            pacient.setId(id);

            Pacient result = _repository.GetByNume("nume2");

            Assert.Equal(pacient, result);

            _repository.Clean();
        }

    }
}
