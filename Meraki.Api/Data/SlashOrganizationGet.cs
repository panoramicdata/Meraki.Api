using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Get
	/// </summary>
	[DataContract]
	public class SlashOrganizationGet
	{
		/// <summary>
		/// Description
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// Operation id
		/// </summary>
		[DataMember(Name = "operationId")]
		public string OperationId { get; set; } = string.Empty;

		/// <summary>
		/// Responses
		/// </summary>
		[DataMember(Name = "responses")]
		public Responses Responses { get; set; } = new();
	}
}
