namespace Shop.Common.Models
{
    using System;
    using Newtonsoft.Json;

    public partial class Product
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("price")]
        public long Price { get; set; }

        [JsonProperty("imagenUrl")]
        public string ImagenUrl { get; set; }

        [JsonProperty("lastPurchase")]
        public object LastPurchase { get; set; }

        [JsonProperty("lastSale")]
        public object LastSale { get; set; }

        [JsonProperty("isAvaible")]
        public bool IsAvaible { get; set; }

        [JsonProperty("stock")]
        public long Stock { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("imageFullPath")]
        public Uri ImageFullPath { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Price:C2}";
        }
    }
}
