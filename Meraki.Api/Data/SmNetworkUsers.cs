using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// SM Users
	/// </summary>
	[DataContract]

	public class SmNetworkUsers
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
		/// Full name
		/// </summary>
		[DataMember(Name = "fullName")]
		public string FullName { get; set; } = string.Empty;

		/// <summary>
		/// Username
		/// </summary>
		[DataMember(Name = "username")]
		public string Username { get; set; } = string.Empty;

		/// <summary>
		/// Has password
		/// </summary>
		[DataMember(Name = "hasPassword")]
		public bool HasPassword { get; set; }

		/// <summary>
		/// Tags
		/// </summary>
		[DataMember(Name = "tags")]
		public List<string> Tags { get; set; } = new();

		/// <summary>
		/// Ad groups
		/// </summary>
		[DataMember(Name = "adGroups")]
		public List<string> AdGroups { get; set; } = new();

		/// <summary>
		/// Azure ad groups
		/// </summary>
		[DataMember(Name = "azureAdGroups")]
		public List<string> AzureAdGroups { get; set; } = new();

		/// <summary>
		/// Asm groups
		/// </summary>
		[DataMember(Name = "asmGroups")]
		public List<string> AsmGroups { get; set; } = new();

		/// <summary>
		/// Is external
		/// </summary>
		[DataMember(Name = "isExternal")]
		public bool IsExternal { get; set; }

		/// <summary>
		/// Display name
		/// </summary>
		[DataMember(Name = "displayName")]
		public string DisplayName { get; set; } = string.Empty;

		/// <summary>
		/// Has identity certificate
		/// </summary>
		[DataMember(Name = "hasIdentityCertificate")]
		public bool HasIdentityCertificate { get; set; }

		/// <summary>
		/// User thumbnail
		/// </summary>
		[DataMember(Name = "userThumbnail")]
		public string UserThumbnail { get; set; } = string.Empty;
	}
}
