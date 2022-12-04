string hostName = args[0];

Console.WriteLine("Starting application.");

IConnectionFactory ICF = new ConnectionFactory() { HostName = "localhost", AutomaticRecoveryEnabled = true };
ISimpleMessageService messageService = new SimpleMessageService(ICF);

IModel channel = messageService.CreateModel();

if (channel == null)
    return;

// Declare

// Message handler

// Consumer

Console.WriteLine("Press enter to exit.");
Console.ReadLine();