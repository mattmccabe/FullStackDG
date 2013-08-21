using System;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB.Bson;

namespace FullStackDG
{
	public class MongoDBHelper
	{
		public MongoDBHelper ()
		{

		}
		
		public static MongoCollection GetCollection(string db, string collection)
		{
			return GetDatabase(db).GetCollection<BsonDocument>(collection);
		}

		public static MongoDatabase GetDatabase(string db)
		{
			MongoClient client = new MongoClient();
			MongoServer mongoServer = client.GetServer();
			MongoDatabase database = mongoServer.GetDatabase(db);
			return database;
		}
	}
}

