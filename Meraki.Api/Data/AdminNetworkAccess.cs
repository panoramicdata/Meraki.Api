﻿using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// An admin's network access
	/// </summary>
	[DataContract]
	public class AdminNetworkAccess : IdentifiedItem
	{
		/// <summary>
		/// Network access permissions
		/// </summary>
		[DataMember(Name = "access")]
		public string Access { get; set; } = string.Empty;
	}
}