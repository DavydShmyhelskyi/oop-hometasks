using Chat;
using MedtatR.Abstractions;
using MedtatR.Services;

public class ChatMessageHandler
    : IRequestHandler<ChatMessageRequest, bool>
{
    private readonly Mediator<ChatMessageRequest, bool> _mediator;

    public ChatMessageHandler(Mediator<ChatMessageRequest, bool> mediator)
    {
        _mediator = mediator;
    }

    public bool Handle(ChatMessageRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Message))
            return false;

        foreach (var to in request.Receivers)
        {
            var notification = new ChatNotification(
                request.From, to, request.Message
            );

            Console.WriteLine(_mediator.Publish(notification));
        }

        return true;
    }
}
