using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;
using Car;

namespace CarWebAPI.Controllers
{
    public class CarController : ApiController
    {
        [HttpGet()]
        [Route("api/Car/StartEngine")]
        public string StartEngine()
        {
            V8 engine = new V8();
            Car.Car car = new Car.Car(engine);
            return car.StartEngine();
        }
        
        [HttpGet()]
        [Route("api/Car/StopEngine")]
        public string StopEngine()
        {
            V8 engine = new V8();
            Car.Car car = new Car.Car(engine);
            return car.StopEngine();
        }

        [HttpGet()]
        [Route("api/Car/MoveCarForward/{meters}")]
        public string MoveCarForward(decimal meters)
        {
            V8 engine = new V8();
            Car.Car car = new Car.Car(engine);
            return car.MoveForward(meters);
        }

        [HttpGet()]
        [Route("api/Car/MoveCarBackward/{meters}")]
        public string MoveCarBackward(decimal meters)
        {
            V8 engine = new V8();
            Car.Car car = new Car.Car(engine);
            return car.MoveBackards(meters);
        }
    }
}
