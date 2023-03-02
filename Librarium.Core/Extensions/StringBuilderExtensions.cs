using System.Collections.Generic;
using JetBrains.Annotations;

namespace System.Text
{
    /// <summary>
    /// Extensions to add extra functionality to <see cref="StringBuilder" /> construction.
    /// </summary>
    [PublicAPI]
    public static class StringBuilderExtensions
    {
        /// <summary>
        /// Appends each <see cref="string" /> in the specified <see cref="IEnumerable" /> <see cref="string" /> collection to the
        /// <see cref="StringBuilder" />. This does not insert new lines.
        /// </summary>
        /// <param name="collection">
        /// The source collection to iterate over.
        /// </param>
        /// <returns>
        /// Returns the <see cref="StringBuilder" />.
        /// </returns>
        /// <remarks>
        /// This method is <c>pop</c>; it will enumerate the collection.
        /// </remarks>
        [NotNull]
        public static StringBuilder AppendForEach([NotNull] this StringBuilder sb, [NotNull, InstantHandle] IEnumerable<string> collection)
        {
            collection.ForEach(x => sb.Append(x));
            return sb;
        }

        /// <summary>
        /// Appends each <see cref="string" /> in the specified <see cref="IEnumerable" /> <see cref="string" /> collection to the
        /// <see cref="StringBuilder" /> followed by the default line terminator.
        /// </summary>
        /// <param name="collection">
        /// The source collection to iterate over.
        /// </param>
        /// <returns>
        /// Returns the <see cref="StringBuilder" />.
        /// </returns>
        /// <remarks>
        /// This method is <c>pop</c>; it will enumerate the collection.
        /// </remarks>
        [NotNull]
        public static StringBuilder AppendLineForEach([NotNull] this StringBuilder sb, [NotNull, InstantHandle] IEnumerable<string> collection)
        {
            collection.ForEach(x => sb.AppendLine(x));
            return sb;
        }

        /// <summary>
        /// Appends a <see cref="string" /> to the <see cref="StringBuilder" /> for each item in the specified
        /// <see cref="IEnumerable{T}" />, transformed
        /// by the <paramref name="formatAction" />.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the items in the <see cref="IEnumerable{T}" />.
        /// </typeparam>
        /// <param name="collection">
        /// The source collection to iterate over.
        /// </param>
        /// <param name="formatAction">
        /// Transforms each item in the <see cref="IEnumerable{T}" /> to a <see cref="string" /> that
        /// will be appended.
        /// </param>
        /// <returns>
        /// Returns the <see cref="StringBuilder" />.
        /// </returns>
        /// <remarks>
        /// This method is <c>pop</c>; it will enumerate the collection.
        /// </remarks>
        [NotNull]
        public static StringBuilder AppendForEach<T>([NotNull] this StringBuilder sb, [NotNull, InstantHandle] IEnumerable<T> collection, [NotNull, InstantHandle] Func<T, string> formatAction)
        {
            collection.ForEach(x => sb.Append(formatAction(x)));
            return sb;
        }

        /// <summary>
        /// Appends the <see cref="string" /> to the <see cref="StringBuilder" /> only if the conditions of the given
        /// <see cref="Predicate{T}" /> are satisfied.
        /// </summary>
        /// <param name="appendString">
        /// The <see cref="string" /> to append.
        /// </param>
        /// <param name="predicate">
        /// The <see cref="Predicate{string}" /> that determines whether or not to append the <see cref="string" />. If it returns
        /// <see cref="true" />, the <see cref="string" /> is appended; otherwise does nothing.
        /// </param>
        /// <returns>
        /// Returns the <see cref="StringBuilder" /> even if nothing is appended.
        /// </returns>
        [NotNull]
        public static StringBuilder AppendIf([NotNull] this StringBuilder sb, [CanBeNull] string appendString, [NotNull, InstantHandle] Predicate<string> predicate) => predicate(appendString) ? sb.Append(appendString) : sb;

        /// <summary>
        /// Appends the <see cref="string" /> to the <see cref="StringBuilder" /> only if it is not <see cref="null" />, empty, or
        /// white-space.
        /// </summary>
        /// <param name="appendString">
        /// The <see cref="string" /> to append.
        /// </param>
        /// <returns>
        /// Returns the <see cref="StringBuilder" /> even if nothing is appended.
        /// </returns>
        [NotNull]
        public static StringBuilder AppendIfNotNullOrWhiteSpace([NotNull] this StringBuilder sb, [CanBeNull] string appendString) => sb.AppendIf(appendString, s => !s.IsNullOrWhiteSpace());

        /// <summary>
        /// Appends the <see cref="string" /> to the <see cref="StringBuilder" /> only if the matching string is not
        /// <see cref="null" />, empty, or white-space. Used for if you need to check against a mutated form of the
        /// <see cref="string" />, but
        /// still need the original to be appended.
        /// </summary>
        /// <param name="matchString">
        /// The <see cref="string" /> to use for matches.
        /// </param>
        /// <param name="appendString">
        /// The string to append to the <see cref="StringBuilder" /> if the condition is satisfied.
        /// </param>
        /// <returns>
        /// Returns the <see cref="StringBuilder" /> even if nothing is appended.
        /// </returns>
        [NotNull]
        public static StringBuilder AppendIfNotNullOrWhiteSpace([NotNull] this StringBuilder sb, [CanBeNull] string matchString, [CanBeNull] string appendString) => sb.AppendIf(appendString, _ => !matchString.IsNullOrWhiteSpace());
    }
}