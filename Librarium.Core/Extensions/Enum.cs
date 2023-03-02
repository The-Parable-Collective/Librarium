using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace System
{
    /// <summary>
    /// Generic static class for <see cref="Enum" /> that allows
    /// type casting.
    /// </summary>
    /// <typeparam name="T">
    /// The <see cref="enum" /> type.
    /// </typeparam>
    [PublicAPI]
    public static class Enum<T> where T : Enum
    {
        /// <summary>
        /// Gets an <see cref="IEnumerable{T}" /> collection of the values of <typeparamref name="T" />.
        /// </summary>
        [NotNull, ItemNotNull]
        public static IEnumerable<T> Values => Enum.GetValues(typeof(T)).Cast<T>();
    }
}