using ClinicScheduler.serviciu.model;
using ClinicScheduler.serviciu.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace tests.serviciu
{
    public class ServiciuQueryServiceTest
    {
        private IServiciuRepository _repository = new ServiciuRepository(TestConnectionString.GetConnection("Test"));

        [Fact]
        public void getByIdTest()
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
        public void getByNameTest()
        {
            Serviciu serviciu = Serviciu.ServiciuBuild()
                .setId(1)
                .setNume("nume1")
                .setPret(200);

            _repository.Add(serviciu);

            int id = _repository.GetLastId();

            serviciu.setId(id);

            Serviciu result = _repository.GetByNume("nume1");

            Assert.Equal(serviciu, result);

            _repository.Clean();
        }


    }
}
