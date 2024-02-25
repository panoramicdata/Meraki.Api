namespace Meraki.Api.Interfaces.Products.Camera;

public interface ICameraBoundaries
{
	/// <summary>
	/// Returns all configured area boundaries of cameras
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="serials">A list of serial numbers. The returned cameras will be filtered to only include these serials.</param>
	[Get("/organizations/{organizationId}/camera/boundaries/areas/byDevice")]
	Task<List<CameraBoundariesAreas>> GetOrganizationCameraBoundariesAreasByDeviceAsync(
		string organizationId,
		[AliasAs("serials[]")] List<string>? serials = null,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Returns all configured crossingline boundaries of cameras
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="serials">A list of serial numbers. The returned cameras will be filtered to only include these serials.</param>
	[Get("/organizations/{organizationId}/camera/boundaries/lines/byDevice")]
	Task<List<CameraBoundariesLines>> GetOrganizationCameraBoundariesLinesByDeviceAsync(
		string organizationId,
		[AliasAs("serials[]")] List<string>? serials = null,
		CancellationToken cancellationToken = default
		);
}
