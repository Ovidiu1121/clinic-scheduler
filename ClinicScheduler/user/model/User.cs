using ClinicScheduler.user.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.user.model
{
    public class User:IComparable<User>,IUserBuilder
    {
        private int id;
        private string nume;
        private string parola;
        private int tip;

        //Constructors

        public User()
        {

        }
        public User(int id,string nume,string parola,int tip)
        {
            this.id = id;
            this.nume = nume;
            this.parola = parola;
            this.tip = tip;
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
            set { this.parola = value;}
        }
        public int Tip
        {
            get { return this.tip; }
            set { this.tip = value; }
        }

        //IComparable

        public int CompareTo(User other)
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
            return this.id+","+this.nume+","+this.parola+","+this.tip;
        }
        public override bool Equals(object obj)
        {
            User user = obj as User;

            return user.nume.Equals(this.nume) && user.parola.Equals(this.parola) && user.tip.Equals(this.tip);
        }

        //IBuilder

        public User setId(int id)
        {
            this.id = id;
            return this;
        }
        public User setNume(string nume)
        {
           this.nume = nume;
            return this;
        }
        public User setParola(string parola)
        {
           this.parola = parola;
            return this;
        }
        public User setTip(int tip)
        {
            this.tip = tip;
            return this;
        }


        public static User UserBuild()
        {
            return new User();
        }


    }
}
