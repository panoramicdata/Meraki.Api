using Meraki.Api.Attributes;
using System;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A change log entry
	/// </summary>
	[DataContract]
	public class ChangeLogEntry
	{
		/// <summary>
		/// The Timestamp
		/// </summary>
		[DataMember(Name = "ts")]
		[ApiAccess(ApiAccess.Read)]
		public DateTime TimeStamp { get; set; }

		/// <summary>
		/// The admin name
		/// </summary>
		[DataMember(Name = "adminName")]
		[ApiAccess(ApiAccess.Read)]
		public string AdminName { get; set; } = string.Empty;

		/// <summary>
		/// The admin email address
		/// </summary>
		[DataMember(Name = "adminEmail")]
		[ApiAccess(ApiAccess.Read)]
		public string AdminEmail { get; set; } = string.Empty;

		/// <summary>
		/// The admin id
		/// </summary>
		[DataMember(Name = "adminId")]
		[ApiAccess(ApiAccess.Read)]
		public string AdminId { get; set; } = string.Empty;

		/// <summary>
		/// The page
		/// </summary>
		[DataMember(Name = "page")]
		[ApiAccess(ApiAccess.Read)]
		public string Page { get; set; } = string.Empty;

		/// <summary>
		/// The label
		/// </summary>
		[DataMember(Name = "label")]
		[ApiAccess(ApiAccess.Read)]
		public string Label { get; set; } = string.Empty;

		/// <summary>
		/// The old value
		/// </summary>
		[DataMember(Name = "oldValue")]
		[ApiAccess(ApiAccess.Read)]
		public string OldValue { get; set; } = string.Empty;

		/// <summary>
		/// The new value
		/// </summary>
		[DataMember(Name = "newValue")]
		[ApiAccess(ApiAccess.Read)]
		public string NewValue { get; set; } = string.Empty;

		/// <summary>
		/// The Name of the Network
		/// </summary>
		[DataMember(Name = "networkName")]
		[ApiAccess(ApiAccess.Read)]
		public string? NetworkName { get; set; }

		/// <summary>
		/// The Name of the Network
		/// </summary>
		[DataMember(Name = "networkId")]
		[ApiAccess(ApiAccess.Read)]
		public string? NetworkId { get; set; }

		public override string ToString() => Label;
	}
}