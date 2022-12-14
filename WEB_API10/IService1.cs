using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using static WEB_API10.ServiceModelscs;

namespace WEB_API10
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(
            Method = "GET", UriTemplate = "/GetUser1",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json
            )
        ]
        User[] GetUsers();
    }
}
