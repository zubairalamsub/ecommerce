using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Catalog.API.Models
{
	//public class Product
	//{
	//	[BsonId]
	//	public string Id { get; set; }
	//	public string Name { get; set; }
	//	public string Description { get; set; }
	//	public string Category { get; set; }
	//	public string Summary { get; set; }
	//	public string ImageFile { get; set; }
	//	public decimal Price { get; set; }
	//}



	public class Product
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; }

		[BsonElement("Name")]
		public string Name { get; set; }

		[BsonElement("Category")]
		public string Category { get; set; }

		[BsonElement("Price")]
		public decimal Price { get; set; }
	}
}
