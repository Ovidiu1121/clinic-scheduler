using ClinicScheduler.user.model;
using ClinicScheduler.user.repository;
using ClinicScheduler.user.service;
using ClinicScheduler.user.service.interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace tests
{
    public class UserQueryServiceTest
    {
        private IUserRepository _repository = new UserRepository(TestConnectionString.GetConnection("Test"));

        [Fact]
        public void getByIdTest()
        {
            User user = User.UserBuild()
                .setId(1)
                .setTip(0)
                .setNume("nume1")
                .setParola("parola1");

            _repository.Add(user);

            int id = _repository.GetLastId();
            user.setId(id);

            User result=_repository.GetById(id);

            Assert.Equal(user, result);

            _repository.Clean();
        }

        [Fact]
        public void getByNameTest()
        {
            User user = User.UserBuild()
                .setId(2)
                .setNume("nume2")
                .setParola("parola2")
                .setTip(0);

            _repository.Add(user);

            int id= _repository.GetLastId();

            user.setId(id);

            User result = _repository.GetByNume("nume2");

            Assert.Equal(user, result);

            _repository.Clean();
        }



    }
}
