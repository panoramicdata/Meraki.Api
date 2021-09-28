using System;

namespace Meraki.Api.Attributes
{
	/// <summary>
	/// Used to denote how the property can be used with the API
	/// </summary>
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	public class ApiAccessAttribute : Attribute
	{
		public ApiAccessAttribute(ApiAccess apiAccess)
		{
			ApiAccess = apiAccess;
		}

		/// <summary>
		/// Denotes the ApiAccess level
		/// </summary>
		public ApiAccess ApiAccess { get; }
	}
}