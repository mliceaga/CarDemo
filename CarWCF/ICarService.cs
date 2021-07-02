using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CarWCF
{
    [ServiceContract]
    public interface ICarService
    {
        [OperationContract]
        [WebGet]
        string StartEngine();

        [OperationContract]
        [WebGet]
        string StopEngine();

        [OperationContract]
        [WebGet]
        string MoveCarForward(decimal meters);

        [OperationContract]
        [WebGet]
        string MoveCarBackward(decimal meters);
    }

}
