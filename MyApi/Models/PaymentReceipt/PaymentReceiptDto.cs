using Entities;
using WebFramework.Api;

namespace MyApi.Models
{
    public class PaymentReceiptDto : BaseDto<PaymentReceiptDto, PaymentReceipt>
    {
        public decimal Price { get; set; }
        public string PaymentDate { get; set; }
        public string BankName { get; set; }
        public int PaymentReceiptNo { get; set; }
        public string PaymentReceiptStatus { get; set; }
        public string StatusName { get; set; }
        public string AttachmentId { get; set; }
    }
}
