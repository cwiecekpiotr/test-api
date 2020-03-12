using System.Collections.Generic;

namespace GraphQL.Client.Http.Examples
{
	public class GetDistributorProductResponse {
		public DistributorProduct getDistributorProduct { get; set; }

		public class DistributorProduct {
			public string Ean { get; set; }
			public string Id { get; set; }
			public string Key { get; set; }
		}
	}
}