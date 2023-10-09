using ClinicScheduler.exceptii;
using ClinicScheduler.user.model;
using ClinicScheduler.user.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace Test
{
    public class TestUserCommandService
    {
        

        [Fact]
        public void TestAdd()
        {
            IUserRepository repo = new UserRepository();

            User user = new User()
                .setNume("Bob")
                .setParola("parolaX")
                .setTip(1);

            repo.Add(user);

            Assert.Contains(user, repo.GetAllUsers());
            
        }

    }
}
