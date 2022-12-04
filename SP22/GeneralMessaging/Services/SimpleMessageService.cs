using System;
namespace GeneralMessaging.Services;

public class SimpleMessageService : ISimpleMessageService
{
    private readonly IConnectionFactory _connectionFactory;
    private readonly IConnection _connection;

    public SimpleMessageService(IConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory ?? throw new ArgumentNullException(nameof(connectionFactory));
        _connection = _connectionFactory.CreateConnection();
    }

    public IModel CreateModel()
    {
        return _connection.CreateModel();
    }

    public void Dispose()
    {
        _connection.Close();
    }
}