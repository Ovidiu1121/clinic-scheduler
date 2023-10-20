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
        public void getById()
        {
            User user = User.UserBuild()
                .setId(1)
                .setTip(0)
                .setNume("aaaa")
                .setParola("bbbb");
           
            
            // Act
            _repository.Add(user);

            // Assert
          

            // Cleaning up
      

        }

        [Fact]
        public void getByName()
        {

            IUserQueryService service = new UserQueryService();

            User user = service.GetByNume("Dan");
            User expected = new User(3, "Dan", "parola3", 0);

            Assert.Equal(expected, user);

        }



    }
}
