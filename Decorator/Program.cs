using Decorator;

Console.Title = "Decorator";

//Instantiate mail service
var cloudMailService = new CloudMailService();
cloudMailService.SendMail("Hi there");

var onPremMailService = new OnPremMailService();
onPremMailService.SendMail("Hi there");

// add bahaviour
var statasticsDecorator = new StatisticsDecorator(cloudMailService);
statasticsDecorator.SendMail($"Hi there via {nameof(StatisticsDecorator)} wraper");

// add bahaviour
var messageDatabaseDecorator = new MessageDatabaseDecorator(onPremMailService);
messageDatabaseDecorator.SendMail($"Hi there via {nameof(MessageDatabaseDecorator)} wrapper Message 1");
messageDatabaseDecorator.SendMail($"Hi there via {nameof(MessageDatabaseDecorator)} wrapper Message 2");

foreach (var message in messageDatabaseDecorator.messages)
{
    Console.WriteLine($"Stored Messages : {message}");
}

Console.ReadLine();