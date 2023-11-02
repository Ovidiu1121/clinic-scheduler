using ClinicScheduler.serviciu.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.serviciu.service.interfaces
{
    public interface IServiciuCommandService
    {
        void Add(Serviciu serviciu);
        void Remove(int id);
        void EditById(int id, Serviciu serviciu);
    }
}
