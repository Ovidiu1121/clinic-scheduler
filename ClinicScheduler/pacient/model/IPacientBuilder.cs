using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.pacient.model
{
    public interface IPacientBuilder
    {
        Pacient setId(int id);
        Pacient setNume(string nume);
        Pacient setParola(string parola);
        Pacient setDob(DateTime tip);

    }
}
