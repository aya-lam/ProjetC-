using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JsonHandler
{


    public partial class ServerResponse
    {
        [JsonProperty("head")]
        public Head Head { get; set; }

        [JsonProperty("results")]
        public Results Results { get; set; }
    }

    public partial class Head
    {
        [JsonProperty("vars")]
        public string[] Vars { get; set; }
    }

    public partial class Results
    {
        [JsonProperty("bindings")]
        public Binding[] Bindings { get; set; }
    }


    // Class, holding the JSON values. All variables have a default value in case that the server returns none.
    public partial class Binding
    {
        [JsonProperty("_______________")]
        public Empty DateOfBirth
        {
            get; set;
        } = new Empty() { Value = new DateTimeOffset(1, 1, 1, 1, 1, 1, 1, new TimeSpan(1,0,0)) };

        [JsonProperty("itemLabel")]
        public Label ItemLabel { get; set; } = new Label() { Value = "Unknown" };

        [JsonProperty("_____________________Label")]
        public Label Team
        {
            get; set;
        } = new Label() { Value = "Unknown" };

        [JsonProperty("_______Label")]
        public Label Position
        {
            get; set;
        } = new Label() { Value = "Unknown" };

        
        [JsonProperty("competition_classLabel")]
        public Label CompetitionClass
        {
            get; set;
        } = new Label() { Value = "Unknown" };

        [JsonProperty("___________Label")]
        public Label CitizenshipCountry
        {
            get; set;
        } = new Label() { Value = "Unknown" };

        [JsonProperty("country_for_sportLabel")]
        public Label CountryForSport
        {
            get; set;
        } = new Label() { Value = "Unknown" };


        [JsonProperty("Basketball_Reference_com_NBA_player_ID")]
        public BasketballReferenceComNbaPlayerId BasketballReferenceComNbaPlayerId { get; set; } = new BasketballReferenceComNbaPlayerId() { Value = "Unknown" };
    }

    public partial class Label
    {

        [JsonProperty("xml:lang")]
        public string XmlLang { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value
        {
            get; set;
        }
    }

    public partial class Empty
    {
        [JsonProperty("datatype")]
        public Uri Datatype { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public DateTimeOffset Value { get; set; }
    }

    public partial class BasketballReferenceComNbaPlayerId
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class ServerResponse
    {
        public static ServerResponse FromJson(string json) => JsonConvert.DeserializeObject<ServerResponse>(json, JsonHandler.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this ServerResponse self) => JsonConvert.SerializeObject(self, JsonHandler.Converter.Settings);
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
