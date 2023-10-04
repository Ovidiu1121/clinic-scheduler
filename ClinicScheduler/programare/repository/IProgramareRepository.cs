using ClinicScheduler.programare.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.programare.repository
{
    public interface IProgramareRepository
    {
        void Add(Programare programare);
        void EditById(int id, Programare programare);
        void Remove(int id);
        Programare GetById(int id);
        List<Programare> GetAllProgramari();
    }
}
