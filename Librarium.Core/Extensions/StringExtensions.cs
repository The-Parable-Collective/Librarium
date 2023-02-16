using JetBrains.Annotations;

namespace System
{
    /// <summary>
    /// Extensions to add extra functionality to <see cref="string" /> primitives.
    /// </summary>
    [PublicAPI]
    public static class StringExtensions
    {
        /// <summary>
        /// Indicates whether the <see cref="string" /> is equal to another <see cref="string" />, ignoring case.
        /// </summary>
        /// <param name="compareTo">
        /// The <see cref="string" /> to compare this <see cref="string" /> to.
        /// </param>
        [Pure]
        public static bool EqualsIgnoreCase(this string s, string compareTo) => string.Equals(s, compareTo, StringComparison.CurrentCultureIgnoreCase);

        /// <summary>
        /// Indicates whether the <see cref="string" /> is <see cref="null" /> or empty.
        /// </summary>
        [Pure, ContractAnnotation("null=>true")]
        public static bool IsNullOrEmpty([CanBeNull] this string s) => string.IsNullOrEmpty(s);

        /// <summary>
        /// Indicates whether <see cref="string" /> is <see cref="null" />, empty, or consists only
        /// of white-space characters.
        /// </summary>
        [Pure, ContractAnnotation("null=>true")]
        public static bool IsNullOrWhiteSpace([CanBeNull] this string s) => string.IsNullOrWhiteSpace(s);

        /// <summary>
        /// Indicates whether the <see cref="string" /> is empty, but not <see cref="null" /> and not white-space.
        /// </summary>
        [Pure, ContractAnnotation("null=>false")]
        public static bool IsEmpty([CanBeNull] this string s) => string.IsNullOrWhiteSpace(s) && s is not null && (s == string.Empty);

        /// <summary>
        /// Indicates whether the <see cref="string" /> is empty or consists only of white-space characters, but is
        /// not <see cref="null" />.
        /// </summary>
        [Pure, ContractAnnotation("null=>false")]
        public static bool IsWhitespace([CanBeNull] this string s) => string.IsNullOrWhiteSpace(s) && s is not null;

        #if NET472 || NET48
        /// <summary>
        /// Returns a <see cref="string" /> with its first character capitalized.
        /// </summary>
        [CanBeNull]
        public static string ToFirstUpper(this string s) => s.IsNullOrWhiteSpace() ? s : string.Concat(char.ToUpper(s[0]), s.Substring(1));
        #else
        /// <summary>
        /// Returns a <see cref="string" /> with its first character capitalized.
        /// </summary>
        [CanBeNull]
        public static string ToFirstUpper(this string s) => s.IsNullOrWhiteSpace() ? s : string.Concat(char.ToUpper(s[0]), s[1..]);
        #endif
    }
}