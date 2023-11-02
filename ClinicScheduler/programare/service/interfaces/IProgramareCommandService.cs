using ClinicScheduler.programare.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.programare.service.interfaces
{
    public interface IProgramareCommandService
    {
        void Add(Programare programare);
        void Remove(int id);
        void EditById(int id, Programare programare);
    }
}
