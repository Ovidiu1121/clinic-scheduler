using ClinicScheduler.programare.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.programare.service.interfaces
{
    public interface IProgramareQueryService
    {
        Programare GetById(int id);
        List<Programare> GetAllProgramari();
    }
}
