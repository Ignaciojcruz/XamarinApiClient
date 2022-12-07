using Newtonsoft.Json;
using System;

namespace XamarinApi.Models
{
    public class Country
    {
        [JsonProperty("Id")]
        public int Id { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("IsDeleted")]
        public bool isDeleted { get; set; }
                 
    }
}
