using ClinicScheduler.data;
using ClinicScheduler.serviciu.model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.serviciu.repository
{
    public class ServiciuRepository : IServiciuRepository
    {
        private List<Serviciu> servicii;
        private string connectionString;
        private DataAccess dataAccess;

        //Constructors

        public ServiciuRepository()
        {
            this.dataAccess = new DataAccess();
            this.connectionString =GetConnection();

            this.servicii = new List<Serviciu>();
            load();
        }

        public ServiciuRepository(string connectionString)
        {
            this.dataAccess = new DataAccess();
            this.connectionString =connectionString;
        }

        //Methods

        public void load()
        {
            List<Serviciu> lista = GetAllServicii();

            foreach (Serviciu serviciu in lista)
            {
                this.servicii.Add(serviciu);
            }
        }

        public void Add(Serviciu serviciu)
        {
            string sql = "insert into serviciu(nume,pret) values(@nume,@pret)";

            this.dataAccess.SaveData(sql, new { serviciu.Nume,serviciu.Pret }, connectionString);
        }
        public void EditById(int id, Serviciu serviciu)
        {
            string sql = "update serviciu set nume=@nume,pret=@pret where id=@id";

            this.dataAccess.SaveData(sql, new { serviciu.Nume,serviciu.Pret, id }, connectionString);
        }
        public List<Serviciu> GetAllServicii()
        {
            string sql = "select * from serviciu";

            return dataAccess.LoadData<Serviciu, dynamic>(sql, new { }, connectionString);
        }
        public Serviciu GetById(int id)
        {
            string sql = "select * from serviciu where id=@id";

            return this.dataAccess.LoadData<Serviciu, dynamic>(sql, new { id }, connectionString)[0];
        }
        public Serviciu GetByNume(string nume)
        {
            string sql = "select * from serviciu where nume=@nume";

            return this.dataAccess.LoadData<Serviciu, dynamic>(sql, new { nume }, connectionString)[0];
        }
        public void Remove(int id)
        {
            string sql = "delete from serviciu where id=@id";

            this.dataAccess.SaveData(sql, new { id }, connectionString);
        }
        public int GetLastId()
        {
            string sql = "SELECT LAST_INSERT_ID()";

            return dataAccess.LoadData<int, dynamic>(sql, new { }, connectionString)[0];
        }
        public void Clean()
        {
            string sql = "delete from serviciu where id>=0";

            this.dataAccess.LoadData<Serviciu, dynamic>(sql, new { }, connectionString);
        }

        public string GetConnection()
        {
            string c = Directory.GetCurrentDirectory();
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(c).AddJsonFile("appsettings.json").Build();
            string connectionStringIs = configuration.GetConnectionString("Default");
            return connectionStringIs;
        }

    }
}
