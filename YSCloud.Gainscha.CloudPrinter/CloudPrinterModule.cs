using Microsoft.Extensions.DependencyInjection;
using System;
using Volo.Abp.Modularity;

namespace YSCloud.Gainscha.CloudPrinter
{
    public class CloudPrinterModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();

            Configure<CloudPrinterOptions>(options =>
            {
                options.MemberCode = configuration["CloudPrinterOptions:MemberCode"];
                options.ApiKey = configuration["CloudPrinterOptions:ApiKey"];
                options.ServiceUrl = configuration["CloudPrinterOptions:ServiceUrl"];
                options.CheckUpdateTime = Convert.ToInt32(configuration["GPSManagementOptions:CheckUpdateTime"]);
            });
        }
    }
}