using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Refit;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using YSCloud.Gainscha.CloudPrinter.APIs;
using YSCloud.Gainscha.CloudPrinter.Requests;
using YSCloud.Gainscha.CloudPrinter.Responses;

namespace YSCloud.Gainscha.CloudPrinter.Requesters
{
    public class CloudPrinterApiRequester : ITransientDependency, CloudPrinterAPI
    {
        private readonly CloudPrinterOptions _option;

        private readonly CloudPrinterAPI _cloudPrinterAPI;

        public CloudPrinterApiRequester(
            IOptions<CloudPrinterOptions> option)
        {
            _option = option.Value;
            _cloudPrinterAPI = RestService.For<CloudPrinterAPI>(_option.ServiceUrl,
                new RefitSettings
                {
                    ContentSerializer = new NewtonsoftJsonContentSerializer(
                        new JsonSerializerSettings
                        {
                            ContractResolver = new CamelCasePropertyNamesContractResolver()
                        }
                    )
                });
        }

        public Task<BaseResponse> AddPrinter(AddPrinterRequest request)
        {
            return _cloudPrinterAPI.AddPrinter(request);
        }

        public Task<BaseResponse> DeletePrinter(DeletePrinterRequest request)
        {
            return _cloudPrinterAPI.DeletePrinter(request);
        }

        public Task<GetPrinterStatusResponse> GetPrinterStatus(GetPrinterStatusRequest request)
        {
            return _cloudPrinterAPI.GetPrinterStatus(request);
        }

        public Task<BaseResponse> PrintByTemplate(PrintByTemplateRequest request)
        {
            return _cloudPrinterAPI.PrintByTemplate(request);
        }

        public Task<BaseResponse> SendMessage(SendMessageRequest request)
        {
            return _cloudPrinterAPI.SendMessage(request);
        }
    }
}