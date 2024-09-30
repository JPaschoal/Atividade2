using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Atividade2
{
    public class Endereco
    {
        [JsonPropertyName("cep")]
        public string Cep { get; set; } = string.Empty;
        [JsonPropertyName("logradouro")]
        public string Logradouro { get; set; } = string.Empty;
        [JsonPropertyName("complemento")]
        public string Complemento { get; set; } = string.Empty;
        [JsonPropertyName("unidade")]
        public string Unidade { get; set; } = string.Empty;
        [JsonPropertyName("bairro")]
        public string Bairro { get; set; } = string.Empty;
        [JsonPropertyName("localidade")]
        public string Localidade { get; set; } = string.Empty;
        [JsonPropertyName("uf")]
        public string Uf { get; set; } = string.Empty;
        [JsonPropertyName("estado")]
        public string Estado { get; set; } = string.Empty;
        [JsonPropertyName("regiao")]
        public string Regiao { get; set; } = string.Empty;
        [JsonPropertyName("ibge")]
        public string Ibge { get; set; } = string.Empty;
        [JsonPropertyName("Hia")]
        public string Hia { get; set; } = string.Empty;
        [JsonPropertyName("ddd")]
        public string Ddd { get; set; } = string.Empty;
        [JsonPropertyName("siafi")]
        public string Siafi { get; set; } = string.Empty;
    }
}
