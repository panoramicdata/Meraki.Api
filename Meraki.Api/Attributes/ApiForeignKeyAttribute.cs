namespace Meraki.Api.Attributes;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
public class ApiForeignKeyAttribute : Attribute
{
	public ApiForeignKeyAttribute(Type foreignType)
	{
		ForeignType = foreignType;
	}

	public Type ForeignType { get; }
}
