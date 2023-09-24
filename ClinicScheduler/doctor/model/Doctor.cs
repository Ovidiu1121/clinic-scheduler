using ClinicScheduler.user.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.doctor.model
{
    public class Doctor:IComparable<Doctor>,IDoctorBuilder
    {
        private int id;
        private string nume;
        private string parola;
        private int telefon;
        private int id_clinica;

        //Constructors

        public Doctor()
        {

        }
        public Doctor(int id,string nume,string parola,int telefon,int id_clinica)
        {
            this.id = id;
            this.nume = nume;
            this.parola = parola;
            this.telefon = telefon;
            this.id_clinica = id_clinica;
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
        public int ID_clinica
        {
            get { return this.id_clinica;}
            set { this.id_clinica = value;}
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
                doctor.id_clinica.Equals(this.id_clinica);
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
        public Doctor setIdClinica(int id_clinica)
        {
           this.id_clinica = id_clinica;
            return this;
        }
    }
}
