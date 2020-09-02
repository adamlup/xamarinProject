using System.Collections.Generic;
using System.Collections.ObjectModel;
using xamarinProjekt.Objects;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace xamarinProjekt.ViewModels
{
    public class MainViewModel
    {
        public List<CatFacts> catFactsList { get; set; }
        public MainViewModel()
        {
            Task.Run(async () => { await Initialize(); }).Wait();

        }

        private async Task Initialize()
        {
            catFactsList = new List<CatFacts>();
            
            for (int i = 0; i < 5; i++)
            {
                var catFact = await getCatFacts();
                catFactsList.Add(catFact);
            }
        }

        private async Task<CatFacts> getCatFacts()
        {
            HttpClient client = new HttpClient();

            var response = await client.GetStringAsync("https://cat-fact.herokuapp.com/facts/random");

            return JsonConvert.DeserializeObject<CatFacts>(response);
        }
    }  
}