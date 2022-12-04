string hostName = args[0];

Console.WriteLine("Starting.");

string botId = args[1];
string botStatus = args[2];
string botMessage = args[3];
DateTime messageTime = DateTime.UtcNow;

IConnectionFactory ICF = new ConnectionFactory() { HostName = "localhost", AutomaticRecoveryEnabled = true };
ISimpleMessageService messageService = new SimpleMessageService(ICF);

IModel channel = messageService.CreateModel();

if (channel == null)
    return;

// Declare

// Json handler

// Publisher

Console.WriteLine("Press enter to exit.");