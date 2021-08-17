using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Device restrictions
	/// </summary>
	[DataContract]
	public class SmDeviceRestrictions
	{
		/// <summary>
		/// Profile
		/// </summary>
		[DataMember(Name = "profile")]
		public string Profile { get; set; } = string.Empty;

		/// <summary>
		/// Restrictions
		/// </summary>
		[DataMember(Name = "restrictions")]
		public Restrictions Restrictions { get; set; } = new();
	}
}
