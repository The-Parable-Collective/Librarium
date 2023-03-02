using System.Linq;
using JetBrains.Annotations;

namespace System
{
    /// <summary>
    /// Extension methods for the <see cref="enum" /> value type.
    /// </summary>
    [PublicAPI]
    public static class EnumExtensions
    {
        /// <summary>
        /// Gets the value of this <see cref="Enum" /> as an <see cref="int" />.
        /// </summary>
        [Pure]
        public static int AsInt([NotNull] this Enum enumA) => (int) (object) enumA;

        /// <summary>
        /// Gets whether this <typeparamref name="T" /> equals the specified <typeparamref name="T" />.
        /// </summary>
        /// <typeparam name="T">
        /// The type of both <see cref="enum" /> values.
        /// </typeparam>
        /// <param name="enumB">
        /// The <see cref="enum" /> to check against.
        /// </param>
        [Pure]
        public static bool Is<T>([NotNull] this T enumA, T enumB) where T : Enum => enumA.Equals(enumB);

        /// <summary>
        /// Gets whether this <typeparamref name="T" /> equals any of the specified <typeparamref name="T" /> values.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the <see cref="enum" /> values.
        /// </typeparam>
        /// <param name="enums">
        /// The <see cref="enum" /> values to check against.
        /// </param>
        [Pure]
        public static bool IsAnyOf<T>([NotNull] this T enumA, [NotNull, InstantHandle] params T[] enums) where T : Enum => enums.Any(x => x.Is(enumA));

        /// <summary>
        /// Gets whether this <typeparamref name="T" /> equals none of the specified <typeparamref name="T" /> values.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the <see cref="enum" /> values.
        /// </typeparam>
        /// <param name="enums">
        /// The <see cref="enum" /> values to check against.
        /// </param>
        [Pure]
        public static bool IsNoneOf<T>([NotNull] this T enumA, [NotNull, InstantHandle] params T[] enums) where T : Enum => !enums.Any(x => x.Is(enumA));


        /// <summary>
        /// Gets whether this <typeparamref name="T" /> is equal to the specified <typeparamref name="T" /> or a higher backing
        /// <see cref="int" />.
        /// </summary>
        /// <typeparam name="T">
        /// The type of both <see cref="enum" /> values.
        /// </typeparam>
        /// <param name="enumB">
        /// The <see cref="enum" /> to check against.
        /// </param>
        /// <remarks>
        /// Example:
        /// <code>dayOfWeek.IsAtLeast(DayOfWeek.Wednesday)</code>
        /// returns true for Wednesday, Thursday, etc. and false for Monday, Tuesday, etc.
        /// </remarks>
        [Pure]
        public static bool IsAtLeast<T>([NotNull] this T enumA, T enumB) where T : Enum => Convert.ToInt32(enumA) >= Convert.ToInt32(enumB);

        /// <summary>
        /// Gets whether this <typeparamref name="T" /> does not equal the specified <typeparamref name="T" />.
        /// </summary>
        /// <typeparam name="T">
        /// The type of both enums.
        /// </typeparam>
        /// <param name="enumB">
        /// The enum to check against.
        /// </param>
        [Pure]
        public static bool IsNot<T>([NotNull] this T enumA, T enumB) where T : Enum => !enumA.Is(enumB);
    }
}