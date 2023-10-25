
using Catalog.API;
using Catalog.API.Protos;
using Grpc.Net.Client;
// Create a channel to the server
var channel = GrpcChannel.ForAddress("http://localhost:5023");

// Create a client with the channel
var client = new Greeter.GreeterClient(channel);
var client2 = new CatalogService.CatalogServiceClient(channel);


// Call the service operations
var reply = client.SayHello(new HelloRequest { Name = "GreeterClient" });
var reply2 = client2.GetItemById(new GetItemByIdRequest { Id = "1" });



Console.WriteLine("Greeting: " + reply.Message);
Console.WriteLine("Greeting: " + reply2.Name);
Console.ReadLine();


//// Create a client with the channel
//var client = new CatalogService.CatalogServiceClient(channel);

//// Call the service operations
//var reply = client.GetItemById(new GetItemByIdRequest { Id = "1" });

//Console.WriteLine("Greeting: " + reply.Name);
Console.ReadLine();
