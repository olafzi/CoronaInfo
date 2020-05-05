namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Countries
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("areas")]
        public List<Countries> Areas { get; set; }

        [JsonProperty("totalConfirmed")]
        public long TotalConfirmed { get; set; }

        [JsonProperty("totalDeaths")]
        public long? TotalDeaths { get; set; }

        [JsonProperty("totalRecovered")]
        public long? TotalRecovered { get; set; }

        [JsonProperty("totalRecoveredDelta")]
        public long? TotalRecoveredDelta { get; set; }

        [JsonProperty("totalDeathsDelta")]
        public long? TotalDeathsDelta { get; set; }

        [JsonProperty("totalConfirmedDelta")]
        public long? TotalConfirmedDelta { get; set; }

        [JsonProperty("lastUpdated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastUpdated { get; set; }

        [JsonProperty("lat", NullValueHandling = NullValueHandling.Ignore)]
        public double? Lat { get; set; }

        [JsonProperty("long", NullValueHandling = NullValueHandling.Ignore)]
        public double? Long { get; set; }

        [JsonProperty("parentId", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }
    }

    public partial class Countries
    {
        public static Countries FromJson(string json) => JsonConvert.DeserializeObject<Countries>(json, QuickType.Converter.Settings);
    }


    public static class Serialize
    {
        public static string ToJson(this Countries self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}