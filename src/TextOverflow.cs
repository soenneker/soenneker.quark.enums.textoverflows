using Intellenum;

namespace Soenneker.Quark.Enums;

/// <summary>
/// An HTML CSS keyword set in .NET enumeration form
/// </summary>
[Intellenum<string>]
public sealed partial class TextOverflow
{
    public static readonly TextOverflow Clip = new("clip");
    public static readonly TextOverflow Ellipsis = new("ellipsis");
    public static readonly TextOverflow String = new("string");
}
