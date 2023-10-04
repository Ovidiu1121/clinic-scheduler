using ClinicScheduler.pacient.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.pacient.service.interfaces
{
    public interface IPacientQueryService
    {
        Pacient GetById(int id);
        Pacient GetByNume(string nume);
    }
}
