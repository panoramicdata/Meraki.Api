using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	[DataContract]
	public class Clients
	{
		/// <summary>
		/// The MAC address of the client
		/// </summary>
		[DataMember(Name = "mac")]
		public string Mac { get; set; } = string.Empty;

		/// <summary>
		/// The display name for the client.
		/// </summary>
		[DataMember(Name = "name")]
		public string? Name { get; set; }
	}
}
