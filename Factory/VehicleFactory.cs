using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class VehicleFactory : IVehicleFactory
    {
        public IVehicle Build(CarType carType)
        {
            switch (carType)
            {

                case CarType.Motorbike:
                    return new Motorbike();
                case CarType.Car:
                    return new Car();
                case CarType.Truck:
                    return new Truck();
                default:
                    return new Car();

            }
        }


    }
}
