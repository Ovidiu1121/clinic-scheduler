using ClinicScheduler.programare.model;
using ClinicScheduler.user.model;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigurationBuilder = Microsoft.Extensions.Configuration.ConfigurationBuilder;

namespace ClinicScheduler.doctor.model
{
    [Table("doctor")]
    public class Doctor:IComparable<Doctor>,IDoctorBuilder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Parola { get; set; }
        public int Telefon { get; set; }
        public string NumeClinica { get; set; }
        public List<Programare> Programari { get; set; }

        //IComparable

        public int CompareTo(Doctor other)
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
            return "id:"+this.Id+",nume:"+this.Nume+",parola:"+this.Parola+",telefon:"+this.Telefon+",nume clinica:"+this.NumeClinica+"\n";
        }
        public override bool Equals(object obj)
        {
            Doctor doctor = obj as Doctor;

            return doctor.Id.Equals(this.Id) &&
                doctor.Nume.Equals(this.Nume) &&
                doctor.Parola.Equals(this.Parola) &&
                doctor.Telefon.Equals(this.Telefon) &&
                doctor.NumeClinica.Equals(this.NumeClinica);
        }

        //IBuilder

        public Doctor setId(int id)
        {
            this.Id = id;
            return this;
        }
        public Doctor setNume(string nume)
        {
            this.Nume = nume;
            return this;
        }
        public Doctor setParola(string parola)
        {
            this.Parola = parola;
            return this;
        }
        public Doctor setTelefon(int telefon)
        {
           this.Telefon = telefon;
            return this;
        }
        public Doctor setNumeClinica(string numeClinica)
        {
           this.NumeClinica = numeClinica;
            return this;
        }
        public Doctor setProgramari(List<Programare> programari)
        {
           this.Programari = programari;
            return this;
        }

        public static  Doctor DoctorBuild()
        {
            return new Doctor();
        }



    }
}
