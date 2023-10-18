using ClinicScheduler.user.model;
using ClinicScheduler.user.repository;
using ClinicScheduler.user.service;
using ClinicScheduler.user.service.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace tests
{
    public class UserQueryServiceTest
    {
        [Fact]
        public void getById()
        {
            List<User> users = new List<User>();
            User user1 = new User(1, "Alex", "parola1", 1);
            User user2 = new User(3, "Dan", "parola2", 0);
            User user3 = new User(3, "Mihai", "parola3", 1);

            users.Add(user1);
            users.Add(user2);
            users.Add(user3);

            UserRepository repo=new UserRepository();

            repo.users = users;

            User result = repo.GetById(1);
            User expected = new User(1, "Alex", "parola1", 1);

            Assert.Equal(expected,result);   

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
