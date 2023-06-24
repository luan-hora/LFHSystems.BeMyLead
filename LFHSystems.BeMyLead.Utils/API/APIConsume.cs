using System.Net.Http.Json;

namespace LFHSystems.BeMyLead.Utils.API
{
    public static class APIConsume
    {
        public static async Task<string> ApiPostAsync(string pUrl, StringContent pContent)
        {
            string ret;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.PostAsync(pUrl, pContent))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ret = apiResponse;
                }
            }

            return ret;
        }
                
        public static async Task<string> ApiGetAsync(string pUrl)
        {
            string ret;
            try
            {
                
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync(pUrl))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        ret = apiResponse;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return ret;
        }


    }
}
