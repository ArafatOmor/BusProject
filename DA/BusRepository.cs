using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusProject.DA
{
    public class BusRepository : IBusRepository
    {
        List<Bus> listBus = new List<Bus>()
        {
            new Bus(1, "Ena"),
            new Bus(2, "Nabil"), 
            new Bus(3, "Hanif"),
            new Bus(4, "Heritage" )
        };
        public List<Bus> Get()
        {
            return listBus.OrderBy(x => x.BusName).ToList();
        }

        public Bus Get(int id)
        {
            Bus oCustomer = listBus.Where(x => x.BusId == id).FirstOrDefault();
            return oCustomer;
        }

        public bool Add(Bus model)
        {
            listBus.Add(model);
            return true;
        }

        public bool Update(Bus model)
        {
            bool isExecuted = false;
            Bus obus = listBus.Where(x => x.BusId == model.BusId).FirstOrDefault();
            if (obus != null)
            {
                listBus.Remove(obus);
                listBus.Add(model);
                isExecuted = true;
            }
            return isExecuted;
        }

        public bool Delete(int id)
        {
            bool isExecuted = false;
            Bus obus = listBus.Where(x => x.BusId == id).FirstOrDefault();
            if (obus!= null)
            {
                listBus.Remove(obus);
                isExecuted = true;
            }
            return isExecuted;
        }
    }
}
