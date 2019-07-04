using System;
using System.Linq;
using System.Collections.Generic;

namespace ObserverPattern.Generic
{
    public abstract class Observable<T> : IObservable<T>
    {   
        private readonly ICollection<IObserver<T>> _subscribers;

        public Observable()
        {
            this._subscribers = new List<IObserver<T>>();
        }

        public void Subscribe(IObserver<T> observer)
        {
            this._subscribers.Add(observer);
        }

        public void Unsubscribe(IObserver<T> observer)
        {
            this._subscribers.Remove(observer);
        }

        public void Next(T t)
        {
            this._subscribers
                .Select(e => e)
                .ToList()
                .ForEach(o => o.OnNext(t));
        }
    }
}