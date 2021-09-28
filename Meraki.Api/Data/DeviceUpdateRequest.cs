using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkDevice
	/// </summary>
	[DataContract]
	public class DeviceUpdateRequest
	{
		/// <summary>
		/// The name of a device
		/// </summary>
		/// <value>The name of a device</value>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;
		/// <summary>
		/// The tags of a device
		/// </summary>
		/// <value>The tags of a device</value>
		[DataMember(Name = "tags")]
		public List<string> Tags { get; set; } = new();

		/// <summary>
		/// The latitude of a device
		/// </summary>
		/// <value>The latitude of a device</value>
		[DataMember(Name = "lat")]
		public double? Lat { get; set; }

		/// <summary>
		/// The longitude of a device
		/// </summary>
		/// <value>The longitude of a device</value>
		[DataMember(Name = "lng")]
		public double? Lng { get; set; }

		/// <summary>
		/// The address of a device
		/// </summary>
		/// <value>The address of a device</value>
		[DataMember(Name = "address")]
		public string Address { get; set; } = string.Empty;

		/// <summary>
		/// The notes for the device. String. Limited to 255 characters.
		/// </summary>
		/// <value>The notes for the device. String. Limited to 255 characters.</value>
		[DataMember(Name = "notes")]
		public string Notes { get; set; } = string.Empty;

		/// <summary>
		/// Whether or not to set the latitude and longitude of a device based on the new address. Only applies when lat and lng are not specified.
		/// </summary>
		/// <value>Whether or not to set the latitude and longitude of a device based on the new address. Only applies when lat and lng are not specified.</value>
		[DataMember(Name = "moveMapMarker")]
		public bool? MoveMapMarker { get; set; }

		/// <summary>
		/// The ID of a switch profile to bind to the device (for available switch profiles, see the &#39;Switch Profiles&#39; endpoint). Use null to unbind the switch device from the current profile. For a device to be bindable to a switch profile, it must (1) be a switch, and (2) belong to a network that is bound to a configuration template.
		/// </summary>
		/// <value>The ID of a switch profile to bind to the device (for available switch profiles, see the &#39;Switch Profiles&#39; endpoint). Use null to unbind the switch device from the current profile. For a device to be bindable to a switch profile, it must (1) be a switch, and (2) belong to a network that is bound to a configuration template.</value>
		[DataMember(Name = "switchProfileId")]
		public string? SwitchProfileId { get; set; }

		/// <summary>
		/// The floor plan to associate to this device. null disassociates the device from the floorplan.
		/// </summary>
		/// <value>The floor plan to associate to this device. null disassociates the device from the floorplan.</value>
		[DataMember(Name = "floorPlanId")]
		public string? FloorPlanId { get; set; }
	}
}
