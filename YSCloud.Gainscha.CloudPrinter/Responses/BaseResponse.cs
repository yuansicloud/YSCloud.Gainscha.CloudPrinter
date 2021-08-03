using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace YSCloud.Gainscha.CloudPrinter.Responses
{
    public class BaseResponse
    {
        public int Code { get; set; }

        public string Msg { get; set; }

        public void Validate()
        {
            if (Code != 0 || Code != 1)
            {
                throw new UserFriendlyException(Msg, Code.ToString());
            }
        }
    }
}
