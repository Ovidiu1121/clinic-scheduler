using ClinicScheduler.serviciu.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.serviciu.service.interfaces
{
    public interface IServiciuQueryService
    {
        Serviciu GetById(int id);
        Serviciu GetByNume(string nume);
    }
}
