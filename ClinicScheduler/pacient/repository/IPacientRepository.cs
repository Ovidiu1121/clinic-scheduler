using ClinicScheduler.pacient.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.pacient.repository
{
    public interface IPacientRepository
    {
        void Add(Pacient pacient);
        void EditById(int id, Pacient pacient);
        void Remove(int id);
        Pacient GetById(int id);
        Pacient GetByNume(string nume);
        List<Pacient> GetAllPacients();

    }
}
