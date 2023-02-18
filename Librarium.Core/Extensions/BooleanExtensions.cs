﻿using JetBrains.Annotations;

namespace Librarium.Core.Extensions
{
    /// <summary>
    /// Extensions for manipulating <see cref="bool" /> primitives.
    /// </summary>
    [PublicAPI]
    public static class BooleanExtensions
    {
        /// <summary>
        /// Toggles a <see cref="bool" /> value.
        /// </summary>
        /// <returns>
        /// Returns the <see cref="bool" /> as a reference.
        /// </returns>
        /// <remarks>
        /// This method works by reference, so the return value is of optional use.
        /// </remarks>
        public static ref bool Toggle(this ref bool b)
        {
            b = !b;
            return ref b;
        }

        /// <summary>
        /// Collapses a nullable <see cref="bool" /> to the specified value if it is <see cref="null" />. Else does nothing.
        /// </summary>
        /// <param name="pullResistValue">
        /// The value to collapse the <see cref="bool" /> to.
        /// </param>
        /// <returns>
        /// Returns the nullable <see cref="bool" /> as a reference. Note that this will never be null after the method returns
        /// despite
        /// returning the nullable <see cref="bool" /> (which is the point).
        /// </returns>
        /// <remarks>
        /// This method works by reference, so the return value is of optional use.
        /// </remarks>
        [NotNull]
        public static ref bool? PullResistTo([CanBeNull] this ref bool? b, bool pullResistValue)
        {
            b ??= pullResistValue;

            return ref b;
        }
    }
}