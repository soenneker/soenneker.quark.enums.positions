using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark.Enums;

/// <summary>
/// An HTML CSS keyword set in .NET enumeration form
/// </summary>
[EnumValue<string>]
public sealed partial class PositionKeyword
{
    /// <summary>
    /// Default static positioning.
    /// </summary>
    public static readonly PositionKeyword Static = new("static");

    /// <summary>
    /// Positioned relative to its normal position.
    /// </summary>
    public static readonly PositionKeyword Relative = new("relative");

    /// <summary>
    /// Positioned relative to the nearest positioned ancestor.
    /// </summary>
    public static readonly PositionKeyword Absolute = new("absolute");

    /// <summary>
    /// Positioned relative to the viewport.
    /// </summary>
    public static readonly PositionKeyword Fixed = new("fixed");

    /// <summary>
    /// Positioned based on the user's scroll position.
    /// </summary>
    public static readonly PositionKeyword Sticky = new("sticky");

    public static implicit operator PositionKeyword(GlobalKeyword style) => new(style.Value);
}
