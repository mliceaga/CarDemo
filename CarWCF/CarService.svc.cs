using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Car;

namespace CarWCF
{
    public class CarService : ICarService
    {
        public string StartEngine()
        {
            V8 engine = new V8();
            Car.Car car = new Car.Car(engine);
            return car.StartEngine();
        }

        public string StopEngine()
        {
            V8 engine = new V8();
            Car.Car car = new Car.Car(engine);
            return car.StopEngine();
        }

        public string MoveCarForward(decimal meters)
        {
            V8 engine = new V8();
            Car.Car car = new Car.Car(engine);
            return car.MoveForward(meters);
        }

        public string MoveCarBackward(decimal meters)
        {
            V8 engine = new V8();
            Car.Car car = new Car.Car(engine);
            return car.MoveBackards(meters);
        }

    }
}
