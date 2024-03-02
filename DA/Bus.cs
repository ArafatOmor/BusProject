using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusProject.DA
{
    public class Bus

    {
        public int BusId;
        public string BusName;
        public Bus()
        {
        }
        public Bus(int id, string name)
        {
            BusId = id;
            BusName = name;

        }
    }
}

