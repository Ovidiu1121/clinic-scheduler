using ClinicScheduler.programare.model;
using ClinicScheduler.user.model;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
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
    public class Doctor:User,IComparable<Doctor>,IDoctorBuilder
    {
        private int id;
        private string nume;
        private string parola;
        private int telefon;
        private string nume_clinica;
        private List<Programare> programari;

        //Constructors

        public Doctor() 
        {
        }
        public Doctor(int id,string nume,string parola,int telefon,string nume_clinica)
        {
            this.id = id;
            this.nume = nume;
            this.parola = parola;
            this.telefon = telefon;
            this.nume_clinica = nume_clinica;
        }

        //Accessors

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Nume
        {
            get { return this.nume; }
            set { this.nume = value; }
        }
        public string Parola
        {
            get { return this.parola; }
            set { this.parola = value; }
        }
        public int Telefon
        {
            get { return this.telefon; }
            set { this.telefon = value;}
        }
        public string Nume_clinica
        {
            get { return this.nume_clinica; }
            set { this.nume_clinica = value;}
        }
        public List<Programare> Programari
        {
            get { return this.programari; }
            set { this.programari = value; }
        }

        //IComparable

        public int CompareTo(Doctor other)
        {
            if (this.id > other.id)
            {
                return 1;
            }
            else if (this.id == other.id)
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
            return this.nume;
        }
        public override bool Equals(object obj)
        {
            Doctor doctor = obj as Doctor;

            return doctor.id.Equals(this.id) &&
                doctor.nume.Equals(this.nume) &&
                doctor.parola.Equals(this.parola) &&
                doctor.telefon.Equals(this.telefon) &&
                doctor.nume_clinica.Equals(this.nume_clinica);
        }

        //IBuilder

        public Doctor setId(int id)
        {
            this.id = id;
            return this;
        }
        public Doctor setNume(string nume)
        {
            this.nume = nume;
            return this;
        }
        public Doctor setParola(string parola)
        {
            this.parola = parola;
            return this;
        }
        public Doctor setTelefon(int telefon)
        {
           this.telefon = telefon;
            return this;
        }
        public Doctor setNumeClinica(string nume_clinica)
        {
           this.nume_clinica = nume_clinica;
            return this;
        }
        public Doctor setProgramari(List<Programare> programari)
        {
           this.programari = programari;
            return this;
        }



    }
}
