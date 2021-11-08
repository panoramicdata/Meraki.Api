using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Camera sense update request
	/// </summary>
	[DataContract]
	public class CameraSenseUpdateRequest : CameraSense
	{
		/// <summary>
		/// The ID of the object detection model
		/// </summary>
		[ApiAccess(ApiAccess.Update)]
		[DataMember(Name = "detectionModelId")]
		public string DetectionModelId { get; set; } = string.Empty;
	}
}
