using ClinicScheduler.data;
using ClinicScheduler.doctor.model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.doctor.repository
{
    public class DoctorRepository:IDoctorRepository
    {
        private List<Doctor> doctors;
        private string connectionString;
        private DataAccess dataAccess;

        //Constructors

        public DoctorRepository()
        {
            this.dataAccess = new DataAccess();
            this.connectionString =GetConnection();

            this.doctors = new List<Doctor>();
            load();
        }

        //Methods

        public void load()
        {
            List<Doctor> lst = GetAllDoctors();

            foreach (Doctor doctor in lst)
            {
                this.doctors.Add(doctor);
            }
        }

        public void Add(Doctor doctor)
        {
            string sql = "insert into doctor(nume,parola,telefon,nume_clinica) values(@nume,@parola,@telefon,@nume_clinica)";

            this.dataAccess.SaveData(sql, new { doctor.Nume, doctor.Parola, doctor.Telefon, doctor.Nume_clinica }, connectionString);

        }

        public void EditById(int id, Doctor doctor)
        {
            string sql = "update doctor set nume=@nume,parola=@parola,telefon=@telefon,nume_clinica=@nume_clinica where id=@id";

            this.dataAccess.SaveData(sql, new { doctor.Nume, doctor.Parola, doctor.Telefon,doctor.Nume_clinica, id }, connectionString);
        }

        public void Remove(int id)
        {
            string sql = "delete from doctor where id=@id";

            this.dataAccess.SaveData(sql, new { id }, connectionString);
        }

        public Doctor GetById(int id)
        {
            string sql = "select * from doctor where id=@id";

            return this.dataAccess.LoadData<Doctor, dynamic>(sql, new { id }, connectionString)[0];
        }

        public Doctor GetByNume(string nume)
        {
            string sql = "select * from doctor where nume=@nume";

            return this.dataAccess.LoadData<Doctor, dynamic>(sql, new { nume }, connectionString)[0];
        }

        public List<Doctor> GetAllDoctors()
        {
            string sql = "select * from doctor";

            return dataAccess.LoadData<Doctor, dynamic>(sql, new { }, connectionString);
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
