using Newtonsoft.Json;

namespace BalancaDaVidaAPI.Models
{
    public class Food
    {

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("nome", NullValueHandling = NullValueHandling.Ignore)]
        public string Nome { get; set; }

        [JsonProperty("descricao", NullValueHandling = NullValueHandling.Ignore)]
        public string Descricao { get; set; }

        [JsonProperty("umidade", NullValueHandling = NullValueHandling.Ignore)]
        public string Umidade { get; set; }

        [JsonProperty("energia_kcal", NullValueHandling = NullValueHandling.Ignore)]
        public string EnergiaKcal { get; set; }

        [JsonProperty("proteina_g", NullValueHandling = NullValueHandling.Ignore)]
        public string ProteinaG { get; set; }

        [JsonProperty("colesterol_mg", NullValueHandling = NullValueHandling.Ignore)]
        public string ColesterolMg { get; set; }

        [JsonProperty("carboidrato_g", NullValueHandling = NullValueHandling.Ignore)]
        public string CarboidratoG { get; set; }

        [JsonProperty("fibra_g", NullValueHandling = NullValueHandling.Ignore)]
        public string FibraG { get; set; }

        [JsonProperty("calcio_mg", NullValueHandling = NullValueHandling.Ignore)]
        public string CalcioMg { get; set; }

        [JsonProperty("ferro_mg", NullValueHandling = NullValueHandling.Ignore)]
        public string FerroMg { get; set; }

        [JsonProperty("sodio_mg", NullValueHandling = NullValueHandling.Ignore)]
        public string SodioMg { get; set; }

        [JsonProperty("potassio_mg", NullValueHandling = NullValueHandling.Ignore)]
        public string PotassioMg { get; set; }

        [JsonProperty("vitaminaC_mg", NullValueHandling = NullValueHandling.Ignore)]
        public string VitaminaCMg { get; set; }

        [JsonProperty("saturados_g", NullValueHandling = NullValueHandling.Ignore)]
        public string SaturadosG { get; set; }

        [JsonProperty("monoinsaturados_g", NullValueHandling = NullValueHandling.Ignore)]
        public string MonoinsaturadosG { get; set; }

        [JsonProperty("poliinsaturados_g", NullValueHandling = NullValueHandling.Ignore)]
        public string PoliinsaturadosG { get; set; }
    }
}
