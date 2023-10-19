using ClinicScheduler.data;
using ClinicScheduler.programare.model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.programare.repository
{
    public class ProgramareRepository : IProgramareRepository
    {
        private List<Programare> programari;
        private DataAccess dataAccess;
        private string connectionString;
        public ProgramareRepository()
        {
            this.dataAccess = new DataAccess();
            this.connectionString=GetConnection();
            this.programari = new List<Programare>();

            load();
        }

        public void load()
        {
            List<Programare> lista = GetAllProgramari();

            foreach (Programare pro in lista)
            {
                this.programari.Add(pro);
            }
        }
        public void Add(Programare programare)
        {
            string sql = "insert into programare(pacient_id,doctor_id,serviciu_id,data_inceput,data_sfarsit) values(@pacient_id,@doctor_id,@serviciu_id,@data_inceput,@data-sfarsit))";

            this.dataAccess.SaveData(sql, new {programare.PacientId,programare.DoctorId,programare.ServiciuId,
                programare.DataInceput,programare.DataSfarsit}, connectionString);
        }
        public void EditById(int id, Programare programare)
        {
            string sql = "update user set pacient_id=@pacient_id,doctor_id=@doctor_id,serviciu_id=@serviciu_id,data_inceput=@data_inceput,data_sfarsit=@data_sfarsit where id=@id";

            this.dataAccess.SaveData(sql, new {
                programare.PacientId,
                programare.DoctorId,
                programare.ServiciuId,
                programare.DataInceput,
                programare.DataSfarsit, id }, connectionString);
        }
        public List<Programare> GetAllProgramari()
        {
            string sql = "select * from programare";

            return dataAccess.LoadData<Programare, dynamic>(sql, new { }, connectionString);
        }
        public Programare GetById(int id)
        {
            string sql = "select * from programare where id=@id";

            return this.dataAccess.LoadData<Programare, dynamic>(sql, new { id }, connectionString)[0];
        }
        public void Remove(int id)
        {
            string sql = "delete from programare where id=@id";

            this.dataAccess.SaveData(sql, new { id }, connectionString);
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
