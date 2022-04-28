using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Linq;
using System.Web;

namespace Authenticator.AuthenticatorDetail
{
    class UrlQueryParam
    {
        private string secret;
        private string key;
        private string userinfo;
        private Uri uri;

        //otpauth://totp/ACME%20Co:john@example.com?secret=HXDMVJECJJWSRB3HWIZR4IFUGFTMXBOZ&issuer=ACME%20Co&algorithm=SHA1&digits=6&period=30"
        //otpauth://totp/Google%3Abotsender09%40gmail.com?secret=pffhz5wyugbwxcgxuy6xryj6mtvgulen&issuer=Google

        public UrlQueryParam()
        {
        }
        public UrlQueryParam(Uri url)
        {
            string uri1 = url.ToString();
            string[] user;
            string temp;
            uri = url;
            secret = string.Join(string.Empty, uri1.Split('?').Skip(1));
            // user info
            temp = string.Join(string.Empty, uri1.Split('/').Skip(3));
            user = temp.Split('?');
            userinfo = user[0];
        }
        public UrlQueryParam(string secret)
        {
            string[] key = secret.Split(' ');
            foreach (var item in key)
            {
                this.key += item;
            }
        }

        public string GetQueryString(QueryType queryType)
        {
            string result = null;
            if(queryType == QueryType.Secret)
            {
                QueryHelpers.ParseQuery(uri.Query).TryGetValue("secret", out var value);
                result = value;
            }else if(queryType == QueryType.Issuer)
            {
                QueryHelpers.ParseQuery(uri.Query).TryGetValue("issuer", out var value);
                result = value;
            }else if(queryType == QueryType.UserData)
            {
                string[] temp;
                temp = HttpUtility.UrlDecode(userinfo).Split(':');
                result = temp[temp.Length - 1];
            }
            return result;
        }

        public string Getkey()
        {
            return this.key;
        }
    }
}
