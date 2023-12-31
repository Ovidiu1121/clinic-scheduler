﻿using ClinicScheduler.data;
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
        private DataAccess dataAccess;
        private string connectionString;

        public ProgramareRepository()
        {
            this.dataAccess = new DataAccess();
            this.connectionString=GetConnection();
        }
        public ProgramareRepository(string connectionString)
        {
            this.dataAccess = new DataAccess();
            this.connectionString =connectionString;
        }

        public void Add(Programare programare)
        {
            string sql = "insert into programare(pacient_id, doctor_id, serviciu_id, data_inceput, data_sfarsit) values(@pacientId,@doctorId,@serviciuId,@dataInceput,@dataSfarsit)";

            this.dataAccess.SaveData(sql, new {programare.PacientId,programare.DoctorId,programare.ServiciuId,
                programare.DataInceput,programare.DataSfarsit}, connectionString);
        }
        public void EditById(int id, Programare programare)
        {
            string sql = "update user set pacient_id=@PacientId,doctor_id=@DoctorId,serviciu_id=@ServiciuId,data_inceput=@DataInceput,data_sfarsit=@DataSfarsit where id=@id";

            this.dataAccess.SaveData(sql, new { programare.PacientId, programare.DoctorId, programare.ServiciuId,programare.DataInceput, programare.DataSfarsit, id }, connectionString);
        }
        public List<Programare> GetAllProgramari()
        {
            string sql = "select * from programare";

            return dataAccess.LoadData<Programare, dynamic>(sql,new { }, connectionString);
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
        public int GetLastId()
        {
            string sql = "SELECT LAST_INSERT_ID()";

            return dataAccess.LoadData<int, dynamic>(sql, new { }, connectionString)[0];
        }
        public void Clean()
        {
            string sql = "delete from programare where id>=0";

            this.dataAccess.LoadData<Programare, dynamic>(sql, new { }, connectionString);
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
