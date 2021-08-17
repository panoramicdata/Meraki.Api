using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	[DataContract]
	public class WlanList
	{

		[DataMember(Name = "createdAt")]
		public DateTime CreatedAt { get; set; }

		[DataMember(Name = "id")]
		public string Id { get; set; }

		[DataMember(Name = "xml")]
		public string Xml { get; set; } = string.Empty;
	}

}
