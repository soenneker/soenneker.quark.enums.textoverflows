using Intellenum;

namespace Soenneker.Quark.Enums;

/// <summary>
/// An HTML CSS keyword set in .NET enumeration form
/// </summary>
[Intellenum<string>]
public sealed partial class TextOverflowKeyword
{
    public static readonly TextOverflowKeyword Clip = new("clip");
    public static readonly TextOverflowKeyword Ellipsis = new("ellipsis");
    public static readonly TextOverflowKeyword String = new("string");
}
