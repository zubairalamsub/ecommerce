﻿using Catalog.API.Models;
using MongoDB.Driver;
using MongoRepo.Context;

namespace Catalog.API.Context
{
	public class MongoDBContext
	{
		private readonly IMongoDatabase _database;

		public MongoDBContext(string connectionString, string databaseName)
		{
			var client = new MongoClient(connectionString);
			_database = client.GetDatabase(databaseName);
		}

		public IMongoCollection<Product> Products => _database.GetCollection<Product>("Product");
	}
}
