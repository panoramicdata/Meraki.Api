namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworkWirelessElectronicShelfLabel
{
	/// <summary>
	/// Return the ESL settings of a wireless network
	/// </summary>
	/// <param name="networkId">Network Id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkWirelessElectronicShelfLabel")]
	[Get("/networks/{networkId}/wireless/electronicShelfLabel")]
	Task<ElectronicShelfLabelSettingsNetwork> GetNetworkWirelessElectronicShelfLabelAsync(
		string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update the ESL settings of a wireless network
	/// </summary>
	/// <param name="networkId">Network Id</param>
	/// <param name="settings">Update Settings</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkWirelessElectronicShelfLabel")]
	[Put("/networks/{networkId}/wireless/electronicShelfLabel")]
	Task<ElectronicShelfLabelSettingsNetwork> UpdateNetworkWirelessElectronicShelfLabelAsync(
		string networkId,
		[Body] ElectronicShelfLabelSettingsNetwork settings,
		CancellationToken cancellationToken = default);
}
