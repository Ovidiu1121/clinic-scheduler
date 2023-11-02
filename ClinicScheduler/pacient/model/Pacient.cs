using ClinicScheduler.programare.model;
using ClinicScheduler.user.model;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.pacient.model
{
    [Table("pacient")]
    public class Pacient: IComparable<Pacient>,IPacientBuilder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Parola { get; set; }
        public DateTime Dob { get; set; }
        public List<Programare> programari { get; set; }    

        //IComparable

        public int CompareTo(Pacient other)
        {
            if (this.Id > other.Id)
            {
                return 1;
            }
            else if (this.Id == other.Id)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
        public override string ToString()
        {
            return  "id:"+this.Id+ "\nnume:"+this.Nume+"\nparola:"+this.Parola+"\ndob:"+this.Dob;
        }
        public override bool Equals(object obj)
        {
            Pacient pacient = obj as Pacient;

            return pacient.Id.Equals(this.Id) &&
                pacient.Nume.Equals(this.Nume) &&
                pacient.Parola.Equals(this.Parola) &&
                pacient.Dob.Equals(this.Dob);
        }

        //IBuilder

        public Pacient setId(int id)
        {
            this.Id = id;
            return this;
        }
        public Pacient setNume(string nume)
        {
            this.Nume = nume;
            return this;
        }
        public Pacient setParola(string parola)
        {
            this.Parola = parola;
            return this;
        }
        public Pacient setDob(DateTime dob)
        {
            this.Dob = dob;
            return this;
        }

        public static Pacient PacientBuild()
        {
            return new Pacient();
        }

        //Methods

        public void getProgramari()
        {
            string connectionString = GetConnection();

            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();

                string query = @" SELECT 
                programare.id,pacient_id,doctor_id,serviciu_id,data_inceput,data_inceput from pacient
                left join programare on pacient.id = @programare.pacient_id";

                var pacientDictionary = new Dictionary<int, Pacient>();

                var pacients = dbConnection.Query<Pacient, Programare, Pacient>(
                query,
                (pacient, programare) =>
                {
                    if (!pacientDictionary.TryGetValue(pacient.Id, out var currentPacient))
                    {
                        currentPacient=pacient;
                        currentPacient.programari=new List<Programare>();
                        pacientDictionary.Add(currentPacient.Id, currentPacient);
                    }
                    currentPacient.programari.Add(programare);
                    return currentPacient;
                },
                 splitOn: "ProgramareId"
                );
            };
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
