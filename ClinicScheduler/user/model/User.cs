using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.user.model
{
    public class User
    {
        private int id;
        private string nume;
        private string parola;
        private int tip;

        public User(int id,string nume,string parola,int tip)
        {
            this.id = id;
            this.nume = nume;
            this.parola = parola;
            this.tip = tip;
        }



    }
}
