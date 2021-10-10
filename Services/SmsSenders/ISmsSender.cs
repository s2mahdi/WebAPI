using Common.Results;
using System.Threading.Tasks;

namespace Services.SmsSenders
{
    public interface ISmsSender
    {
        Task<Result> SendAsync(string phoneNumber, string message);
    }
}
