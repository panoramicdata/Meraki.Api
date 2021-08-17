using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Pii response
	/// </summary>
	[DataContract]
	public class PiiResponse
	{
		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; } = string.Empty;

		/// <summary>
		/// Organization wide
		/// </summary>
		[DataMember(Name = "organizationWide")]
		public bool OrganizationWide { get; set; }

		/// <summary>
		/// Network id
		/// </summary>
		[DataMember(Name = "networkId")]
		public string NetworkId { get; set; } = string.Empty;

		/// <summary>
		/// Type
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;

		/// <summary>
		/// Mac
		/// </summary>
		[DataMember(Name = "mac")]
		public string Mac { get; set; } = string.Empty;

		/// <summary>
		/// Datasets
		/// </summary>
		[DataMember(Name = "datasets")]
		public string Datasets { get; set; } = string.Empty;

		/// <summary>
		/// Status
		/// </summary>
		[DataMember(Name = "status")]
		public string Status { get; set; } = string.Empty;

		/// <summary>
		/// Created at
		/// </summary>
		[DataMember(Name = "createdAt")]
		public int CreatedAt { get; set; }

		/// <summary>
		/// Completed at
		/// </summary>
		[DataMember(Name = "completedAt")]
		public int CompletedAt { get; set; }
	}
}
