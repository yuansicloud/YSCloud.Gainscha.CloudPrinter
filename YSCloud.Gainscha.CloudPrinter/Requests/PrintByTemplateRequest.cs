using Newtonsoft.Json;

namespace YSCloud.Gainscha.CloudPrinter.Requests
{
    public class PrintByTemplateRequest : BaseRequest
    {
        [JsonProperty(PropertyName = "deviceID")]
        public string DeviceId { get; set; }

        [JsonProperty(PropertyName = "templetID")]
        public string TemplateId { get; set; }

        [JsonProperty(PropertyName = "tData")]
        public string Data { get; set; }

        [JsonProperty(PropertyName = "charset")]
        public string Charset { get; set; } = 1.ToString();

        [JsonProperty(PropertyName = "msgNo")]
        public string MsgNo { get; set; }

        [JsonProperty(PropertyName = "reprint")]
        public int Reprint { get; set; } = 0;

        [JsonProperty(PropertyName = "multi")]
        public int Multi { get; set; } = 0;

        public PrintByTemplateRequest(
            string apiKey,
            string memberCode,
            string deviceId,
            string charset = "1",
            string msgNo = null,
            int reprint = 0,
            int multi = 0)
        {
            ReqTime = GetTimeStamp();
            SecurityCode = MD5POSCOM(memberCode + deviceId + msgNo ?? string.Empty + ReqTime + apiKey);
            MemberCode = memberCode;
            DeviceId = deviceId;
            Charset = charset;
            MsgNo = msgNo;
            Reprint = reprint;
            Multi = multi;
        }
    }
}