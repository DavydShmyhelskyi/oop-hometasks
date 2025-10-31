namespace Observer.Interfaces
{    public interface ISubject
    {
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
        void Notify(string product);
    }
}
