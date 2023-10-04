using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.serviciu.model
{
    public class Serviciu:IServiciuBuilder,IComparable<Serviciu>
    {

        private int id;
        private string nume;
        private int pret;

        //Constructors

        public Serviciu()
        {

        }
        public Serviciu(int id,string nume,int pret)
        {
            this.id = id;
            this.nume = nume;
            this.pret = pret;
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
        public int Pret
        {
            get { return this.pret; }
            set { this.pret = value; }
        }

        //IComparable

        public int CompareTo(Serviciu other)
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
           Serviciu serviciu=obj as Serviciu;   

            return serviciu.id.Equals(this.id)&&
                serviciu.nume.Equals(this.nume)&&
                serviciu.pret.Equals(this.pret);
        }

        //IBuilder

        public Serviciu setId(int id)
        {
           this.id=id;
            return this;
        }
        public Serviciu setNume(string nume)
        {
            this.nume=nume;
            return this;
        }
        public Serviciu setPret(int pret)
        {
            this.pret=pret;
            return this;
        }
    }
}
