namespace Meraki.Api.Attributes;

/// <summary>
/// Used to denote how the property can be used with the API
/// </summary>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
public class ApiAccessAttribute(ApiAccess apiAccess) : Attribute
{
	/// <summary>
	/// Denotes the ApiAccess level
	/// </summary>
	public ApiAccess ApiAccess { get; } = apiAccess;
}
