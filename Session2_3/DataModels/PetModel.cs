using Newtonsoft.Json;

namespace Session2_3.DataModels
{
    [TestClass]
    public class PetModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("category")]
        public PetCategory Category { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }


        [JsonProperty("photoUrls")]
        public string[] PhotoUrls { get; set; }

        [JsonProperty("tags")]
        public PetCategory[] Tags { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
    public class PetCategory
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}