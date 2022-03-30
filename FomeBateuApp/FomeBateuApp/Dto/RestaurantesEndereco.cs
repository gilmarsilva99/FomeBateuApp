using Newtonsoft.Json;

namespace FomeBateuApp.Dto
{
    public class RestaurantesEndereco
    {        
        public int Id { get; set; }
        public string Endereco { get; private set; }
        public string Cep { get; private set; }
        public string Cidade { get; private set; }
        public string Uf { get; private set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public int RestauranteId { get; set; }

        [JsonIgnore]
        public Restaurantes Restaurantes { get; set; }

}
}
