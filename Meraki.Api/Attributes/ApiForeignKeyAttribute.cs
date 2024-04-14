namespace Meraki.Api.Attributes;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
public class ApiForeignKeyAttribute(Type foreignType) : Attribute
{
	public Type ForeignType { get; } = foreignType;
}
