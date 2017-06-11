//-----------------------------------------------------------------------
// <copyright file="ApiHelper.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace SharedLibrary.Helpers
{
    using System.Net.Http;
    using System.Net.Http.Headers;

    /// <summary>
    /// API helper class
    /// </summary>
    public static class ApiHelper
    {
        /// <summary>
        /// Makes the API request.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>The API response</returns>
        /// <exception cref="HttpRequestException">API request failed</exception>
        public static string MakeApiRequest(string url)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage messge = client.GetAsync(url).Result;
            string description = string.Empty;
            if (!messge.IsSuccessStatusCode)
            {
                throw new HttpRequestException("Api request failed");
            }

            return messge.Content.ReadAsStringAsync().Result;
        }
    }
}