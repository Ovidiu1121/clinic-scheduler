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
    public class PacientCommandServiceTest
    {
        private IPacientRepository _repository = new PacientRepository(TestConnectionString.GetConnection("Test"));

        [Fact]
        public void addTest()
        {
            Pacient pacient = Pacient.PacientBuild()
                .setId(1)
                .setNume("numepacient")
                .setParola("parolapacient")
                .setDob(new DateTime(2022, 4, 21));

            _repository.Add(pacient);

            int id = _repository.GetLastId();

            pacient.setId(id);

            Pacient result = _repository.GetById(id);

            Assert.Equal(pacient, result);

            _repository.Clean();
        }

        [Fact]
        public void removeTest()
        {
            Pacient pacient = Pacient.PacientBuild()
                .setId(1)
                .setNume("numepacient")
                .setParola("parolapacient")
                .setDob(new DateTime(2022, 4, 21));

            _repository.Add(pacient);

            int id = _repository.GetLastId();

            _repository.Remove(id);

            Assert.Empty(_repository.GetAllPacients());

            _repository.Clean();
        }

        [Fact]
        public void getAllPacientsTest()
        {
            Pacient pacient = Pacient.PacientBuild()
                .setId(1)
                .setNume("numepacient")
                .setParola("parolapacient")
                .setDob(new DateTime(2022, 4, 21));
            Pacient pacient2 = Pacient.PacientBuild()
                .setId(2)
                .setNume("numepacient2")
                .setParola("parolapacient2")
                .setDob(new DateTime(2013, 2, 7));

            _repository.Add(pacient);
            _repository.Add(pacient2);

            List<Pacient> pacienti = _repository.GetAllPacients();
            int count = pacienti.Count();
            int result = 2;

            Assert.Equal(count, result);

            _repository.Clean();
        }

        [Fact]
        public void editByIdTest()
        {
            Pacient pacient = Pacient.PacientBuild()
                .setId(1)
                .setNume("numepacient")
                .setParola("parolapacient")
                .setDob(new DateTime(2022, 4, 21));
            Pacient pacient2 = Pacient.PacientBuild()
                .setId(2)
                .setNume("numepacient2")
                .setParola("parolapacient2")
                .setDob(new DateTime(2013, 2, 7));

            _repository.Add(pacient);

            int id = _repository.GetLastId();

            pacient.setId(id);
            pacient2.setId(id);

            _repository.EditById(id, pacient2);

            Pacient result = _repository.GetById(id);

            Assert.Equal(pacient2, result);

            _repository.Clean();
        }

    }
}
