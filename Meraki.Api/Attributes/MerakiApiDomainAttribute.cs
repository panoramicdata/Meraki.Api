
namespace Meraki.Api.Attributes;

[AttributeUsage(AttributeTargets.Field)]
internal class MerakiApiDomainAttribute(string merakiApiDomain) : Attribute
{
	public string MerakiApiDomain { get; set; } = merakiApiDomain;
}
