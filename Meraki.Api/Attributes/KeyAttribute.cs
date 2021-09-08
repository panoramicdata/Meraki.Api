using System;

namespace Meraki.Api.Attributes
{
	/// <summary>
	/// Denotes the property that uniquely identifies the entity
	/// </summary>
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	public class KeyAttribute : Attribute
	{
	}
}