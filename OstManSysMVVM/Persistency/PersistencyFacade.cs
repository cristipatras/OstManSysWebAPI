using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using OstManSysMVVM.Model;

namespace OstManSysMVVM.Persistency
{
    class PersistencyFacade
    {
        const string ServerUrl = "http://localhost:26562/";
        HttpClientHandler handler;

        public PersistencyFacade()
        {
            handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;
        }

        public List<Apartment> GetApartments()
        {
            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(ServerUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    var response = client.GetAsync("api/Apartments").Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var apartmentList = response.Content.ReadAsAsync<IEnumerable<Apartment>>().Result;
                        return apartmentList.ToList();
                    }

                }
                catch (Exception ex)
                {
                    new MessageDialog(ex.Message).ShowAsync();
                }
                return null;
            }
        }
    }
}