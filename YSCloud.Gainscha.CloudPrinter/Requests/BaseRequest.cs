using Newtonsoft.Json;
using System;
using System.Text;

namespace YSCloud.Gainscha.CloudPrinter.Requests
{
    public class BaseRequest
    {
        [JsonProperty(PropertyName = "reqTime")]
        public string ReqTime { get; set; }

        [JsonProperty(PropertyName = "securityCode")]
        public string SecurityCode { get; set; }

        [JsonProperty(PropertyName = "memberCode")]
        public string MemberCode { get; set; }

        public BaseRequest()
        {

        }

        public BaseRequest(string reqTime, string securityCode, string memberCode)
        {
            ReqTime = reqTime;
            SecurityCode = securityCode;
            MemberCode = memberCode;
        }

        // 校验
        public static string MD5POSCOM(string stringToHash)
        {
            var md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] emailBytes = Encoding.UTF8.GetBytes(stringToHash);
            byte[] hashedEmailBytes = md5.ComputeHash(emailBytes);
            StringBuilder sb = new();
            foreach (var b in hashedEmailBytes)
            {
                sb.Append(b.ToString("x2").ToLower());
            }
            return sb.ToString();
        }

        // 时间戳秒数
        public static string GetTimeStamp()
        {
            TimeSpan ts = DateTime.Now - new DateTime(1970, 1, 1, 8, 0, 0, 0);
            return Convert.ToInt64(ts.TotalMilliseconds).ToString();
        }
    }
}