using System;

namespace Meraki.Api.Attributes
{
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	public class ApiForeignKeyAttribute : Attribute
	{
		public ApiForeignKeyAttribute(Type foreignType)
		{
			ForeignType = foreignType;
		}

		public Type ForeignType { get; }
	}
}