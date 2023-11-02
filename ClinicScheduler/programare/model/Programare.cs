using ClinicScheduler.doctor.model;
using ClinicScheduler.pacient.model;
using ClinicScheduler.serviciu.model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.programare.model
{
    [Table("programare")]
    public class Programare:IProgramareBuilder,IComparable<Programare>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PacientId { get; set; }
        public int DoctorId { get; set; }
        public int ServiciuId { get; set; }
        public DateTime DataInceput { get; set; }
        public DateTime DataSfarsit { get; set; }

        [ForeignKey("PacientId")]
        public virtual Pacient Pacient { get; set; }

        [ForeignKey("DoctorId")]
        public virtual Doctor Doctor { get; set; }

        [ForeignKey("ServiciuId")]
        public virtual Serviciu Serviciu { get; set; }

        //IComparable

        public int CompareTo(Programare other)
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
            return "id:"+this.Id.ToString()+", id doctor:"+this.DoctorId+", id pacient:"+this.PacientId+
                ", serviciu id:"+this.ServiciuId+", data inceput:"+this.DataInceput+", data sfarsit:"+this.DataSfarsit;
        }
        public override bool Equals(object obj)
        {
            Programare programare= obj as Programare;

            return programare.Id.Equals(this.Id)&&
                programare.PacientId.Equals(this.PacientId)&&
                programare.DoctorId.Equals(this.DoctorId)&&
                programare.ServiciuId.Equals(this.ServiciuId)&&
                programare.DataInceput.Equals(this.DataInceput)&&
                programare.DataSfarsit.Equals(this.DataSfarsit);
        }

        //IBuilder

        public Programare setId(int id)
        {
            this.Id = id;
            return this;
        }
        public Programare setPacientId(int pacientId)
        {
            this.PacientId = pacientId;
            return this;
        }
        public Programare setDoctorId(int doctorId)
        {
            this.DoctorId = doctorId;
            return this;
        }
        public Programare setServiciuId(int serviciuId)
        {
           this.ServiciuId = serviciuId;
            return this;
        }
        public Programare setDataInceput(DateTime dataInceput)
        {
          this.DataInceput = dataInceput;
            return this;
        }
        public Programare setDataSfarsit(DateTime dataSfarsit)
        {
            this.DataSfarsit= dataSfarsit;
            return this;
        }

        public static Programare ProgramareBuild()
        {
            return new Programare();
        }

    }
}
