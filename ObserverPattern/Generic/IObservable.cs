using System;

namespace ObserverPattern.Generic
{
    public interface IObservable<T>
    {
        void Subscribe(IObserver<T> observer);
        void Unsubscribe(IObserver<T> observer);
        void Next(T t);
    }
}