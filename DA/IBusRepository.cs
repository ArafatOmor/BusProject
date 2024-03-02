using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusProject.DA
{
    public interface IBusRepository
    {
            List<Bus> Get();
            Bus Get(int id);
            bool Add(Bus model);
            bool Update(Bus model);
            bool Delete(int id);
     }
}

