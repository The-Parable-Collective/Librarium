using JetBrains.Annotations;

namespace Librarium.Core.Extensions
{
    /// <summary>
    /// Contains extensions for doing math, including transforming primitive value types and advanced calculations.
    /// </summary>
    [PublicAPI]
    public static class MathExtensions
    {
        #region Add

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

        #endregion

        #region Subtract

        /// <summary>
        /// Subtracts the specified amount from the <see cref="int" />.
        /// </summary>
        /// <param name="amount">
        /// The amount to subtract.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref int Subtract(this ref int initial, int amount)
        {
            initial -= amount;
            return ref initial;
        }

        /// <summary>
        /// Subtracts the specified amount from the <see cref="float" />.
        /// </summary>
        /// <param name="amount">
        /// The amount to subtract.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref float Subtract(this ref float initial, float amount)
        {
            initial -= amount;
            return ref initial;
        }

        /// <summary>
        /// Subtracts the specified amount from the <see cref="long" />.
        /// </summary>
        /// <param name="amount">
        /// The amount to Subtract.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref long Subtract(this ref long initial, long amount)
        {
            initial -= amount;
            return ref initial;
        }

        /// <summary>
        /// Subtracts the specified amount from the <see cref="uint" />.
        /// </summary>
        /// <param name="amount">
        /// The amount to Subtract.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref uint Subtract(this ref uint initial, uint amount)
        {
            initial -= amount;
            return ref initial;
        }

        /// <summary>
        /// Subtracts the specified amount from the <see cref="ulong" />.
        /// </summary>
        /// <param name="amount">
        /// The amount to Subtract.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref ulong Subtract(this ref ulong initial, ulong amount)
        {
            initial -= amount;
            return ref initial;
        }

        /// <summary>
        /// Subtracts the specified amount from the <see cref="decimal" />.
        /// </summary>
        /// <param name="amount">
        /// The amount to Subtract.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref decimal Subtract(this ref decimal initial, decimal amount)
        {
            initial -= amount;
            return ref initial;
        }

        /// <summary>
        /// Subtracts the specified amount from the <see cref="double" />.
        /// </summary>
        /// <param name="amount">
        /// The amount to Subtract.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref double Subtract(this ref double initial, double amount)
        {
            initial -= amount;
            return ref initial;
        }

        /// <summary>
        /// Subtracts the specified amount from the <see cref="short" />.
        /// </summary>
        /// <param name="amount">
        /// The amount to Subtract.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref short Subtract(this ref short initial, short amount)
        {
            initial -= amount;
            return ref initial;
        }

        /// <summary>
        /// Subtracts the specified amount from the <see cref="ushort" />.
        /// </summary>
        /// <param name="amount">
        /// The amount to Subtract.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref ushort Subtract(this ref ushort initial, ushort amount)
        {
            initial -= amount;
            return ref initial;
        }

        /// <summary>
        /// Subtracts the specified amount from the <see cref="sbyte" />.
        /// </summary>
        /// <param name="amount">
        /// The amount to Subtract.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref sbyte Subtract(this ref sbyte initial, sbyte amount)
        {
            initial -= amount;
            return ref initial;
        }

        /// <summary>
        /// Subtracts the specified amount from the <see cref="double" />.
        /// </summary>
        /// <param name="amount">
        /// The amount to Subtract.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref byte Subtract(this ref byte initial, byte amount)
        {
            initial -= amount;
            return ref initial;
        }

        #endregion

        #region Multiply

        /// <summary>
        /// Multiplies the <see cref="int" /> by the specified amount.
        /// </summary>
        /// <param name="amount">
        /// The amount to multiply by.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref int Multiply(this ref int initial, int amount)
        {
            initial *= amount;
            return ref initial;
        }

        /// <summary>
        /// Multiplies the <see cref="float" /> by the specified amount.
        /// </summary>
        /// <param name="amount">
        /// The amount to multiply by.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref float Multiply(this ref float initial, float amount)
        {
            initial *= amount;
            return ref initial;
        }

        /// <summary>
        /// Multiplies the <see cref="long" /> by the specified amount.
        /// </summary>
        /// <param name="amount">
        /// The amount to multiply by.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref long Multiply(this ref long initial, long amount)
        {
            initial *= amount;
            return ref initial;
        }

        /// <summary>
        /// Multiplies the <see cref="uint" /> by the specified amount.
        /// </summary>
        /// <param name="amount">
        /// The amount to multiply by.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref uint Multiply(this ref uint initial, uint amount)
        {
            initial *= amount;
            return ref initial;
        }

        /// <summary>
        /// Multiplies the <see cref="ulong" /> by the specified amount.
        /// </summary>
        /// <param name="amount">
        /// The amount to multiply by.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref ulong Multiply(this ref ulong initial, ulong amount)
        {
            initial *= amount;
            return ref initial;
        }

