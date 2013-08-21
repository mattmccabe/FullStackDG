using System;
using System.Web;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace FullStackDG
{

	public class ZipCodeInfo
	{
		public ZipCodeInfo ()
		{
		}

		[BsonId]
		public string ZipCode
		{
			get;
			set;
		}

		[BsonElement("state")]
		public string StateAbbr
		{
			get;set;
		}
		[BsonElement("city")]
		public string City
		{
			get;set;
		}

		[BsonElement("pop")]
		public int Population
		{
			get;set;
		}

		[BsonElement("loc")]
		public List<decimal> Location
		{
			get;
			set;
		}

		/*
		[BsonElement("residents")]
		[BsonIgnoreIfNull]
		public List<Resident> Residents
		{
			get;
			set;
		}
		*/

		[BsonExtraElements]
		public Dictionary<string, object> ExtraStuff {get;set;}


	}


	public class Resident
	{
		public string Name {get;set;}
		public string Title {get;set;}
	}
}

