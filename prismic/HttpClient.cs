﻿using System;

using System.Net;
using System.IO;
using System.Text;

namespace prismic
{
	public static class HttpClient
	{

		public static String fetch(String url, ILogger logger, ICache cache)
		{
			// TODO: Cache
			HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
			HttpWebResponse response = request.GetResponse () as HttpWebResponse;
			if (response.StatusCode != HttpStatusCode.OK)
				throw new Exception(String.Format(
					"Server error (HTTP {0}: {1}).",
					response.StatusCode,
					response.StatusDescription));
			StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
			return reader.ReadToEnd();
		}

	}
}

