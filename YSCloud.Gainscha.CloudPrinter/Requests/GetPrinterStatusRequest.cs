using Newtonsoft.Json;

namespace YSCloud.Gainscha.CloudPrinter.Requests
{
    public class GetPrinterStatusRequest : BaseRequest
    {
        [JsonProperty(PropertyName = "deviceID")]
        public string DeviceId { get; set; }

        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }

        public GetPrinterStatusRequest(
            string apiKey,
            string memberCode,
            string deviceId,
            string token = null)
        {
            ReqTime = GetTimeStamp();
            SecurityCode = MD5POSCOM(memberCode + ReqTime + apiKey);
            MemberCode = memberCode;
            DeviceId = deviceId;
            Token = token;
        }
    }
}