using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ParserHTML.core
{
    class HTMLLoader
    {
        readonly HttpClient client;
        readonly string URL;

        public HTMLLoader(IParserSettings settings)
        {
            client = new HttpClient();
            URL = $"{settings.BaseURl}/{settings.Prefix}/";
        }

        public async Task<string> GetSoureceByPageId(int id)
        {
            var currentUrl = URL.Replace("{CurrentId}", id.ToString());
            var response = await client.GetAsync(currentUrl);
            string source = null;

            if (response != null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }

            return source;
        }
    }
}
