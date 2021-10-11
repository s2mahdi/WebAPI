using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utilities
{
   public static class EnumStatus
    {
        public enum VerificationStatus : byte
        {
            SendSMS = 1,
            ExpireTime = 2,
            AcceptUser = 3,
            NotCorrectCode = 4
        }
    }
}
