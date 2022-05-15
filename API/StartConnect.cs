using DNNrocketAPI.Components;
using RocketBlog.Components;
using Simplisity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RocketBlog.API
{
    public partial class StartConnect : DNNrocketAPI.APInterface
    {
        public override Dictionary<string, object> ProcessCommand(string paramCmd, SimplisityInfo systemInfo, SimplisityInfo interfaceInfo, SimplisityInfo postInfo, SimplisityInfo paramInfo, string langRequired = "")
        {
            paramCmd = paramCmd.Replace("rocketblog_", "rocketcatalog_");
            systemInfo.SetXmlProperty("genxml/systemkey", "rocketblog");
            var catalogStartConnect = new RocketCatalog.API.StartConnect();
            return catalogStartConnect.ProcessCommand(paramCmd, systemInfo, interfaceInfo, postInfo, paramInfo, langRequired);
        }
    }

}
