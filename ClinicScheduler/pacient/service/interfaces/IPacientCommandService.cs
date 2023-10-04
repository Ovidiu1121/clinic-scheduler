using ClinicScheduler.pacient.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.pacient.service.interfaces
{
    public interface IPacientCommandService
    {
        void Add(Pacient pacient);
        void Remove(int id);
        void EditById(int id, Pacient pacient);
        List<Pacient> GetAllPacients();
    }
}
