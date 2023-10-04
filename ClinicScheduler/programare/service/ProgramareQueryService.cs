using ClinicScheduler.exceptii;
using ClinicScheduler.programare.model;
using ClinicScheduler.programare.repository;
using ClinicScheduler.programare.service.interfaces;
using ClinicScheduler.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.programare.service
{
    public class ProgramareQueryService : IProgramareQueryService
    {
        private IProgramareRepository repo;

        public ProgramareQueryService()
        {
            this.repo = new ProgramareRepository();
        }

        public Programare GetById(int id)
        {
            List<Programare> programari = this.repo.GetAllProgramari();
            bool flag = false;
            Programare programare = this.repo.GetById(id);

            foreach (Programare p in programari)
            {
                if (p.Equals(programare))
                {
                    flag=true;
                }
            }

            if (flag.Equals(false))
            {
                throw new ItemInexistentException(Constants.ITEM_INEXISTENT_EXCEPTION);
            }

            return programare;
        }


    }
}
