using Newtonsoft.Json;

namespace YSCloud.Gainscha.CloudPrinter.Requests
{
    public class AddPrinterRequest : BaseRequest
    {
        [JsonProperty(PropertyName = "deviceID")]
        public string DeviceId { get; set; }

        [JsonProperty(PropertyName = "devName")]
        public string DevName { get; set; }

        [JsonProperty(PropertyName = "grpID")]
        public int? GrpID { get; set; }

        public AddPrinterRequest(
            string apiKey,
            string memberCode,
            string deviceId,
            string devName,
            int? grpId = null)
        {
            ReqTime = GetTimeStamp();
            SecurityCode = MD5POSCOM(memberCode + ReqTime + apiKey + deviceId);
            MemberCode = memberCode;
            DeviceId = deviceId;
            DevName = devName;
            GrpID = grpId;
        }
    }
}