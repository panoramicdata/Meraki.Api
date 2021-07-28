using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Data rate history
	/// </summary>
	[DataContract]
	public class DataRateHistory
	{
		/// <summary>
		/// StartTs
		/// </summary>
		[DataMember(Name = "startTs")]
		public string StartTs { get; set; } = string.Empty;

		/// <summary>
		/// EndTs
		/// </summary>
		[DataMember(Name = "endTs")]
		public string EndTs { get; set; } = string.Empty;

		/// <summary>
		/// Average Kbps
		/// </summary>
		[DataMember(Name = "averageKbps")]
		public int AverageKbps { get; set; } = 0;

		/// <summary>
		/// Download Kbps
		/// </summary>
		[DataMember(Name = "downloadKbps")]
		public int DownloadKbps { get; set; } = 0;

		/// <summary>
		/// UploadKbps
		/// </summary>
		[DataMember(Name = "uploadKbps")]
		public int UploadKbps { get; set; } = 0;
	}
}
