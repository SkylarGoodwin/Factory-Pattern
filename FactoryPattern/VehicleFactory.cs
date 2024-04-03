using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal static class VehicleFactory
    {
        public static IVehicle GetVehicle(int wheelCount)
        {
            if(wheelCount == 2)
            {
                return new Motorcycle();
            }
            else { return new Car(); }
        }
    }
}
