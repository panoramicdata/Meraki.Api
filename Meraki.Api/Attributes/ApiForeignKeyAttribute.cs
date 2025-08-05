namespace Meraki.Api.Attributes;

/// <summary>
/// API Foreign Key Attribute
/// </summary>
/// <param name="foreignType"></param>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
public class ApiForeignKeyAttribute(Type foreignType) : Attribute
{
	/// <summary>
	/// Foreign Type
	/// </summary>
	public Type ForeignType { get; } = foreignType;
}
