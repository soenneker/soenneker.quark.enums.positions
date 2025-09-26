using Intellenum;

namespace Soenneker.Quark;

/// <summary>
/// An HTML CSS keyword set in .NET enumeration form
/// </summary>
[Intellenum<string>]
public sealed partial class Position
{
    /// <summary>
    /// Default static positioning.
    /// </summary>
    public static readonly Position Static = new("static");

    /// <summary>
    /// Positioned relative to its normal position.
    /// </summary>
    public static readonly Position Relative = new("relative");

    /// <summary>
    /// Positioned relative to the nearest positioned ancestor.
    /// </summary>
    public static readonly Position Absolute = new("absolute");

    /// <summary>
    /// Positioned relative to the viewport.
    /// </summary>
    public static readonly Position Fixed = new("fixed");

    /// <summary>
    /// Positioned based on the user's scroll position.
    /// </summary>
    public static readonly Position Sticky = new("sticky");

    public static implicit operator Position(GlobalKeyword style) => new(style.Value);
}
