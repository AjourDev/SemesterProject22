namespace GeneralMessaging.Services;

public interface ISimpleMessageService : IDisposable
{
    IModel CreateModel();
}
