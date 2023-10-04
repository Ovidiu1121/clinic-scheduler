using ClinicScheduler.exceptii;
using ClinicScheduler.pacient.model;
using ClinicScheduler.pacient.repository;
using ClinicScheduler.pacient.service.interfaces;
using ClinicScheduler.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.pacient.service
{
    public class PacientCommandService:IPacientCommandService
    {
        public IPacientRepository repo;

        public PacientCommandService()
        {
            repo = new PacientRepository();
        }

        public void Add(Pacient pacient)
        {
            List<Pacient>pacients=repo.GetAllPacients();

            foreach(Pacient p in pacients)
            {
                if (p.Equals(pacient)){
                    throw new ItemDejaExistentException(Constants.ITEM_DEJA_EXISTENT_EXCEPTION);
                }
            }
            this.repo.Add(pacient);
        }

        public void EditById(int id, Pacient pacient)
        {
            List<Pacient> pacients = repo.GetAllPacients();
            bool flag = false;

            foreach (Pacient p in pacients)
            {
                if (p.Equals(pacient))
                {
                    flag=true;
                }
            }

            if (flag.Equals(false))
            {
                throw new ItemInexistentException(Constants.ITEM_INEXISTENT_EXCEPTION);
            }

            this.repo.EditById(id,pacient);
        }

        public List<Pacient> GetAllPacients()
        {
            List<Pacient> pacients = this.repo.GetAllPacients();

            return pacients;
        }

        public void Remove(int id)
        {
            List<Pacient> pacients = repo.GetAllPacients();
            bool flag = false;
            Pacient pacient=repo.GetById(id);

            foreach (Pacient p in pacients)
            {
                if (p.Equals(pacient))
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
