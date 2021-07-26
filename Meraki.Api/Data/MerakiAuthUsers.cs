using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Meraki users
	/// </summary>
	[DataContract]
	public class MerakiAuthUsers
	{
		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; } = string.Empty;

		/// <summary>
		/// Email
		/// </summary>
		[DataMember(Name = "email")]
		public string Email { get; set; } = string.Empty;

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Created at
		/// </summary>
		[DataMember(Name = "createdAt")]
		public string CreatedAt { get; set; } = string.Empty;

		/// <summary>
		/// Account type
		/// </summary>
		[DataMember(Name = "accountType")]
		public string AccountType { get; set; } = string.Empty;

		/// <summary>
		/// Authorizations
		/// </summary>
		[DataMember(Name = "id")]
		public Authorizations Authorizations { get; set; } = new();
	}
}
