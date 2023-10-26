using ClinicScheduler.doctor.model;
using ClinicScheduler.pacient.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.programare.model
{
    public interface IProgramareBuilder
    {
        Programare setId(int id);
        Programare setPacientId(int pacientId);
        Programare setDoctorId(int doctorId);
        Programare setServiciuId(int serviciuId);
        Programare setDataInceput(DateTime dataInceput);
        Programare setDataSfarsit(DateTime dataSfarsit);
    }
}
