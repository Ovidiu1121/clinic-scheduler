using ClinicScheduler.user.model;
using ClinicScheduler.user.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace tests
{
    public class UserCommandServiceTest
    {
        private IUserRepository _repository = new UserRepository(TestConnectionString.GetConnection("Test"));

        [Fact]
        public void addTest()
        {
            User user = User.UserBuild()
                .setId(1)
                .setNume("nume1")
                .setParola("parola1")
                .setTip(1);

            _repository.Add(user);

            int id = _repository.GetLastId();

            user.setId(id);

            User result=_repository.GetById(id);

            Assert.Equal(user, result);

            _repository.Clean();
        }

        [Fact]
        public void removeTest()
        {
            User user = User.UserBuild()
                .setId(1)
                .setNume("nume2")
                .setParola("parola2")
                .setTip(1);

            _repository.Add(user);

            int id=_repository.GetLastId();

            _repository.Remove(id);

            Assert.Empty(_repository.GetAllUsers());

            _repository.Clean();
        }

        [Fact]
        public void getAllUsersTest()
        {
            User user = User.UserBuild()
                .setId(3)
                .setNume("nume3")
                .setParola("parola3")
                .setTip(1);
            User user2 = User.UserBuild()
                .setId(4)
                .setNume("nume4")
                .setParola("parola4")
                .setTip(1);

            _repository.Add(user);
            _repository.Add(user2);

            List<User> users = _repository.GetAllUsers();
            int count = users.Count();
            int result = 2;

            Assert.Equal(count, result);

            _repository.Clean();
        }

        [Fact]
        public void editByIdTest()
        {
            User user = User.UserBuild()
                .setId(1)
                .setNume("nume1")
                .setParola("parola1")
                .setTip(1);
            User user2 = User.UserBuild()
                .setId(2)
                .setNume("nume2")
                .setParola("parola2")
                .setTip(1);

            _repository.Add(user);

            int id = _repository.GetLastId();

            user.setId(id);
            user2.setId(id);

            _repository.EditById(id, user2);

            User result = _repository.GetById(id);

            Assert.Equal(user2, result);

            _repository.Clean();
        }

    }
}
