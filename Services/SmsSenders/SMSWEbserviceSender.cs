using Common;
using Common.Results;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SmsWebserviceSRC;
using System;
using System.Threading.Tasks;

namespace Services.SmsSenders
{
    public class SMSWEbserviceSender : ISmsSender
    {
        private readonly ILogger<SMSWEbserviceSender> logger;
        private readonly SmsSetting setting;

        public SMSWEbserviceSender(ILogger<SMSWEbserviceSender> logger, IOptionsSnapshot<SiteSettings> settings)
        {
            this.logger = logger;
            setting = settings.Value.SmsSetting;
        }
        public async Task<Result> SendAsync(string phoneNumber, string message)
        {
                NewSmsWebserviceSoapClient client =
                    new NewSmsWebserviceSoapClient(NewSmsWebserviceSoapClient.EndpointConfiguration.NewSmsWebserviceSoap);
            try
            {
                var result = await client.SendAsync(setting.UserName, setting.Password, message, setting.FromNumber, new string[] { phoneNumber });
                return Result.Ok();
            }
            catch (Exception ex)
            {
                logger.LogError(ex,ex.Message);
                return Result.Fail(ex.Message);
            }
            finally
            {
                await client.CloseAsync();
            }
        }
    }

}
