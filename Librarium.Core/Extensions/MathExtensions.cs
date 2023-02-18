namespace Librarium.Core.Extensions
{
    /// <summary>
    /// Contains extensions for doing math, including transforming primitive value types and advanced calculations.
    /// </summary>
    public static class MathExtensions
    {
        /// <summary>
        /// Adds the specified amount to the <see cref="int" />.
        /// </summary>
        /// <param name="amount">
        /// The amount to add.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref int Add(this ref int initial, int amount)
        {
            initial += amount;
            return ref initial;
        }

        /// <summary>
        /// Adds the specified amount to the <see cref="float" />.
        /// </summary>
        /// <param name="amount">
        /// The amount to add.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref float Add(this ref float initial, float amount)
        {
            initial += amount;
            return ref initial;
        }

        /// <summary>
        /// Adds the specified amount to the <see cref="long" />.
        /// </summary>
        /// <param name="amount">
        /// The amount to add.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref long Add(this ref long initial, long amount)
        {
            initial += amount;
            return ref initial;
        }

        /// <summary>
        /// Adds the specified amount to the <see cref="uint" />.
        /// </summary>
        /// <param name="amount">
        /// The amount to add.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref uint Add(this ref uint initial, uint amount)
        {
            initial += amount;
            return ref initial;
        }

        /// <summary>
        /// Adds the specified amount to the <see cref="ulong" />.
        /// </summary>
        /// <param name="amount">
        /// The amount to add.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref ulong Add(this ref ulong initial, ulong amount)
        {
            initial += amount;
            return ref initial;
        }

        /// <summary>
        /// Adds the specified amount to the <see cref="decimal" />.
        /// </summary>
        /// <param name="amount">
        /// The amount to add.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref decimal Add(this ref decimal initial, decimal amount)
        {
            initial += amount;
            return ref initial;
        }

        /// <summary>
        /// Adds the specified amount to the <see cref="double" />.
        /// </summary>
        /// <param name="amount">
        /// The amount to add.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref double Add(this ref double initial, double amount)
        {
            initial += amount;
            return ref initial;
        }

        /// <summary>
        /// Adds the specified amount to the <see cref="short" />.
        /// </summary>
        /// <param name="amount">
        /// The amount to add.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref short Add(this ref short initial, short amount)
        {
            initial += amount;
            return ref initial;
        }

        /// <summary>
        /// Adds the specified amount to the <see cref="ushort" />.
        /// </summary>
        /// <param name="amount">
        /// The amount to add.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref ushort Add(this ref ushort initial, ushort amount)
        {
            initial += amount;
            return ref initial;
        }

        /// <summary>
        /// Adds the specified amount to the <see cref="sbyte" />.
        /// </summary>
        /// <param name="amount">
        /// The amount to add.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref sbyte Add(this ref sbyte initial, sbyte amount)
        {
            initial += amount;
            return ref initial;
        }

        /// <summary>
        /// Adds the specified amount to the <see cref="double" />.
        /// </summary>
        /// <param name="amount">
        /// The amount to add.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref byte Add(this ref byte initial, byte amount)
        {
            initial += amount;
            return ref initial;
        }
    }
}