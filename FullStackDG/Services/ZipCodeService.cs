using System;
using ServiceStack.ServiceInterface;
using ServiceStack.ServiceHost;
using MongoDB.Driver;
using System.Collections.Generic;
using MongoDB.Bson;

namespace FullStackDG
{

	[Route("/zips")]
	public class ZipsRest
	{

	}

	[Route("/zips/{ZipCode}")]
	public class ZipResidents
	{
		public string ZipCode {get;set;}
		public string Name {get;set;}
		public string Title {get;set;}
	}


	public class ZipCodeService:Service
	{
		public ZipCodeService ()
		{

		}
	

		public List<ZipCodeInfo> Get(ZipsRest zipCode)
		{
			//items={start}-{end}
			var rangeHeader = base.Request.Headers["Range"];
			//{start}-{end}
			string range = rangeHeader.Split(new char[]{'='})[1];
			//Parse out start and end
			string[] ranges = range.Split(new char[]{'-'});

			int start = int.Parse(ranges[0]);
			int end = int.Parse(ranges[1]);
			long totalCount;
			MongoCollection zipCollection = MongoDBHelper.GetCollection("fullstackdg", "zips"); 

			totalCount = zipCollection.Count();

			var cursor = zipCollection.FindAllAs<ZipCodeInfo>();
			cursor.Skip = start;
			cursor.Limit = end - start;

			List<ZipCodeInfo> zips = new List<ZipCodeInfo>();
			foreach (var item in cursor) {
				zips.Add(item);
			}

			base.Response.AddHeader("Content-Range", String.Format("{0}-{1}/{2}", start, end, totalCount));
			return zips;
		}

		public object Get(ZipResidents resident)
		{
			Console.WriteLine(resident.ZipCode);
			return "good";
		}


		public void Post(ZipResidents resident)
		{
			Console.WriteLine(resident.ZipCode);
			MongoCollection zipCollection = MongoDBHelper.GetCollection("fullstackdg", "zips"); 
			var zipInfo = zipCollection.FindOneByIdAs<ZipCodeInfo>(resident.ZipCode);
			/*if(zipInfo.Residents == null)
			{
				zipInfo.Residents = new List<Resident>();
			}
			zipInfo.Residents.Add(new Resident {Name=resident.Name, Title=resident.Title});
*/
			zipCollection.Save(zipInfo);

		}


		/*
		public List<ZipCodeInfo> Get(ZipsRest zipCode)
		{
			//var range = base.Request.Headers["Range"];
			MongoCollection zipCollection = MongoDBHelper.GetCollection("fullstackdg", "zips"); 
			var cursor = zipCollection.FindAllAs<ZipCodeInfo>();
			cursor.Skip = 600;
			cursor.Limit = 100;
			
			List<ZipCodeInfo> zips = new List<ZipCodeInfo>();
			foreach (var item in cursor) {
				zips.Add(item);
			}
			
			return zips;
		}
		*/

	}
}

