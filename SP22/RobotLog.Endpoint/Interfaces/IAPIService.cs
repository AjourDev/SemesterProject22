using System;
namespace RobotLog.Endpoint.Interfaces
{
	public interface IAPIService
	{
		Task Post(string json);
	}
}

