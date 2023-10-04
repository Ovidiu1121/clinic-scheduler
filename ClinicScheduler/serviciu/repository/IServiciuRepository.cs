using ClinicScheduler.serviciu.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.serviciu.repository
{
    public interface IServiciuRepository
    {
        void Add(Serviciu serviciu);
        void EditById(int id, Serviciu serviciu);
        void Remove(int id);
        Serviciu GetById(int id);
        Serviciu GetByNume(string nume);
        List<Serviciu> GetAllServicii();
    }
}
