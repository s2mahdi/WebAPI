using AutoMapper;
using Data.Repositories;
using Entities;
using MyApi.Models;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class PaymentReceiptController : CrudController<PaymentReceiptDto, PaymentReceipt>
    {
        public PaymentReceiptController (IRepository<PaymentReceipt> repository, IMapper mapper)
            : base(repository, mapper)
        {
           
        }
    }
}
