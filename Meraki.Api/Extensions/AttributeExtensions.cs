
namespace Meraki.Api.Extensions;

public static class AttributeExtensions
{
	public static string GetMerakiApiDomain(this Enum value)
	{
		var type = value.GetType();
		var field = type.GetField(value.ToString());
		var attribute = (MerakiApiDomainAttribute?)field?
			.GetCustomAttributes(typeof(MerakiApiDomainAttribute), false)?
			.FirstOrDefault();
		return attribute?.MerakiApiDomain ?? string.Empty;
	}
}