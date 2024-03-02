using BusProject.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusProject.BL
{
    public class BusBusiness
    {
        IBusRepository _repository;

        public BusBusiness(IBusRepository repository)
        {
            _repository = repository;
        }

        public List<Bus> Get()
        {
            return _repository.Get();
        }

        public Bus Get(int id)
        {
            return _repository.Get(id);
        }

        public bool Add(Bus model)
        {
            return _repository.Add(model);
        }

        public bool Update(Bus model)
        {
            return _repository.Update(model);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

    }
}
