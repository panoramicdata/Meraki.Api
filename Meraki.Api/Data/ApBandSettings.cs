using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Settings that will be enabled if selectionType is set to &#39;ap&#39;.
	/// </summary>
	[DataContract]
	public partial class ApBandSettings
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ApBandSettings" /> class.
		/// </summary>
		/// <param name="BandOperationMode">BandOperationMode.</param>
		/// <param name="BandSteeringEnabled">Steers client to most open band. Can be either true or false. Defaults to true..</param>
		public ApBandSettings(BandOperationMode BandOperationMode = default, bool? BandSteeringEnabled = default)
		{
			this.BandOperationMode = BandOperationMode;
			this.BandSteeringEnabled = BandSteeringEnabled;
		}

		/// <summary>
		/// Gets or Sets BandOperationMode
		/// </summary>
		[DataMember(Name = "bandOperationMode", EmitDefaultValue = false)]
		public BandOperationMode BandOperationMode { get; set; }
		/// <summary>
		/// Steers client to most open band. Can be either true or false. Defaults to true.
		/// </summary>
		/// <value>Steers client to most open band. Can be either true or false. Defaults to true.</value>
		[DataMember(Name = "bandSteeringEnabled", EmitDefaultValue = false)]
		public bool? BandSteeringEnabled { get; set; }
	}
}