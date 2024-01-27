namespace Meraki.ApiChecker.Data;
public class EndpointSet
{
	public List<ImplementedEndpoint> ImplementedEndpoints { get; set; } = [];

	public List<DuplicatedEndpoint> DuplicatedEndpoints { get; set; } = [];

	public List<MissingEndpoint> MissingEndpoints { get; set; } = [];
}
