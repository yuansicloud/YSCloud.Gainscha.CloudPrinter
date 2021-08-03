using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YSCloud.Gainscha.CloudPrinter.Requests
{
    public class DeletePrinterRequest : BaseRequest
    {
        [JsonProperty(PropertyName = "deviceID")]
        public string DeviceId { get; set; }

        public DeletePrinterRequest(
            string apiKey,
            string memberCode,
            string deviceId)
        {
            ReqTime = GetTimeStamp();
            SecurityCode = MD5POSCOM(memberCode + ReqTime + apiKey + deviceId);
            MemberCode = memberCode;
            DeviceId = deviceId;
        }
    }
}
