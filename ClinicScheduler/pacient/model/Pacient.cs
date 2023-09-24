using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.pacient.model
{
    public class Pacient:IComparable<Pacient>,IPacientBuilder
    {
        private int id;
        private string nume;
        private string parola;
        private DateTime dob;

        //Constructors

        public Pacient()
        {

        }
        public Pacient(int id, string nume, string parola, DateTime dob)
        {
            this.id = id;
            this.nume = nume;
            this.parola = parola;
            this.dob = dob;
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
        public DateTime Dob
        {
            get { return this.dob; }
            set { this.dob = value; }
        }

        //IComparable

        public int CompareTo(Pacient other)
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
            Pacient pacient = obj as Pacient;

            return pacient.id.Equals(this.id) &&
                pacient.nume.Equals(this.nume) &&
                pacient.parola.Equals(this.parola) &&
                pacient.dob.Equals(this.dob);
        }

        //IBuilder

        public Pacient setId(int id)
        {
            this.id = id;
            return this;
        }
        public Pacient setNume(string nume)
        {
            this.nume = nume;
            return this;
        }
        public Pacient setParola(string parola)
        {
            this.parola = parola;
            return this;
        }
        public Pacient setDob(DateTime dob)
        {
            this.dob = dob;
            return this;
        }

    }
}
