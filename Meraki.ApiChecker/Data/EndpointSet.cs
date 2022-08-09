namespace Meraki.ApiChecker.Data;
public class EndpointSet
{
	public List<ImplementedEndpoint> ImplementedEndpoints { get; set; } = new();

	public List<DuplicatedEndpoint> DuplicatedEndpoints { get; set; } = new();

	public List<MissingEndpoint> MissingEndpoints { get; set; } = new();
}
