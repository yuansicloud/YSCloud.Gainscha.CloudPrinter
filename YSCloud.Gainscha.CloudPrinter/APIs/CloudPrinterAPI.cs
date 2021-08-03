using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YSCloud.Gainscha.CloudPrinter.Requests;
using YSCloud.Gainscha.CloudPrinter.Responses;

namespace YSCloud.Gainscha.CloudPrinter.APIs
{
    public interface CloudPrinterAPI
    {
        [Post("/sendMsg")]
        Task<BaseResponse> SendMessage([Body(BodySerializationMethod.UrlEncoded)] SendMessageRequest request);

        [Post("/adddev")]
        Task<BaseResponse> AddPrinter([Body(BodySerializationMethod.UrlEncoded)] AddPrinterRequest request);

        [Post("/deldev")]
        Task<BaseResponse> DeletePrinter([Body(BodySerializationMethod.UrlEncoded)] DeletePrinterRequest request);

        [Post("/templetPrint")]
        Task<BaseResponse> PrintByTemplate([Body(BodySerializationMethod.UrlEncoded)] PrintByTemplateRequest request);
    }
}