        /// <summary>
        /// Multiplies the <see cref="decimal" /> by the specified amount.
        /// </summary>
        /// <param name="amount">
        /// The amount to multiply by.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref decimal Multiply(this ref decimal initial, decimal amount)
        {
            initial *= amount;
            return ref initial;
        }

        /// <summary>
        /// Multiplies the <see cref="double" /> by the specified amount.
        /// </summary>
        /// <param name="amount">
        /// The amount to multiply by.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref double Multiply(this ref double initial, double amount)
        {
            initial *= amount;
            return ref initial;
        }

        /// <summary>
        /// Multiplies the <see cref="short" /> by the specified amount.
        /// </summary>
        /// <param name="amount">
        /// The amount to multiply by.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref short Multiply(this ref short initial, short amount)
        {
            initial *= amount;
            return ref initial;
        }

        /// <summary>
        /// Multiplies the <see cref="ushort" /> by the specified amount.
        /// </summary>
        /// <param name="amount">
        /// The amount to multiply by.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref ushort Multiply(this ref ushort initial, ushort amount)
        {
            initial *= amount;
            return ref initial;
        }

        /// <summary>
        /// Multiplies the <see cref="sbyte" /> by the specified amount.
        /// </summary>
        /// <param name="amount">
        /// The amount to multiply by.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref sbyte Multiply(this ref sbyte initial, sbyte amount)
        {
            initial *= amount;
            return ref initial;
        }

        /// <summary>
        /// Multiplies the <see cref="byte" /> by the specified amount.
        /// </summary>
        /// <param name="amount">
        /// The amount to multiply by.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref byte Multiply(this ref byte initial, byte amount)
        {
            initial *= amount;
            return ref initial;
        }

        #endregion

        #region Divide

        /// <summary>
        /// Divides the <see cref="int" /> by the specified amount.
        /// </summary>
        /// <param name="amount">
        /// The amount to divide by.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref int Divide(this ref int initial, int amount)
        {
            initial /= amount;
            return ref initial;
        }

        /// <summary>
        /// Divides the <see cref="float" /> by the specified amount.
        /// </summary>
        /// <param name="amount">
        /// The amount to divide by.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref float Divide(this ref float initial, float amount)
        {
            initial /= amount;
            return ref initial;
        }

        /// <summary>
        /// Divides the <see cref="long" /> by the specified amount.
        /// </summary>
        /// <param name="amount">
        /// The amount to divide by.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref long Divide(this ref long initial, long amount)
        {
            initial /= amount;
            return ref initial;
        }

        /// <summary>
        /// Divides the <see cref="uint" /> by the specified amount.
        /// </summary>
        /// <param name="amount">
        /// The amount to divide by.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref uint Divide(this ref uint initial, uint amount)
        {
            initial /= amount;
            return ref initial;
        }

        /// <summary>
        /// Divides the <see cref="ulong" /> by the specified amount.
        /// </summary>
        /// <param name="amount">
        /// The amount to divide by.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref ulong Divide(this ref ulong initial, ulong amount)
        {
            initial /= amount;
            return ref initial;
        }

        /// <summary>
        /// Divides the <see cref="decimal" /> by the specified amount.
        /// </summary>
        /// <param name="amount">
        /// The amount to divide by.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref decimal Divide(this ref decimal initial, decimal amount)
        {
            initial /= amount;
            return ref initial;
        }

        /// <summary>
        /// Divides the <see cref="double" /> by the specified amount.
        /// </summary>
        /// <param name="amount">
        /// The amount to divide by.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref double Divide(this ref double initial, double amount)
        {
            initial /= amount;
            return ref initial;
        }

        /// <summary>
        /// Divides the <see cref="short" /> by the specified amount.
        /// </summary>
        /// <param name="amount">
        /// The amount to divide by.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref short Divide(this ref short initial, short amount)
        {
            initial /= amount;
            return ref initial;
        }

        /// <summary>
        /// Divides the <see cref="ushort" /> by the specified amount.
        /// </summary>
        /// <param name="amount">
        /// The amount to divide by.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref ushort Divide(this ref ushort initial, ushort amount)
        {
            initial /= amount;
            return ref initial;
        }

        /// <summary>
        /// Divides the <see cref="sbyte" /> by the specified amount.
        /// </summary>
        /// <param name="amount">
        /// The amount to divide by.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref sbyte Divide(this ref sbyte initial, sbyte amount)
        {
            initial /= amount;
            return ref initial;
        }

        /// <summary>
        /// Divides the <see cref="byte" /> by the specified amount.
        /// </summary>
        /// <param name="amount">
        /// The amount to divide by.
        /// </param>
        /// <returns>
        /// Returns the final amount.
        /// </returns>
        /// <remarks>
        /// This method works by reference.
        /// </remarks>
        public static ref byte Divide(this ref byte initial, byte amount)
        {
            initial /= amount;
            return ref initial;
        }

        #endregion
    }
}