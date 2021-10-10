using System.Collections.Generic;
using System.Web;

namespace Common.HttpClinet
{
    public static class HttpClintExtentions
    {
        public static string ObjectToQueryString(this string url, object obj)
        {
            var props = obj.GetType().GetProperties();
            var param = new List<string>();
            foreach (var p in props)
            {
                var value = p.GetValue(obj, null);
                if (value != null)
                {
                    string content = value.ToString();
                    if (string.IsNullOrEmpty(content) == false)
                    {
                        param.Add(p.Name + "=" + HttpUtility.UrlEncode(value.ToString()));
                    }
                }
            }

            string queryString = string.Join("&", param);
            url += "?" + queryString;
            return url;
        }
    }
}
