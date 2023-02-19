using System.Linq;
using JetBrains.Annotations;

namespace System.Collections.Generic
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

        /// <summary>
        /// Takes the specified page with the specified size from this collection.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the items in the collection.
        /// </typeparam>
        /// <param name="amount">
        /// The amount of items in the collection that should be in each page.
        /// </param>
        /// <param name="page">
        /// The page to take. If a number is not specified, takes the first page. Observe that <paramref name="page" /> is 0-based;
        /// for example page 1 is the second page in the collection.
        /// </param>
        /// <returns>
        /// Returns the <see cref="IEnumerable{T}" />.
        /// </returns>
        /// <remarks>
        /// This method is <c>non-pop</c>; It will not enumerate the collection.  If <paramref name="page" /> is the last page, and
        /// the remaining items are less than <paramref name="amount" />, the remaining items are returned and will not produce
        /// trailing null items. If <paramref name="page" /> is out of range, no items will be returned.
        /// </remarks>
        [NotNull, Pure, LinqTunnel]
        public static IEnumerable<T> TakePage<T>([NotNull] this IEnumerable<T> collection,
            [ValueRange(0, int.MaxValue)] int amount, [ValueRange(0, int.MaxValue)] int page = 0)
            => collection.Skip(amount * page).Take(amount);
    }
}