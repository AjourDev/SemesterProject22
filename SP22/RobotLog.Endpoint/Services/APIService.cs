namespace RobotLog.Endpoint.Services;

public class APIService : IAPIService
{
	private readonly Uri _baseAddress;

	public APIService(string baseAddress)
	{
		_baseAddress = new(baseAddress);
	}

	public async Task Post(string json)
	{
		await Task.Delay(1);
		using (HttpClient _client = new() { BaseAddress = _baseAddress } )
		{
			StringContent Stringjson = new(json);
			await _client.PostAsync("api/messages", Stringjson);
		}
	}
}
