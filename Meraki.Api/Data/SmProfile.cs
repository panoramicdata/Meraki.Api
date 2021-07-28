using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Sm profiles
	/// </summary>
	[DataContract]
	public class SmProfile
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
		/// Description
		/// </summary>
		[DataMember(Name = "description")]
		public string Desription { get; set; } = string.Empty;

		/// <summary>
		/// Scope
		/// </summary>
		[DataMember(Name = "scope")]
		public string Scope { get; set; } = string.Empty;

		/// <summary>
		/// Tags
		/// </summary>
		[DataMember(Name = "tags")]
		public List<string> Tags { get; set; } = new();
	}
}
