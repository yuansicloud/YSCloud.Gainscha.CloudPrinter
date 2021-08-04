using System.Collections.Generic;

namespace YSCloud.Gainscha.CloudPrinter.Responses
{
    public class GetPrinterStatusResponse : BaseResponse
    {
        public List<PrinterStatusDto> StatusList { get; set; }
    }

    public class PrinterStatusDto
    {
        public string DeviceId { get; set; }

        public int Online { get; set; }

        public int Status { get; set; }

        public string OutTime { get; set; }

        public string PrintNum { get; set; }
    }
}