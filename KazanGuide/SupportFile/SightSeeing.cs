using System;

namespace KazanGuide
{
	public class SightSeeing
	{
		public string sightName;
		public string shortText;
		public double latitude;
		public double longitude;
		public string adress;
		public string audioFileName;
		public int imageId; // Здесь используется внутренняя нумерация всех изображений. Как использовать - показано в файле main.cs

		public SightSeeing (string sightName, string shortText, double latitude, double longitude, string adress, string audioFileName, int imageId)
		{
			this.sightName = sightName;
			this.shortText = shortText;
			this.latitude = latitude;
			this.longitude = longitude;
			this.adress = adress;
			this.audioFileName = audioFileName;
			this.imageId = imageId;
		}

		private double distance(double lat1, double lon1, double lat2, double lon2, char unit) {
			double theta = lon1 - lon2;
			double dist = Math.Sin(deg2rad(lat1)) * Math.Sin(deg2rad(lat2)) + Math.Cos(deg2rad(lat1)) * Math.Cos(deg2rad(lat2)) * Math.Cos(deg2rad(theta));
			dist = Math.Acos(dist);
			dist = rad2deg(dist);
			dist = dist * 60 * 1.1515;
			if (unit == 'K') {
				dist = dist * 1.609344;
			} else if (unit == 'N') {
				dist = dist * 0.8684;
			}
			return (dist);
		}

		//:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
		//::  This function converts decimal degrees to radians             :::
		//:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
		private double deg2rad(double deg) {
			return (deg * Math.PI / 180.0);
		}

		//:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
		//::  This function converts radians to decimal degrees             :::
		//:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
		private double rad2deg(double rad) {
			return (rad / Math.PI * 180.0);
		}

		public double GetDistanceTo(double latitude, double longitude)
		{
			return distance (this.latitude, this.longitude, latitude, longitude, 'K');
		}
	}
}

