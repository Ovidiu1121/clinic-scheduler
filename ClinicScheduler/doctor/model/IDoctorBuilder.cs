using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.doctor.model
{
    public interface IDoctorBuilder
    {
        Doctor setId(int id);
        Doctor setNume(string nume);
        Doctor setParola(string parola);
        Doctor setTelefon(int telefon);
        Doctor setIdClinica(int id_clinica);

    }
}
