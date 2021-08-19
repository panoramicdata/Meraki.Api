using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// User access devices
	/// </summary>
	[DataContract]
	public class UserAccessDevices
	{
		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; } = string.Empty;

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// System type
		/// </summary>
		[DataMember(Name = "systemType")]
		public string SystemType { get; set; } = string.Empty;

		/// <summary>
		/// Mac
		/// </summary>
		[DataMember(Name = "mac")]
		public string Mac { get; set; } = string.Empty;

		/// <summary>
		/// Username
		/// </summary>
		[DataMember(Name = "username")]
		public string Username { get; set; } = string.Empty;

		/// <summary>
		/// Email
		/// </summary>
		[DataMember(Name = "email")]
		public string Email { get; set; } = string.Empty;

		/// <summary>
		/// Tags
		/// </summary>
		[DataMember(Name = "tags")]
		public List<string> Tags { get; set; } = new();

		/// <summary>
		/// Trusted access connections
		/// </summary>
		[DataMember(Name = "trustedAccessConnections")]
		public TrustedAccessConnections TrustedAccessConnections { get; set; } = new();
	}
}
