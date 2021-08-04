using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YSCloud.Gainscha.CloudPrinter
{
    public class CloudPrinterOptions
    {
        public string MemberCode { get; set; }

        public string ApiKey { get; set; }

        public string ServiceUrl { get; set; }

        public int CheckUpdateTime { get; set; } = 3;
    }
}
