using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
namespace PropertyRental
{
	public class DistanceCalculator
	{
        public string destination_addresses { get; set; }
		public string origin_addresses { get; set; }
		public int distance { get; set; }
		public int duration { get; set; }
        }
    } 
//API KEY: AIzaSyC1C2d1MUZSFQ-Kc8nRxssvn9sPAwsQuIY
/*
		public void Test()
		{
			var wc = new WebClient();
			string  jSONResult = wc.DownloadString(@"https://maps.googleapis.com/maps/api/distancematrix/json?destinations=ub68bq&origins=ub11hz&unitsimperial&mode=walking&key=AIzaSyC1C2d1MUZSFQ-Kc8nRxssvn9sPAwsQuIY");
		}
		*/