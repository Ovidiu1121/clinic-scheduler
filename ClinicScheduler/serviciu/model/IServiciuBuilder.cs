using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.serviciu.model
{
    public interface IServiciuBuilder
    {
        Serviciu setId(int id);
        Serviciu setNume(string nume);
        Serviciu setPret(int pret);

    }
}
