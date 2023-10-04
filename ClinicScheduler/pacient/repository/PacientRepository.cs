using ClinicScheduler.data;
using ClinicScheduler.pacient.model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.pacient.repository
{
    public class PacientRepository : IPacientRepository
    {
        private List<Pacient> pacients;
        private string connectionString;
        private DataAccess dataAccess;

        //Constructors

        public PacientRepository()
        {
            this.dataAccess = new DataAccess();
            this.connectionString =GetConnection();

            this.pacients = new List<Pacient>();
            load();
      
        }

        //Methods

        public void load()
        {
            List<Pacient> lista = GetAllPacients();

            foreach (Pacient pacient in lista)
            {
                this.pacients.Add(pacient);
            }
        }
        public void Add(Pacient user)
        {
            string sql = "insert into pacient(nume,parola,dob) values(@nume,@parola,@dob)";

            this.dataAccess.SaveData(sql, new { user.Nume, user.Parola, user.Dob }, connectionString);
        }
        public void EditById(int id, Pacient pacient)
        {
            string sql = "update pacient set nume=@nume,parola=@parola,dob=@dob where id=@id ";

            this.dataAccess.SaveData(sql, new { pacient.Nume, pacient.Parola, pacient.Dob, pacient.Id }, connectionString);
        }
        public List<Pacient> GetAllPacients()
        {
            string sql = "select * from pacient";

            return dataAccess.LoadData<Pacient, dynamic>(sql, new { }, connectionString);
        }
        public Pacient GetById(int id)
        {
            string sql = "select * from pacient where id=@id";

            return this.dataAccess.LoadData<Pacient, dynamic>(sql, new { id }, connectionString)[0];
        }
        public Pacient GetByNume(string nume)
        {
            string sql = "select * from pacient where nume=@nume";

            return this.dataAccess.LoadData<Pacient, dynamic>(sql, new { nume }, connectionString)[0];
        }
        public void Remove(int id)
        {
            string sql = "delete from pacient where id=@id";

            this.dataAccess.SaveData(sql, new { id }, connectionString);
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
