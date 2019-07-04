using System;

namespace ObserverPattern.Generic
{
    public interface IObserver<T>
    {
        IObserver<T> Subscribe(IObservable<T> subject);
        IObserver<T> Unsubscribe();
        void OnNext(T t);
    }

}