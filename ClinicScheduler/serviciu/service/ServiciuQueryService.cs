using ClinicScheduler.exceptii;
using ClinicScheduler.serviciu.model;
using ClinicScheduler.serviciu.repository;
using ClinicScheduler.serviciu.service.interfaces;
using ClinicScheduler.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicScheduler.serviciu.service
{
    public class ServiciuQueryService:IServiciuQueryService
    {
        public IServiciuRepository repo;

        public ServiciuQueryService()
        {
            this.repo = new ServiciuRepository();
        }

        public Serviciu GetById(int id)
        {
            List<Serviciu> servicii = this.repo.GetAllServicii();
            bool flag = false;
            Serviciu serviciu = this.repo.GetById(id);

            foreach (Serviciu s in servicii)
            {
                if (s.Equals(serviciu))
                {
                    flag=true;
                }
            }

            if (flag.Equals(false))
            {
                throw new ItemInexistentException(Constants.ITEM_INEXISTENT_EXCEPTION);
            }

            return serviciu;
        }

        public Serviciu GetByNume(string nume)
        {
            List<Serviciu> servicii = this.repo.GetAllServicii();
            bool flag = false;
            Serviciu serviciu = this.repo.GetByNume(nume);

            foreach (Serviciu s in servicii)
            {
                if (s.Equals(serviciu))
                {
                    flag=true;
                }
            }

            if (flag.Equals(false))
            {
                throw new ItemInexistentException(Constants.ITEM_INEXISTENT_EXCEPTION);
            }

            return serviciu;
        }

        public List<Serviciu> GetAllServicii()
        {
            List<Serviciu> servicii = this.repo.GetAllServicii();

            return servicii;
        }
    }
}
