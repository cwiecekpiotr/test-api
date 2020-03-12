using System;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using GraphQL.Client.Serializer.Newtonsoft;

namespace GraphQL.Client.Http.Examples {

	public class Program {
		public static async Task Main(string[] args) {
			using var graphQLClient = new GraphQLHttpClient("#TutajWkleićUrl");

			var testRequest = new GraphQLRequest {
				Query = @"
			    query {
			        getDistributorProduct(id: ""71889"") {
						id
						key
			            ean
			        }
			    }",
			};
			var graphQLResponse = await graphQLClient.SendQueryAsync<GetDistributorProductResponse>(testRequest);
			Console.WriteLine("raw response:");
			Console.WriteLine(JsonSerializer.Serialize(graphQLResponse, new JsonSerializerOptions { WriteIndented = true }));

			Console.WriteLine();
			Console.WriteLine("Press any key to quit...");
			Console.ReadKey();
		}
	}
}