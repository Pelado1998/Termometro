using System;

namespace Observer
{    public interface IObserbable<T>
    {
        void Subscribe(T observer);
        void Unsubscribe(T observer);
        void NotifyObservers();
    }
}