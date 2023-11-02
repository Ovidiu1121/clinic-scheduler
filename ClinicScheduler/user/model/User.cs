using ClinicScheduler.user.model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.user.model
{
    [Table("user")]
    public class User:IComparable<User>,IUserBuilder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Parola { get; set; }
        public int Tip { get; set; }

        //IComparable

        public int CompareTo(User other)
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
            return this.Id+","+this.Nume+","+this.Parola+","+this.Tip;
        }
        public override bool Equals(object obj)
        {
            User user = obj as User;

            return user.Nume.Equals(this.Nume) && user.Parola.Equals(this.Parola) && user.Tip.Equals(this.Tip);
        }

        //IBuilder

        public User setId(int id)
        {
            this.Id = id;
            return this;
        }
        public User setNume(string nume)
        {
           this.Nume = nume;
            return this;
        }
        public User setParola(string parola)
        {
           this.Parola = parola;
            return this;
        }
        public User setTip(int tip)
        {
            this.Tip = tip;
            return this;
        }


        public static User UserBuild()
        {
            return new User();
        }


    }
}
