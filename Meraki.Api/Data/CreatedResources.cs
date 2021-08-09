using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Created resources
	/// </summary>
	[DataContract]
	public class CreatedResources
	{
		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public int Id { get; set; }

		/// <summary>
		/// Uri
		/// </summary>
		[DataMember(Name = "uri")]
		public string Uri { get; set; } = string.Empty;
	}
}
