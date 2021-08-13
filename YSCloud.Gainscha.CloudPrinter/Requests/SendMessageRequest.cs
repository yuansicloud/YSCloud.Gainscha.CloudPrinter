using Newtonsoft.Json;

namespace YSCloud.Gainscha.CloudPrinter.Requests
{
    public class SendMessageRequest : BaseRequest
    {
        [JsonProperty(PropertyName = "deviceID")]
        public string DeviceId { get; set; }

        [JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; } = 2.ToString();

        [JsonProperty(PropertyName = "msgDetail")]
        public string MsgDetail { get; set; }

        [JsonProperty(PropertyName = "charset")]
        public string Charset { get; set; } = 1.ToString();

        [JsonProperty(PropertyName = "msgNo")]
        public string MsgNo { get; set; }

        [JsonProperty(PropertyName = "reprint")]
        public int Reprint { get; set; } = 0;

        [JsonProperty(PropertyName = "multi")]
        public int Multi { get; set; } = 0;

        [JsonProperty(PropertyName = "times")]
        public int Times { get; set; } = 1;

        [JsonProperty(PropertyName = "voice")]
        public string Voice { get; set; }

        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }

        public SendMessageRequest(
            string apiKey,
            string memberCode,
            string deviceId,
            string msgDetail,
            string charset = "1",
            string mode = "2",
            string msgNo = null,
            int reprint = 0,
            int multi = 0,
            int times = 1,
            string voice = null,
            string token = null)
        {
            ReqTime = GetTimeStamp();
            SecurityCode = MD5POSCOM(memberCode + deviceId + msgNo + ReqTime + apiKey);
            MemberCode = memberCode;
            DeviceId = deviceId;
            MsgDetail = msgDetail;
            Charset = charset;
            Mode = mode;
            MsgNo = msgNo;
            Reprint = reprint;
            Multi = multi;
            Times = times;
            Voice = voice;
            Token = token;
        }
    }
}