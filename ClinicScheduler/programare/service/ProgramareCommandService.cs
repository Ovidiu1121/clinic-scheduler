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
    public class ProgramareCommandService : IProgramareCommandService
    {
        private IProgramareRepository repo;

        public ProgramareCommandService()
        {
            this.repo=new ProgramareRepository();
        }

        public void Add(Programare programare)
        {
            List<Programare> programari = this.repo.GetAllProgramari();

            foreach (Programare p in programari)
            {
                if (p.Equals(programare))
                {
                    throw new ItemDejaExistentException(Constants.ITEM_DEJA_EXISTENT_EXCEPTION);
                }
            }

            this.repo.Add(programare);
        }

        public void EditById(int id, Programare programare)
        {
            this.repo.EditById(id, programare);
        }

        public void Remove(int id)
        {
            List<Programare> programari = this.repo.GetAllProgramari();
            bool flag = false;
            Programare programare = repo.GetById(id);

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

            this.repo.Remove(id);
        }
    }
}
