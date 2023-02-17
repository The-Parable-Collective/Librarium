using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Librarium.Core.Extensions
{
    /// <summary>
    /// Extensions for transforming, mutating, and generating <see cref="IEnumerable{T}" /> collections.
    /// </summary>
    [PublicAPI]
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Performs the specified <see cref="Action{T}" /> for each item in this <see cref="IEnumerable{T}" />.
        /// </summary>
        /// <typeparam name="T">The type of the items in this <see cref="IEnumerable{T}" />.</typeparam>
        /// <param name="action">The <see cref="Action{T}" /> to perform for each item in the <see cref="IEnumerable{T}" />.</param>
        /// <remarks>
        /// If <paramref name="action" /> is <see cref="null" />, <see cref="ForEach{T}" /> will simply do nothing. If
        /// <paramref name="action" /> is not <see cref="null" />, <see cref="ForEach{T}" /> is <c>pop</c>; It will enumerate the
        /// collection.
        /// </remarks>
        public static void ForEach<T>([NotNull, InstantHandle, ItemCanBeNull]
            this IEnumerable<T> source, [CanBeNull] Action<T> action)
        {
            if (action is not null)
            {
                foreach (T item in source)
                {
                    action(item);
                }
            }
        }
    }
}