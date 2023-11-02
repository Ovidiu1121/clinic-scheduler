using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.serviciu.model
{
    [Table("serviciu")]
    public class Serviciu:IServiciuBuilder,IComparable<Serviciu>
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nume { get; set; }
        public int Pret { get; set; }

        //IComparable

        public int CompareTo(Serviciu other)
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
            return "id:"+this.Id+",nume:"+this.Nume+",pret:"+this.Pret+"\n";
        }
        public override bool Equals(object obj)
        {
           Serviciu serviciu=obj as Serviciu;   

            return serviciu.Id.Equals(this.Id)&&
                serviciu.Nume.Equals(this.Nume)&&
                serviciu.Pret.Equals(this.Pret);
        }

        //IBuilder

        public Serviciu setId(int id)
        {
           this.Id=id;
            return this;
        }
        public Serviciu setNume(string nume)
        {
            this.Nume=nume;
            return this;
        }
        public Serviciu setPret(int pret)
        {
            this.Pret=pret;
            return this;
        }

        public static Serviciu ServiciuBuild()
        {
            return new Serviciu();
        }
    }
}
