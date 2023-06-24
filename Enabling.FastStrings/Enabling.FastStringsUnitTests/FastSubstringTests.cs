// Licensed under MIT.

namespace Enabling.FastStringsUnitTests
{
  using System;
  using Enabling.FastStrings;
  using NUnit.Framework;

  /// <summary>
  /// The fast substring tests.
  /// </summary>
  public class FastSubstringTests
  {
    /// <summary>
    /// Gets substring - null throws exception.
    /// </summary>
    [Test]
    public void GetSubstring_NullThrowsException()
    {
      Assert.Throws<ArgumentNullException>(() => Stringz.Substring(null!, 1));
    }

    /// <summary>
    /// Gets the substring - start too big throws exception.
    /// </summary>
    [Test]
    public void GetSubstring_StartTooBigThrowsException()
    {
      Assert.Throws<ArgumentOutOfRangeException>(() => Stringz.Substring("Hello World", 100));
    }

    /// <summary>
    /// Gets the substring - start same as length throws exception.
    /// </summary>
    [Test]
    public void GetSubstring_StartSameAsLengthThrowsException()
    {
      Assert.Throws<ArgumentOutOfRangeException>(() => Stringz.Substring("Hello World", "Hello World".Length));
    }

    /// <summary>
    /// Gets the substring_ start too small throws exception.
    /// </summary>
    [Test]
    public void GetSubstring_StartTooSmallThrowsException()
    {
      Assert.Throws<ArgumentOutOfRangeException>(() => Stringz.Substring("Hello World", -1));
    }

    /// <summary>
    /// Gets the domain from email.
    /// </summary>
    [Test]
    public void GetDomainFromEmail()
    {
      string email = "hello@world.com";
      string domain = "world.com";

      string result = Stringz.Substring(email, email.IndexOf('@') + 1).ToString();

      Assert.That(result, Is.EqualTo(domain));
    }
  }
}