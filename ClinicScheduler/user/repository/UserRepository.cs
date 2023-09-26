using ClinicScheduler.data;
using ClinicScheduler.user.model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.user.repository
{
    public class UserRepository : IUserRepository
    {
        private List<User> users;
        private string connectionString;
        private DataAccess dataAccess;

        //Constructors

        public UserRepository()
        {
            this.dataAccess = new DataAccess();
            this.connectionString =GetConnection();

            users = new List<User>();
            load();
        }

        //Methods

        public void load()
        {
            List<User> lst = getAllUsers();

            foreach (User user in lst)
            {
                users.Add(user);
            }
        }
        public void addUser(User user)
        {
            string sql = "insert into user(nume,parola,tip) values(@nume,@parola,@tip)";

            this.dataAccess.SaveData(sql, new { user.Nume, user.Parola, user.Tip}, connectionString);
        }
        public void deleteUser(int id)
        {
            string sql = "delete from user where id=@id";

            this.dataAccess.SaveData(sql, new { id }, connectionString);
        }
        public List<User> getAllUsers()
        {
            string sql = "select * from user";

            return dataAccess.LoadData<User, dynamic>(sql, new { }, connectionString);
        }
        public User getUserById(int id)
        {
            string sql = "select * from user where id=@id";

            return this.dataAccess.LoadData<User, dynamic>(sql, new { id }, connectionString)[0];
        }
        public void updateUser(User user)
        {
            string sql = "update user set nume=@nume,parola=@parola,tip=@tip";

            this.dataAccess.SaveData(sql, new { user.Nume,user.Parola,user.Tip }, connectionString);
        }

        //Database Connection

        public string GetConnection()
        {
            string c = Directory.GetCurrentDirectory();
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(c).AddJsonFile("appsettings.json").Build();
            string connectionStringIs = configuration.GetConnectionString("Default");
            return connectionStringIs;
        }

    }
}
