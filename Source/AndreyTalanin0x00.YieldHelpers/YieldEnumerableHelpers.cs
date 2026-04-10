using System.Collections.Generic;

namespace AndreyTalanin0x00.YieldHelpers;

/// <summary>
/// Provides methods to create an <see cref="IEnumerable{T}" /> object using the <see langword="yield" /> operator.
/// </summary>
public static class YieldEnumerableHelpers
{
    /// <summary>
    /// Creates an <see cref="IEnumerable{T}" /> object from a single value using the <see langword="yield" /> operator.
    /// </summary>
    /// <typeparam name="T">The value type.</typeparam>
    /// <param name="item">The value to create the <see cref="IEnumerable{T}" /> object from.</param>
    /// <returns>The <see cref="IEnumerable{T}" /> object created.</returns>
    public static IEnumerable<T> Yield<T>(T item)
    {
        yield return item;
    }
}
