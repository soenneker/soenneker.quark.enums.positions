using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents a CSS <c>position</c> keyword.
/// </summary>
[EnumValue<string>]
[IncludeEnumValues(typeof(GlobalKeyword))]
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
    /// Leaves normal flow and uses its containing block for offsets.
    /// </summary>
    public static readonly PositionKeyword Absolute = new("absolute");

    /// <summary>
    /// Leaves normal flow and is usually positioned relative to the viewport.
    /// </summary>
    public static readonly PositionKeyword Fixed = new("fixed");

    /// <summary>
    /// Behaves relatively until a scroll threshold is reached.
    /// </summary>
    public static readonly PositionKeyword Sticky = new("sticky");
}
