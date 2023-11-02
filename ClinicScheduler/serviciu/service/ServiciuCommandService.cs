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
    public class ServiciuCommandService : IServiciuCommandService
    {
        private IServiciuRepository repo;

        public ServiciuCommandService()
        {
            this.repo=new ServiciuRepository();
        }

        public void Add(Serviciu serviciu)
        {
            List<Serviciu> servicii = this.repo.GetAllServicii();

            foreach (Serviciu s in servicii)
            {
                if (s.Equals(serviciu))
                {
                    throw new ItemDejaExistentException(Constants.ITEM_DEJA_EXISTENT_EXCEPTION);
                }
            }

            this.repo.Add(serviciu);
        }

        public void EditById(int id, Serviciu serviciu)
        {
            this.repo.EditById(id,serviciu);
        }

        public void Remove(int id)
        {
            List<Serviciu> servicii = this.repo.GetAllServicii();
            bool flag = false;
            Serviciu serviciu=this.repo.GetById(id);

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

            this.repo.Remove(id);
        }
    }
}
