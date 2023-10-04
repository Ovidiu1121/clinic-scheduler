﻿using ClinicScheduler.doctor.model;
using ClinicScheduler.pacient.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.programare.model
{
    public class Programare:IProgramareBuilder,IComparable<Programare>
    {
        private int id;
        private Pacient pacientId;
        private Doctor doctorId;
        private int serviciuId;
        private DateTime dataInceput;
        private DateTime dataSfarsit;

        //Constructors

        public Programare()
        {

        }
        public Programare(int id, Pacient pacientId, Doctor doctorId, int serviciuId, DateTime dataInceput, DateTime dataSfarsit)
        {
            this.id = id;
            this.pacientId = pacientId;
            this.doctorId = doctorId;
            this.serviciuId = serviciuId;
            this.dataInceput = dataInceput;
            this.dataSfarsit = dataSfarsit;
        }

        //Accessors

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public Pacient PacientId
        {
            get { return this.pacientId; }
            set { this.pacientId = value;}
        }
        public Doctor DoctorId
        {
            get { return this.doctorId;}
            set { this.doctorId = value;}
        }
        public int ServiciuId
        {
            get { return this.serviciuId;}
            set { this.serviciuId = value;}
        }
        public DateTime DataInceput
        {
            get { return this.dataInceput;}
            set { this.dataInceput = value;}
        }
        public DateTime DataSfarsit
        {
            get { return this.dataSfarsit; }
            set { this.dataSfarsit = value; }
        }

        //IComparable

        public int CompareTo(Programare other)
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
            return "id:"+this.id.ToString()+"id doctor:"+this.doctorId+"id pacient:"+this.pacientId;
        }
        public override bool Equals(object obj)
        {
            Programare programare= obj as Programare;

            return programare.id.Equals(this.id)&&
                programare.pacientId.Equals(this.pacientId)&&
                programare.doctorId.Equals(this.doctorId)&&
                programare.serviciuId.Equals(this.serviciuId)&&
                programare.dataInceput.Equals(this.dataInceput)&&
                programare.dataSfarsit.Equals(this.dataSfarsit);
        }

        //IBuilder

        public Programare setId(int id)
        {
            this.id = id;
            return this;
        }
        public Programare setPacientId(Pacient pacientId)
        {
            this.pacientId = pacientId;
            return this;
        }
        public Programare setDoctorId(Doctor doctorId)
        {
            this.doctorId = doctorId;
            return this;
        }
        public Programare setServiciuId(int serviciuId)
        {
           this.serviciuId = serviciuId;
            return this;
        }
        public Programare setDataInceput(DateTime dataInceput)
        {
          this.dataInceput = dataInceput;
            return this;
        }
        public Programare setDataSfarsit(DateTime dataSfarsit)
        {
            this.dataSfarsit= dataSfarsit;
            return this;
        }


    }
}