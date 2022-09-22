namespace Cashier.BaseClassesForWPFDeveloping
{
    using Newtonsoft.Json;
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;

    /// <summary>
    /// Abstract class for everyone http client
    /// </summary>
    public abstract class ClientBase
    {
        private readonly string webAppAdress;
        private readonly string scheme;
        private readonly string token;
        /// <summary>
        /// String builder, consists of 2 parts:
        /// 1. Web api adress
        /// 2. Action prefix (can be with attributes)
        /// </summary>
        protected StringBuilder actionAddressBuilder;

        public ClientBase(string WebAppAdress, string Scheme, string Token)
        {
            webAppAdress = WebAppAdress;
            scheme = Scheme;
            token = Token;
            actionAddressBuilder = new StringBuilder(webAppAdress);
        }

        /// <summary>
        /// Get response from http request.
        /// Set all attributes. Send request. Return result.
        /// </summary>
        /// <param name="method"></param>
        /// <param name="body"></param>
        /// <returns>HttpResponseMessage. Result from request to api.</returns>
        protected HttpResponseMessage GetResponseFromHttp(HttpMethod method, object body)
        {
            HttpResponseMessage message;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(scheme, token);
                var request = new HttpRequestMessage()
                {
                    Method = method,
                    RequestUri = new Uri(actionAddressBuilder.ToString())
                };
                actionAddressBuilder.Clear().Append(webAppAdress);
                if (body != null)
                {
                    string data = JsonConvert.SerializeObject(body);
                    request.Content = new StringContent(data, Encoding.UTF8, "application/json");
                }
                message = client.SendAsync(request).Result;
            }
            return message;
        }
    }
}