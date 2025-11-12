
namespace Meraki.Api.Attributes;

[AttributeUsage(AttributeTargets.Field)]
internal class MerakiApiDomainAttribute(string merakiApiDomain) : Attribute
{
	/// <summary>
	/// Gets the meraki api domain
	/// </summary>

	public string MerakiApiDomain { get; set; } = merakiApiDomain;
}
