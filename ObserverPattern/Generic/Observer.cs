using System;

namespace ObserverPattern.Generic
{
    public abstract class Observer<T> : IObserver<T>
    {
        private IObservable<T> _subject;

        public IObserver<T> Subscribe(IObservable<T> subject)
        {
            this._subject = subject;
            this._subject.Subscribe(this);
            return this;
        }

        public IObserver<T> Unsubscribe()
        {
            this._subject.Unsubscribe(this);
            return this;
        }

        public abstract void OnNext(T t);
    }
}