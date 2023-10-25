using ClinicScheduler.serviciu.model;
using ClinicScheduler.serviciu.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace tests
{
    public class ServiciuCommandServiceTest
    {
        private IServiciuRepository _repository = new ServiciuRepository(TestConnectionString.GetConnection("Test"));

        [Fact]
        public void addTest()
        {
            Serviciu serviciu = Serviciu.ServiciuBuild()
                .setId(1)
                .setNume("nume1")
                .setPret(200);

            _repository.Add(serviciu);

            int id = _repository.GetLastId();

            serviciu.setId(id);

            Serviciu result = _repository.GetById(id);

            Assert.Equal(serviciu, result);

            _repository.Clean();
        }

        [Fact]
        public void removeTest()
        {
            Serviciu serviciu = Serviciu.ServiciuBuild()
                .setId(1)
                .setNume("nume2")
                .setPret(300);

            _repository.Add(serviciu);

            int id = _repository.GetLastId();

            _repository.Remove(id);

            Assert.Empty(_repository.GetAllServicii());

            _repository.Clean();
        }

        [Fact]
        public void getAllServiciiTest()
        {
            Serviciu serviciu = Serviciu.ServiciuBuild()
                 .setId(1)
                 .setNume("nume4")
                 .setPret(140);
            Serviciu serviciu2 = Serviciu.ServiciuBuild()
                .setId(1)
                .setNume("nume5")
                .setPret(340);

            _repository.Add(serviciu);
            _repository.Add(serviciu2);

            List<Serviciu> servicii = _repository.GetAllServicii();
            int count = servicii.Count();
            int result = 2;

            Assert.Equal(count, result);

            _repository.Clean();
        }

        [Fact]
        public void editByIdTest()
        {
            Serviciu serviciu = Serviciu.ServiciuBuild()
                 .setId(1)
                 .setNume("nume4")
                 .setPret(140);
            Serviciu serviciu2 = Serviciu.ServiciuBuild()
                .setId(1)
                .setNume("nume5")
                .setPret(340);

            _repository.Add(serviciu);

            int id = _repository.GetLastId();

            serviciu.setId(id);
            serviciu2.setId(id);

            _repository.EditById(id, serviciu2);

            Serviciu result = _repository.GetById(id);

            Assert.Equal(serviciu2, result);

            _repository.Clean();
        }
    }
}
