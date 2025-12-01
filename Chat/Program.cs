using Chat;
using MedtatR.Services;

var mediator = new Mediator<ChatMessageRequest, bool>();
var handler = new ChatMessageHandler(mediator);
mediator.Register(handler);


var users = new[] { "Alice", "Bob", "Mike" };
var from = "David";

Console.WriteLine($"You are: {from}");
Console.WriteLine("Type a message (type 'exit' to quit)");

while (true)
{
    var message = Console.ReadLine();
    if (message == "exit") break;

    var request = new ChatMessageRequest(from, message!, users);
    mediator.Send(request);
}
