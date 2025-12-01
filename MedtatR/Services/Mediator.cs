using MedtatR.Abstractions;

namespace MedtatR.Services;

public class Mediator<TRequest, TResponse> 
    where TRequest : IRequest<TResponse>
{
    private IRequestHandler<TRequest, TResponse>? _handler;


    public void Register(IRequestHandler<TRequest, TResponse> handler)
    {
        _handler = handler;
    }

    public TResponse Send(TRequest request)
    {
        if (_handler == null)
            throw new Exception("Handler not registered");

        return _handler.Handle(request);
    }

    public string Publish<TNotification>(TNotification notification)
        where TNotification : IEvent
    {
        return "Event published: " + notification;
    }
}
