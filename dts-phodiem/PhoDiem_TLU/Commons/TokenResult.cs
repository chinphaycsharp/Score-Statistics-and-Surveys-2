using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoDiem_TLU.Commons
{
    [Serializable]
    public class TokenResult
    {
        public string access_token { get; set; }
        public string token_type { get;  set; }
        public string refresh_token { get; set; }
        public string expires_in { get; set; }
        public string scope { get; set; }

        public static TokenResult handleStringToToken(string[] input)
        {
            TokenResult token = new TokenResult();
            foreach (var item in input)
            {
                if (item.Contains("access_token"))
                {
                    string[] a = item.ToString().Split(':');
                    string b = a[a.Length - 1].Replace("\"", string.Empty);
                    token.access_token = b;
                }
                if (item.Contains("token_type"))
                {
                    string[] a = item.ToString().Split(':');
                    string b = a[a.Length - 1].Replace("\"", string.Empty);
                    token.token_type = b;
                }
                if (item.Contains("refresh_token"))
                {
                    string[] a = item.ToString().Split(':');
                    string b = a[a.Length - 1].Replace("\"", string.Empty);
                    token.refresh_token = b;
                }
                if (item.Contains("expires_in"))
                {
                    string[] a = item.ToString().Split(':');
                    string b = a[a.Length - 1].Replace("\"", string.Empty);
                    token.expires_in = b;
                }
                if (item.Contains("scope"))
                {
                    string[] a = item.ToString().Split(':');
                    string b = a[a.Length - 1].Replace("\"", string.Empty);
                    token.scope = b.Replace("}", string.Empty);
                }

            }
            return token;
        }
    }
}