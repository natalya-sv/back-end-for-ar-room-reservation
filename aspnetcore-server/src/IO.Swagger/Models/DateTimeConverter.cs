using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace IO.Swagger.Models
{
	public class DateTimeConverter : JsonConverter<DateTime>
	{
		public List<string> DateTimeFormats { get; set; }
		public override DateTime ReadJson(JsonReader reader, Type objectType, DateTime existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			string dateString = (string)reader.Value;
			DateTime date;
			
				// adjust this as necessary to fit your needs
				if (DateTime.TryParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
					return date;
			
			throw new JsonException("Unable to parse \"" + dateString + "\" as a date.");
		}

		public override void WriteJson(JsonWriter writer, DateTime value, JsonSerializer serializer)
		{
			writer.WriteValue(value.ToString("dd/MM/yyyy"));
		}
	}
}
