using Common.HttpClinet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Common.Results
{
    public static class ResultExtensions
    {
        private static string errorMessage = "خطا در فراخوانی سرویس رخ داد.";

       
        public static bool IsEmpty<T>(this IEnumerable<T> ts)
        {
            if (ts == null || !ts.Any())
            {
                return true;
            }
            return false;
        }
        public static bool IsNotEmpty<T>(this IEnumerable<T> ts)
        {
            if (ts == null)
            {
                return false;
            }
            if (ts != null && ts.Any())
            {
                return true;
            }
            return false;
        }

        public static bool IsNull(this object obj)
        {
            return obj == null;
        }
        public static bool IsNotNull(this object obj)
        {
            return obj != null;
        }

        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }
        public static bool IsNullOrWhiteSpace(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }
        public static bool IsNotNullOrEmpty(this string str)
        {
            return !string.IsNullOrEmpty(str);
        }
        public static bool IsNotNullOrWhiteSpace(this string str)
        {
            return !string.IsNullOrWhiteSpace(str);
        }
    }
}
