namespace ProjectManga.Domain.Vos
{
    using System;

    /// <summary>
    /// Base class for value objects.
    /// </summary>
    public abstract class ValueObject<T> : IEquatable<T>
        where T : class
    {
        /*
         * Currently empty will be useful for
         * all value object shared behaviors.
         */


        public sealed override bool Equals(object obj)
        {
            return Equals(obj as T);
        }

        public bool Equals(T other)
        {
            return other != null && (ReferenceEquals(this, other) || DeepEquals(other));
        }

        protected abstract bool DeepEquals(T other);
    }
}