using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Script.Services;
using System.Web.Services;

namespace BusStations.Wcf.JsonService
{
    
    [ServiceContract]
    public interface IUpdateMonitor
    {
        [OperationContract]
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        string Update(int stationId);

    }
}
