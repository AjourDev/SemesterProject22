using System;
using BotMobile.Models;
using Newtonsoft.Json;

namespace BotMobile.Services
{
	public class MessageAPIService : IMessageAPIService
	{
        private readonly Uri _baseAddress;
        

		public MessageAPIService()
		{
            _baseAddress = new("localhost:443");
		}

        public async Task<List<BotModel>> GetBots()
        {
            using (HttpClient _client = new() { BaseAddress = _baseAddress })
            {
                _client.DefaultRequestHeaders.Add("itemId", "0");
                var response = await _client.GetAsync("api/bots");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var objs = JsonConvert.DeserializeObject<List<BotModel>>(content);
                    return objs;
                }
                return new();
            }
        }
    }
}
