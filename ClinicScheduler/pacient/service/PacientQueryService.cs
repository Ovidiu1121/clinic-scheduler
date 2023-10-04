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
    public class PacientQueryService:IPacientQueryService
    {
        private IPacientRepository repo;

        public PacientQueryService()
        {
            repo = new PacientRepository();
        }

        public Pacient GetById(int id)
        {
            List<Pacient> pacients = repo.GetAllPacients();
            bool flag = false;
            Pacient pacient = repo.GetById(id);

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

           return pacient;
        }

        public Pacient GetByNume(string nume)
        {
            List<Pacient> pacients = repo.GetAllPacients();
            bool flag = false;
            Pacient pacient = repo.GetByNume(nume);

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

            return pacient;
        }


    }
}
