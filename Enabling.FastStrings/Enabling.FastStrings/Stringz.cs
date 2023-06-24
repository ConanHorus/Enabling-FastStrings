// Licensed under MIT.

namespace Enabling.FastStrings
{
  using System;
  using System.Collections.Generic;
  using System.Diagnostics.CodeAnalysis;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  /// <summary>
  /// The stringz class.
  /// </summary>
  public static class Stringz
  {
    /// <summary>
    /// Gets a substring from some string value starting at 0-based start index to the end of the string.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="startIndex">0-based index in the string to start the substring from to the end of the string.</param>
    /// <returns>A ReadOnlyMemory.</returns>
    public static ReadOnlyMemory<char> Substring([DisallowNull] this string value, int startIndex)
    {
      if (value is null)
      {
        throw new ArgumentNullException(nameof(value));
      }

      if (value.Length <= startIndex)
      {
        throw new ArgumentOutOfRangeException(
          $"start index of {startIndex} is beyond the length of the string, which is {value.Length} character long.",
          nameof(startIndex));
      }

      if (startIndex < 0)
      {
        throw new ArgumentOutOfRangeException(
          $"start index of {startIndex} is less than 0.",
          nameof(startIndex));
      }

      return value.AsMemory().Slice(startIndex);
    }
  }
}