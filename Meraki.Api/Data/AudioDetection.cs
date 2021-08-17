using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The details of the audio detection config.
	/// </summary>
	public partial class AudioDetection
	{
		/// <summary>
		/// Boolean indicating if audio detection is enabled(true) or disabled(false) on the camera
		/// </summary>
		[DataMember(Name = "enabled")]
		public bool Enabled { get; set; }
	}
}
