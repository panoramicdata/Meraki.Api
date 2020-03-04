using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	[DataContract]
	public class Usage
	{
		[DataMember(Name = "sent")]
		public double Sent { get; set; }

		[DataMember(Name = "recv")]
		public double Recv { get; set; }
	}
}