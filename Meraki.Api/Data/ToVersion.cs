using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// To version
	/// </summary>
	[DataContract]
	public partial class ToVersion
	{
		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public int Id { get; set; }

		/// <summary>
		/// Firmware
		/// </summary>
		[DataMember(Name = "firmware")]
		public string? Firmware { get; set; }

		/// <summary>
		/// Short name
		/// </summary>
		[DataMember(Name = "shortName")]
		public string? ShortName { get; set; }

		/// <summary>
		/// Release type
		/// </summary>
		[DataMember(Name = "releaseType")]
		public string? ReleaseType { get; set; }
	}
}
