namespace Wiki.Core.Access
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;

    /// <summary>
    /// Helper class for Web access.
    /// </summary>
    public class WebAccess
    {
        private string mainUrl;
        private CookieContainer cookies = new CookieContainer();

        public WebAccess(string mainUrl)
        {
            this.mainUrl = mainUrl;
        }

        /// <summary>
        /// GET request.
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public string Get(Dictionary<string, string> parameters)
        {
            return this.Post(parameters, null);
        }

        /// <summary>
        /// POST request.
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="requestBody"></param>
        /// <returns></returns>
        public string Post(Dictionary<string, string> parameters, Dictionary<string, string> requestBody)
        {
            var request = (HttpWebRequest)WebRequest.Create(this.mainUrl + this.ObjectToString(parameters));
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:35.0) Gecko/20100101 Firefox/35.0";
            request.ContentType = "application/x-www-form-urlencoded";
            request.CookieContainer = (this.cookies.Count == 0) ? new CookieContainer() : this.cookies;

            if (requestBody != null)
            {
                request.Method = "POST";
                byte[] postBytes = Encoding.UTF8.GetBytes(this.ObjectToString(requestBody));
                request.ContentLength = postBytes.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(postBytes, 0, postBytes.Length);
                }
            }

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                response.Cookies.Cast<Cookie>().ToList().ForEach(c => cookies.Add(c));
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        private string ObjectToString(Dictionary<string, string> obj)
        {
            var result = string.Empty;
            obj.ToList().ForEach(m => result += HttpUtility.UrlEncode(m.Key) + "=" + HttpUtility.UrlEncode(m.Value) + "&");

            return result.Remove(result.Length - 1);
        }
    }
}
